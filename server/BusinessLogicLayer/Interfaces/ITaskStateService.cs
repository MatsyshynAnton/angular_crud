using Common.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface ITaskStateService
    {
        Task<IEnumerable<TaskStateDTO>> GetTaskStates();
    }
}
