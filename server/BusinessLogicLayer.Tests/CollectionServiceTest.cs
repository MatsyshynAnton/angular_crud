using AutoMapper;
using BusinessLogicLayer.Exceptions;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Services;
using BusinessLogicLayer.Tests.Fakes;
using Common.DTO;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using DataAccessLayer.UnitOfWork;

using ThreadTask = System.Threading.Tasks.Task;

namespace BusinessLogicLayer.Tests
{
    public class CollectionServiceTest
    {
        readonly ICollectionService _collectionService;

        readonly IRepository<Project> _projectsRep;
        readonly IRepository<Task> _tasksRep;
        readonly IRepository<TaskState> _taskStateRep;
        readonly IRepository<Team> _teamsRep;
        readonly IRepository<User> _usersRep;

        public CollectionServiceTest()
        {
            var context = new HomeworkDbContextFake();
            var unitOfWork = new UnitOfWork(context);

            _projectsRep = new RepositoryFake<Project>(context, unitOfWork);
            _tasksRep = new RepositoryFake<Task>(context, unitOfWork);
            _taskStateRep = new RepositoryFake<TaskState>(context, unitOfWork);
            _teamsRep = new RepositoryFake<Team>(context, unitOfWork);
            _usersRep = new RepositoryFake<User>(context, unitOfWork);

            _collectionService = CreateCollectionServiceInstanse();
        }

        /// <summary>
        /// 1st task from LINQ homework
        /// </summary>
        [Fact]
        public async ThreadTask GetProjectsIdAndTaskCount_WhereUserNotExist_NotFoundExceptionThrown()
        {
            await Assert.ThrowsAsync<NotFoundException>(async () => await _collectionService.GetProjectsIdAndTaskCount(0));
        }

        [Fact]
        public async ThreadTask GetProjectsIdAndTaskCount_WhenAddTwoTasks_ThanResult1And2()
        {
            var authorId = 10;

            var project = new Project 
            { 
                ProjectName = "Iron Man", 
                Description = "At least 15 characters...", 
                TeamId = 1, 
                AuthorId = authorId 
            };
            
            await _projectsRep.Create(project);
            await _projectsRep.unitOfWork.SaveChangesAsync();

            var task1 = new Task 
            { 
                Name = "Cool armor",
                Description = "It has to be realy cool!", 
                TaskStateId = 1,
                PerformerId = 4,
                ProjectId = project.Id,
            };

            var task2 = new Task
            {
                Name = "Destructive weapon",
                Description = "A lot of very danger weapon",
                TaskStateId = 1,
                PerformerId = 9,
                ProjectId = project.Id,
            };

            await _tasksRep.Create(task1);
            await _tasksRep.Create(task2);
            await _tasksRep.unitOfWork.SaveChangesAsync();

            var result = await _collectionService.GetProjectsIdAndTaskCount(project.AuthorId.GetValueOrDefault());

            Assert.Equal(2, result[project.Id]);
        }

        /// <summary>
        /// 2nd task from LINQ homework
        /// </summary>
        [Fact]
        public async ThreadTask GetUsersTask_WhenUserNotExist_NotFoundExceptionThrown()
        {
            await Assert.ThrowsAsync<NotFoundException>(async () => await _collectionService.GetUsersTask(0));
        }

