using AutoMapper;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Services;
using BusinessLogicLayer.Tests.Fakes;
using Common.DTO;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.UnitOfWork;
using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

using ThreadTask = System.Threading.Tasks.Task;

namespace BusinessLogicLayer.Tests
{
    public class UserServiceTest
    {
        readonly IUserService _userServiceFake;
        readonly IUserService _userService;
        readonly IRepository<Task> _taskRepository;
        readonly IRepository<User> _userRepository;

        public UserServiceTest()
        {
            var context = new HomeworkDbContextFake();
            var unitOfWork = new UnitOfWork(context);

            _userRepository = A.Fake<IRepository<User>>();
            _taskRepository = new RepositoryFake<Task>(context, unitOfWork);
            _userServiceFake = new UserService(_userRepository,
                                           new RepositoryFake<TaskState>(context, unitOfWork),
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

            _userService = new UserService(new RepositoryFake<User>(context, unitOfWork),
                                           new RepositoryFake<TaskState>(context, unitOfWork),
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
        }

        [Fact]
        public void WhenCreateUserInvoked_ThanRepositoryAddInvoked()
        {
            var user = new UserDTO
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
            };

            _userServiceFake.CreateUser(user);
            A.CallTo(() => _userRepository.Create(A<User>._)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public async ThreadTask CreateUser_CheckReturnIdAndEntityId()
        {
            var user = new UserDTO
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
            };

            var id = await _userService.CreateUser(user);

            Assert.Equal(id, user.Id);
        }

        [Fact]
        public async ThreadTask GetUserUnfinishedTasks_WhenAddUserAndTwoTasks_ThanResultTasksLength2()
        {
            var user = new UserDTO
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
            };

            await _userService.CreateUser(user);

            var task1 = new Task
            {
                Name = "1st task name",
                Description = "1st task description",
                PerformerId = user.Id,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 1,
                TaskStateId = 1,
            };

            var task2 = new Task
            {
                Name = "2nd task name",
                Description = "2nd task description",
                PerformerId = user.Id,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 2,
                TaskStateId = 2,
            };

            await _taskRepository.Create(task1);
            await _taskRepository.Create(task2);
            await _taskRepository.unitOfWork.SaveChangesAsync();

            var result = await _userService.GetUserUnfinishedTasks(user.Id);
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async ThreadTask GetUserUnfinishedTasks_WhenAddUserAndFinishedTasks_ThanResultTasksLength0()
        {
            var user = new UserDTO
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
            };

            await _userService.CreateUser(user);

            var task1 = new Task
            {
                Name = "1st task name",
                Description = "1st task description",
                PerformerId = user.Id,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 1,
                TaskStateId = 3,
            };

            var task2 = new Task
            {
                Name = "2nd task name",
                Description = "2nd task description",
                PerformerId = user.Id,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 2,
                TaskStateId = 3,
            };

            await _taskRepository.Create(task1);
            await _taskRepository.Create(task2);
            await _taskRepository.unitOfWork.SaveChangesAsync();

            Assert.Empty(await _userService.GetUserUnfinishedTasks(user.Id));
        }
    }
}
