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
    public class TaskService : BaseService, ITaskService
    {
        private readonly IRepository<ApplicationTask> _taskRepository;
        private readonly IRepository<TaskState> _taskStateRepository;
        public TaskService(IRepository<ApplicationTask> taskRepository,
                           IRepository<TaskState> taskStateRepository,
                           IMapper mapper) : base(mapper)
        {
            _taskRepository = taskRepository;
            _taskStateRepository = taskStateRepository;
        }

        public async Task<int> CreateTask(TaskDTO taskDto)
        {
            if (taskDto == null)
                throw new NullEntityException(typeof(TaskDTO));

            var task = _mapper.Map<ApplicationTask>(taskDto);

            await _taskRepository.Create(task);
            await _taskRepository.unitOfWork.SaveChangesAsync();

            taskDto.Id = task.Id;

            return taskDto.Id;
        }

        public async ThreadTask DeleteTask(int taskId)
        {
            if (await GetTask(taskId) == null)
                throw new NotFoundException(typeof(ApplicationTask), taskId);

            await _taskRepository.Delete(taskId);

            _taskRepository.unitOfWork.SaveChanges();
        }

        public async ThreadTask FinishTask(int taskId)
        {
            var task = await GetTask(taskId);

            var finishedTaskState = _taskStateRepository.Get().FirstOrDefault(t => t.State == "Finished");

            task.TaskStateId = finishedTaskState.Id;

            await UpdateTask(_mapper.Map<TaskDTO>(task));
        }

        public async Task<IEnumerable<TaskDTO>> GetAllTask()
        {
            return await _taskRepository.Get().Select(t => _mapper.Map<TaskDTO>(t)).ToArrayAsync();
        }

        public async Task<TaskDTO> GetTask(int taskId)
        {
            ApplicationTask entity = await _taskRepository.Get(taskId);

            if (entity == null)
                throw new NotFoundException(typeof(ApplicationTask), taskId);

            var dto = _mapper.Map<TaskDTO>(entity);
            return dto;
        }

        public async ThreadTask UpdateTask(TaskDTO task)
        {
            if (task == null)
                throw new NullEntityException(typeof(TaskDTO));

            if (await GetTask(task.Id) == null)
                throw new NotFoundException(typeof(ApplicationTask), task.Id);

            var taskEntity = await _taskRepository.Get(task.Id);
            taskEntity = _mapper.Map(task, taskEntity);

            _taskRepository.Update(taskEntity);
            await _taskRepository.unitOfWork.SaveChangesAsync();
        }
    }
}
