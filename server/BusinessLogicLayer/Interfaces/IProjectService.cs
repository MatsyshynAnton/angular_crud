using Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectDTO>> GetAllProjects();
        Task<ProjectDTO> GetProject(int projectId);

        Task<int> CreateProject(ProjectDTO project);
        Task UpdateProject(ProjectDTO project);
        Task DeleteProject(int projectId);
    }
}