        [Fact]
        public async ThreadTask GetUsersTask_WhenAddTwoTasks_ThanResultLength2()
        {
            var user = new User
            {
                FirstName = "Tony",
                LastName = "Stark",
                Email = "tonystark@starkindustry.com",
            };

            await _usersRep.Create(user);
            await _usersRep.unitOfWork.SaveChangesAsync();

            var firstTask = new Task
            {
                Name = "1st finished task name",
                Description = "1st finished task description",
                PerformerId = user.Id,
                ProjectId = 2,
                TaskStateId = 3,
            };

            var secondTask = new Task
            {
                Name = "2nd finished task name",
                Description = "2nd finished task description",
                PerformerId = user.Id,
                ProjectId = 8,
                TaskStateId = 3,
            };

            await _tasksRep.Create(firstTask);
            await _tasksRep.Create(secondTask);
            await _tasksRep.unitOfWork.SaveChangesAsync();

            var result = await _collectionService.GetUsersTask(user.Id);
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async ThreadTask GetUsersTask_WhenAddTaskAndTaskWithNameMoreThan45Characters_ThanResultLength1()
        {
            var user = new User
            {
                FirstName = "Hulk",
                LastName = "Just Hulh",
                Email = "hulk@greendomain.com",
            };

            await _usersRep.Create(user);
            await _usersRep.unitOfWork.SaveChangesAsync();

            var taskWithLengthLessThan45Characters = new Task
            {
                Name = "1st task name",
                Description = "1st task description",
                PerformerId = user.Id,
                ProjectId = 2,
                TaskStateId = 3,
            };

            var taskWithLengthMoreThan45Characters = new Task
            {
                Name = "2nd task name (more than 45 characters) :3333333333333333333",
                Description = "2nd task description ",
                PerformerId = user.Id,
                ProjectId = 8,
                TaskStateId = 2,
            };

            await _tasksRep.Create(taskWithLengthLessThan45Characters);
            await _tasksRep.Create(taskWithLengthMoreThan45Characters);
            await _tasksRep.unitOfWork.SaveChangesAsync();

            Assert.Single(await _collectionService.GetUsersTask(user.Id));
        }

        /// <summary>
        /// 3d task from LINQ homework
        /// </summary>
        [Fact]
        public async ThreadTask GetFinishedUserTasks_WhenUserNotExist_NotFoundExceptionThrown()
        {
            await Assert.ThrowsAsync<NotFoundException>(async () => await _collectionService.GetFinishedUserTasks(0));
        }

        [Fact]
        public async ThreadTask GetFinishedUserTasks_WhenAdd2FinishedTaskAt2020_ThanResultLength2()
        {
            var user = new User
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
            };

            await _usersRep.Create(user);
            await _usersRep.unitOfWork.SaveChangesAsync();

            var firstTask = new Task
            {
                Name = "1st task name",
                Description = "1st task description",
                PerformerId = user.Id,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 2,
                TaskStateId = 3,
            };

            var secondTask = new Task
            {
                Name = "2nd task name",
                Description = "2nd task description",
                PerformerId = user.Id,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 8,
                TaskStateId = 3,
            };

            await _tasksRep.Create(firstTask);
            await _tasksRep.Create(secondTask);
            await _tasksRep.unitOfWork.SaveChangesAsync();

            var result = await _collectionService.GetFinishedUserTasks(user.Id);
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async ThreadTask GetFinishedUserTasks_WhenAddUnfinishedTask_ThanResultLength0()
        {
            var user = new User
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
            };

            await _usersRep.Create(user);
            await _usersRep.unitOfWork.SaveChangesAsync();

            var task = new Task
            {
                Name = "1st task name",
                Description = "1st task description",
                PerformerId = user.Id,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 2,
                TaskStateId = 1,
            };

            await _tasksRep.Create(task);
            await _tasksRep.unitOfWork.SaveChangesAsync();

            Assert.Empty(await _collectionService.GetFinishedUserTasks(user.Id));
        }

        /// <summary>
        /// 4th task from LINQ homework
        /// </summary>
        [Fact]
        public async ThreadTask GetTeamsWithUsers_WhenAllUsersYoungerThan10_ThanTeamNotIncludesToCollection()
        {
            var team = new Team
            {
                Name = "party v minecrafte",
                CreatedAt = DateTime.Now
            };

            await _teamsRep.Create(team);
            await _teamsRep.unitOfWork.SaveChangesAsync();

            var user1 = new User
            {
                FirstName = "Svetlana",
                LastName = "Diode",
                Email = "sveta-diode@mail.ru",
                Birthday = DateTime.Parse("01/01/2013"),
                TeamId = team.Id
            };

            var user2 = new User
            {
                FirstName = "Grisha",
                LastName = "MON-Transistor",
                Email = "transistory.ruliat@gmail.com",
                Birthday = DateTime.Parse("01/01/2015"),
                TeamId = team.Id
            };

            await _usersRep.Create(user1);
            await _usersRep.Create(user2);
            await _usersRep.unitOfWork.SaveChangesAsync();

            Assert.DoesNotContain(await _collectionService.GetTeamsWithUsers(), t => t.TeamId == team.Id);
        }

