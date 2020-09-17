using AutoMapper;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Services.Abstractions;
using Common.DTO;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer.Services
{
    public class TaskStateService : BaseService, ITaskStateService
    {
        private readonly IRepository<TaskState> _repository;
        public TaskStateService(IMapper mapper, IRepository<TaskState> repository) : base(mapper) 
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TaskStateDTO>> GetTaskStates()
        {
            return await _repository.Get().Select(ts => new TaskStateDTO { Id = ts.Id, Value = ts.State }).ToArrayAsync();
        }
    }
}
