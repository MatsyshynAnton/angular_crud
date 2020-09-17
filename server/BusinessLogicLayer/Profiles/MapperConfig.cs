using AutoMapper;
using Common.DTO;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Profiles
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<ProjectDTO, Project>()
                .ForMember(p => p.ProjectName, options => options.MapFrom(dto => dto.Name));
            CreateMap<Project, ProjectDTO>()
                .ForMember(dto => dto.Name, options => options.MapFrom(p => p.ProjectName));

            CreateMap<Task, TaskDTO>();
            CreateMap<TaskDTO, Task>();

            CreateMap<Team, TeamDTO>();
            CreateMap<TeamDTO, Team>();

            CreateMap<UserDTO, User>();
            CreateMap<User,UserDTO>();
        }
    }
}