        [Fact]
        public async ThreadTask GetTeamsWithUsers_WhenAddUserAtLeast10YearsOldAndUser_ThanResultMembersLength1()
        {
            var team = new Team
            {
                Name = "party v minecrafte",
                CreatedAt = DateTime.Now
            };

            await _teamsRep.Create(team);
            await _teamsRep.unitOfWork.SaveChangesAsync();

            var user15YearsOld = new User
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
                Birthday = DateTime.Parse("01/01/2005"),
                TeamId = team.Id
            };

            var user = new User
            {
                FirstName = "Svetlana",
                LastName = "Diode",
                Email = "sveta-diode@mail.ru",
                Birthday = DateTime.Parse("01/01/2013"),
                TeamId = team.Id
            };

            await _usersRep.Create(user);
            await _usersRep.Create(user15YearsOld);
            await _usersRep.unitOfWork.SaveChangesAsync();

            var result = await _collectionService.GetTeamsWithUsers();
            Assert.Single(result.Single(t => t.TeamId == team.Id).Members);
        }

        /// <summary>
        /// 5th task from LINQ homework
        /// </summary>
        [Fact]
        public async ThreadTask GetUsersWithTasks_WhenAddUserAnd2Tasks_ThanResultTasksLength2()
        {
            var user = new User
            {
                FirstName = "Svetlana",
                LastName = "Diode",
                Email = "sveta-diode@mail.ru",
                Birthday = DateTime.Parse("01/01/2013"),
            };

            await _usersRep.Create(user);
            await _usersRep.unitOfWork.SaveChangesAsync();

            var firstTask = new Task
            {
                Name = "1st task",
                Description = "1st task description",
                TaskStateId = 1,
                PerformerId = user.Id,
                ProjectId = 1,
            };

            var secondTask = new Task
            {
                Name = "2nd task",
                Description = "2nd task description",
                TaskStateId = 1,
                PerformerId = user.Id,
                ProjectId = 1,
            };

            await _tasksRep.Create(firstTask);
            await _tasksRep.Create(secondTask);
            await _tasksRep.unitOfWork.SaveChangesAsync();

            var tasks = (await _collectionService.GetUsersWithTasks()).Single(t => t.User.Id == user.Id).Tasks.ToList();
            var orderedTasks = new List<TaskDTO>(tasks).OrderByDescending(t => t.Name.Length);

            Assert.Equal(2, tasks.Count());
            Assert.True(tasks.SequenceEqual(orderedTasks));
        }

        /// <summary>
        /// 6th task from LINQ homework
        /// </summary>
        [Fact]
        public async ThreadTask GetLastUserProject_WhenUserNotFount_ThanNotFoundExceptionThrown()
        {
            await Assert.ThrowsAsync<NotFoundException>(async () => await _collectionService.GetLastUserProject(0));
        }

