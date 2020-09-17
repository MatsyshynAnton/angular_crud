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

using ThreadTask = System.Threading.Tasks.Task;

namespace BusinessLogicLayer.Tests
{
    public class TaskServiceTest
    {
        readonly ITaskService _taskService;
        readonly ITaskService _taskServiceFake;
        readonly IRepository<Task> _repository;

        public TaskServiceTest()
        {
            var context = new HomeworkDbContextFake();
            var unitOfWork = new UnitOfWork(context);

            _repository = A.Fake<IRepository<Task>>();
            _taskServiceFake = new TaskService(_repository,
                                           A.Fake<IRepository<TaskState>>(),
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

            _taskService = new TaskService(new RepositoryFake<Task>(context, unitOfWork),
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
        public async ThreadTask WhenTaskServiceUpdateTask_ThanRepositoryUpdateInvoked()
        {
            var task = await _taskServiceFake.GetTask(1);
            task.Description = "Updated task description.";

            await _taskServiceFake.UpdateTask(task);

            A.CallTo(() => _repository.Update(A<Task>._)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public async ThreadTask FinishTask_ThanTaskStatus3()
        {
            var task = new TaskDTO
            {
                Name = "1st task name",
                Description = "1st task description",
                PerformerId = 1,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 2,
                TaskStateId = 1,
            };

            await _taskService.CreateTask(task);
            await _taskService.FinishTask(task.Id);

            Assert.Equal(3, (await _taskService.GetTask(task.Id)).TaskStateId);
        }

        [Fact]
        public async ThreadTask UpdateTask_WhenUpdateTaskStatusId_ThanTaskStatusIdDoesNotMatch()
        {
            int taskStateId = 2;

            var task = new TaskDTO
            {
                Name = "1st task",
                Description = "1st task description",
                TaskStateId = taskStateId,
                PerformerId = 1,
                ProjectId = 1,
            };

            await _taskServiceFake.CreateTask(task);

            task.TaskStateId = 3;
            await _taskServiceFake.UpdateTask(task);

            var updatedTask = await _taskServiceFake.GetTask(task.Id);

            Assert.NotEqual(taskStateId, updatedTask.TaskStateId);
        }
    }
}
