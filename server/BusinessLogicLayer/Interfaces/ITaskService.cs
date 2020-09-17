using Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskDTO>> GetAllTask();
        Task<TaskDTO> GetTask(int taskId);

        Task<int> CreateTask(TaskDTO task);
        Task UpdateTask(TaskDTO task);
        Task DeleteTask(int taskId);

        Task FinishTask(int taskId);
    }
}