        [Fact]
        public async ThreadTask GetLastUserProject_ExpectedResult()
        {
            var user = new User
            {
                FirstName = "Svetlana",
                LastName = "Diode",
                Email = "sveta-diode@mail.ru",
                Birthday = DateTime.Parse("01/01/2013"),
            };

            await _usersRep.Create(user);
            await _usersRep.unitOfWork.SaveChangesAsync();

            var project = new Project
            {
                ProjectName = "project name",
                Description = "project description (at least 15 characters...)",
                TeamId = 1,
                AuthorId = user.Id,
                CreatedAt = DateTime.Now
            };

            await _projectsRep.Create(project);
            await _projectsRep.unitOfWork.SaveChangesAsync();

            //user tasks
            var task1 = new Task
            {
                Name = "1st task",
                Description = "1st task description",
                TaskStateId = 2,
                PerformerId = user.Id,
                ProjectId = 1,
            };

            var task2 = new Task
            {
                Name = "2nd task",
                Description = "2nd task description",
                TaskStateId = 4,
                PerformerId = user.Id,
                ProjectId = 1,
            };

            //project tasks
            var task3 = new Task
            {
                Name = "3d task",
                Description = "3d task description",
                TaskStateId = 2,
                PerformerId = 1,
                ProjectId = project.Id,
            };

            await _tasksRep.Create(task1);
            await _tasksRep.Create(task2);
            await _tasksRep.Create(task3);
            await _tasksRep.unitOfWork.SaveChangesAsync();

            var result = await _collectionService.GetLastUserProject(user.Id);

            Assert.Equal(user.Id, result.Author.Id);
            Assert.Equal(project.Id, result.LastProject.Id);
            Assert.Equal(1, result.TaskCount);
            Assert.Equal(2, result.UnfinishedOrCanceledTaskCount);
        }

        /// <summary>
        /// 7th task from LINQ homework
        /// </summary>
        [Fact]
        public async ThreadTask GetProjectWithTeam_ExpectedResult()
        {
            var team = new Team
            {
                Name = "test team"
            };

            await _teamsRep.Create(team);
            await _teamsRep.unitOfWork.SaveChangesAsync();

            var user1 = new User
            {
                FirstName = "Svetlana",
                LastName = "Diode",
                Email = "sveta-diode@mail.ru",
                Birthday = DateTime.Parse("01/01/2013"),
                TeamId = team.Id,
            };

            var user2 = new User
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
                Birthday = DateTime.Parse("01/01/2005"),
                TeamId = team.Id
            };

            await _usersRep.Create(user1);
            await _usersRep.Create(user2);
            _usersRep.unitOfWork.SaveChanges();

            var project = new Project
            {
                ProjectName = "project name",
                Description = "project description (at least 15 characters...)",
                TeamId = team.Id,
                AuthorId = 1,
                CreatedAt = DateTime.Now
            };

            await _projectsRep.Create(project);
            await _projectsRep.unitOfWork.SaveChangesAsync();

            var shortestTask = new Task
            {
                Name = ".",
                Description = "description",
                TaskStateId = 3,
                PerformerId = 1,
                ProjectId = project.Id,
            };

            var longestTask = new Task
            {
                Name = "Longest task name",
                Description = "Longest task description",
                TaskStateId = 3,
                PerformerId = 1,
                ProjectId = project.Id,
            };

            await _tasksRep.Create(shortestTask);
            await _tasksRep.Create(longestTask);
            await _tasksRep.unitOfWork.SaveChangesAsync();

            var result = (await _collectionService.GetProjectWithTeam()).Single(r => r.Project.Id == project.Id);

            Assert.Equal(shortestTask.Id, result.ShortestTask.Id);
            Assert.Equal(longestTask.Id, result.LongestTask.Id);
            Assert.Equal(2, result.TeammatesCount);
        }
        private ICollectionService CreateCollectionServiceInstanse()
        {
            var collectionService = new CollectionService(_projectsRep,
                                                          _tasksRep,
                                                          _taskStateRep,
                                                          _teamsRep,
                                                          _usersRep,
                                                          new MapperConfiguration(cfg => 
                                                          {
                                                              cfg.CreateMap<ProjectDTO, Project>()
                                                                    .ForMember(p => p.ProjectName, options => options.MapFrom(dto => dto.Name));
                                                              cfg.CreateMap<Project, ProjectDTO>()
                                                                  .ForMember(dto => dto.Name, options => options.MapFrom(p => p.ProjectName));

                                                              cfg.CreateMap<Task, TaskDTO>();
                                                              cfg.CreateMap<TaskDTO, Task>();

                                                              cfg.CreateMap<Team, TeamDTO>();
                                                              cfg.CreateMap<TeamDTO, Team>();

                                                              cfg.CreateMap<UserDTO, User>();
                                                              cfg.CreateMap<User, UserDTO>();
                                                          }).CreateMapper());

            return collectionService;
        }
    }
}
