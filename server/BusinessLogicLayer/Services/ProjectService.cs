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
    public class ProjectService : BaseService, IProjectService
    {
        private readonly IRepository<Project> _projectRepository;
        public ProjectService(IRepository<Project> projectRepository,
                              IMapper mapper) : base(mapper)
        {
            _projectRepository = projectRepository;
        }
        public async Task<int> CreateProject(ProjectDTO projectDto)
        {
            if (projectDto == null)
                throw new NullEntityException(typeof(ProjectDTO));

            var project = _mapper.Map<Project>(projectDto);

            await _projectRepository.Create(project);
            await _projectRepository.unitOfWork.SaveChangesAsync();

            projectDto.Id = project.Id;

            return projectDto.Id;
        }

        public async ThreadTask DeleteProject(int projectId)
        {
            if (await GetProject(projectId) == null)
                throw new NotFoundException(typeof(Project), projectId);

            await _projectRepository.Delete(projectId);
            await _projectRepository.unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProjectDTO>> GetAllProjects()
        {
            return await _projectRepository.Get().Select(p => _mapper.Map<ProjectDTO>(p)).ToArrayAsync();
        }

        public async Task<ProjectDTO> GetProject(int projectId)
        {
            Project entity = await _projectRepository.Get(projectId);

            if (entity == null)
                throw new NotFoundException(typeof(Project), projectId);

            var dto = _mapper.Map<ProjectDTO>(entity);
            return dto;
        }

        public async ThreadTask UpdateProject(ProjectDTO projectDto)
        {
            if (projectDto == null)
                throw new NullEntityException(typeof(ProjectDTO));

            if (await GetProject(projectDto.Id) == null)
                throw new NotFoundException(typeof(Project), projectDto.Id);

            var projectEntity = await _projectRepository.Get(projectDto.Id);
            projectEntity = _mapper.Map(projectDto, projectEntity);

            _projectRepository.Update(projectEntity);
            await _projectRepository.unitOfWork.SaveChangesAsync();
        }
    }
}
