using Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAllUsers();
        Task<UserDTO> GetUser(int userId);

        Task<int> CreateUser(UserDTO user);
        Task UpdateUser(UserDTO user);
        Task DeleteUser(int userId);

        Task<IEnumerable<TaskDTO>> GetUserUnfinishedTasks(int userId);
    }
}
