using Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface ITeamService
    {
        Task<IEnumerable<TeamDTO>> GetAllTeams();
        Task<TeamDTO> GetTeam(int teamId);

        Task<int> CreateTeam(TeamDTO team);
        Task UpdateTeam(TeamDTO team);
        Task DeleteTeam(int teamId);
    }
}
