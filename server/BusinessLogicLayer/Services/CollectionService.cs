using AutoMapper;
using BusinessLogicLayer.Exceptions;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Services.Abstractions;
using Common.DTO;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ApplicationTask = DataAccessLayer.Models.Task;
using ThreadTask = System.Threading.Tasks.Task;

namespace BusinessLogicLayer.Services
{
    public class CollectionService:BaseService, ICollectionService
    {
        private readonly IRepository<Project> _projectsRep;
        private readonly IRepository<ApplicationTask> _tasksRep;
        private readonly IRepository<TaskState> _taskStatesRep;
        private readonly IRepository<Team> _teamsRep;
        private readonly IRepository<User> _usersRep;

        public CollectionService(IRepository<Project> projectRep,
                                 IRepository<ApplicationTask> taskRep,
                                 IRepository<TaskState> taskStates,
                                 IRepository<Team> teamRep,
                                 IRepository<User> userRep,
                                 IMapper mapper) :base(mapper)
        {
            _projectsRep = projectRep;
            _tasksRep = taskRep;
            _taskStatesRep = taskStates;
            _teamsRep = teamRep;
            _usersRep = userRep;
        }

        /// <summary>
        /// This is solution for 1st task from LINQ homework
        /// </summary>
        public async Task<Dictionary<int, int>> GetProjectsIdAndTaskCount(int projectOwnerId)
        {
            if (_usersRep.Get().SingleOrDefault(u => u.Id == projectOwnerId) == null)
                throw new NotFoundException(typeof(User), projectOwnerId);

            var result = await _projectsRep.Get().Where(p => p.AuthorId == projectOwnerId)
                                     .Include(p => p.Tasks)
                                     .ToDictionaryAsync(p => p.Id, p => p.Tasks.Count());

            return result;
        }

        /// <summary>
        /// This is solution for 2nd task from LINQ homework
        /// </summary>
        public async Task<IEnumerable<TaskDTO>> GetUsersTask(int userId)
        {
            if(_usersRep.Get().SingleOrDefault(u => u.Id == userId) == null)
                throw new NotFoundException(typeof(User), userId);

            var result = await _tasksRep.Get().Where(t => t.PerformerId == userId &&
                                               t.Name.Length < 45)
                                        .Select(t => _mapper.Map<TaskDTO>(t))
                                        .ToArrayAsync();
            return result;
        }

        /// <summary>
        /// This is solution for 3d task from LINQ homework
        /// </summary>
        public async Task<IEnumerable<TaskIdNameDTO>> GetFinishedUserTasks(int userId)
        {
            if (_usersRep.Get().SingleOrDefault(u => u.Id == userId) == null)
                throw new NotFoundException(typeof(User), userId);

            var filteredTasks = await _tasksRep.Get().Include(t => t.TaskState)
                                         .Where(t => t.PerformerId == userId &&
                                                t.FinishedAt.Year == 2020 &&
                                                t.TaskState.State == "Finished")
                                         .Select(t => new TaskIdNameDTO { Id = t.Id, Name = t.Name })
                                         .ToArrayAsync();

            return filteredTasks;
        }

        /// <summary>
        /// This is solution for 4th task from LINQ homework
        /// </summary>
        public async Task<IEnumerable<TeamWithUsersDTO>> GetTeamsWithUsers()
        {
            var result = await _teamsRep.Get().Include(t => t.Users)
                                        .Where(t => t.Users.Any(u => 2020 - u.Birthday.Year > 10))
                                        .Select(t => new TeamWithUsersDTO
                                        {
                                            TeamId = t.Id,
                                            TeamName = t.Name,
                                            Members = t.Users.Where(u => 2020 - u.Birthday.Year > 10)
                                                                    .OrderByDescending(u => u.RegisteredAt)
                                                                    .Select(u => _mapper.Map<UserDTO>(u))
                                        })
                                        .ToArrayAsync();

            return result;
        }

        /// <summary>
        /// This is solution for 5th task from LINQ homework
        /// </summary>
        public async Task<IEnumerable<UserWithTasks>> GetUsersWithTasks()
        {
            var result = await _usersRep.Get().OrderBy(u => u.FirstName)
                                        .Include(u => u.Tasks)
                                        .Select(u => new UserWithTasks
                                        {
                                            User = _mapper.Map<UserDTO>(u),
                                            Tasks = u.Tasks.OrderByDescending(t => t.Name.Length).Select(t => _mapper.Map<TaskDTO>(t))
                                        })
                                        .ToArrayAsync();

            return result;
        }

        /// <summary>
        /// This is solution for 6th task from LINQ homework
        /// </summary>
        public async Task<LastProjectAndTaskInfoDTO> GetLastUserProject(int userId)
        {
            if (_usersRep.Get().SingleOrDefault(u => u.Id == userId) == null)
                throw new NotFoundException(typeof(User), userId);

            var finishedTaskStatus = _taskStatesRep.Get().FirstOrDefault(t => t.State == "Finished");
            var canceledTaskStatus = _taskStatesRep.Get().FirstOrDefault(t => t.State == "Canceled");

            var user = await _usersRep.Get().Include(u => u.Projects)
                                         .ThenInclude(p => p.Tasks)
                                         .Include(u => u.Tasks)
                                         .FirstOrDefaultAsync(u => u.Id == userId);

            var lastProject = user.Projects.OrderBy(p => p.CreatedAt).LastOrDefault();

            var result = new LastProjectAndTaskInfoDTO
            {
                Author = _mapper.Map<UserDTO>(user),
                LastProject = _mapper.Map<ProjectDTO>(lastProject),
                TaskCount = lastProject?.Tasks.Count() ?? 0,
                UnfinishedOrCanceledTaskCount = user.Tasks.Count(t => t.TaskStateId != finishedTaskStatus.Id || t.TaskStateId == canceledTaskStatus.Id),
                LongestTask = _mapper.Map<TaskDTO>(user.Tasks.OrderBy(t => t.FinishedAt - t.CreatedAt).LastOrDefault())
            };

            return result;
        }

        /// <summary>
        /// This is solution for 7th task from LINQ homework
        /// </summary>
        public async Task<IEnumerable<ProjectAndTeamInfoDTO>> GetProjectWithTeam()
        {
            var result = await _projectsRep.Get().Include(p => p.Tasks)
                                                 .ThenInclude(t => t.Performer)
                                           .Include(p => p.Team)
                                           .Include(p => p.Author)
                                           .Select(p => new ProjectAndTeamInfoDTO
                                           {
                                               Project = _mapper.Map<ProjectDTO>(p),
                                               LongestTask = _mapper.Map<TaskDTO>(p.Tasks.OrderBy(t => t.Description.Length).LastOrDefault()),
                                               ShortestTask = _mapper.Map<TaskDTO>(p.Tasks.OrderBy(t => t.Name.Length).FirstOrDefault()),
                                               TeammatesCount = p.Description.Length > 20 || p.Tasks.Count() < 3 ? p.Team.Users.Count() : default
                                           })
                                           .ToArrayAsync();

            return result;
        }
    }
}
