using Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace BusinessLogicLayer.Interfaces
{
    public interface ICollectionService
    {
        Task<Dictionary<int, int>> GetProjectsIdAndTaskCount(int projectOwnerId);
        Task<IEnumerable<TaskDTO>> GetUsersTask(int userId);
        Task<IEnumerable<TaskIdNameDTO>> GetFinishedUserTasks(int userId);
        Task<IEnumerable<TeamWithUsersDTO>> GetTeamsWithUsers();
        Task<IEnumerable<UserWithTasks>> GetUsersWithTasks();
        Task<LastProjectAndTaskInfoDTO> GetLastUserProject(int userId);
        Task<IEnumerable<ProjectAndTeamInfoDTO>> GetProjectWithTeam();
    }
}
