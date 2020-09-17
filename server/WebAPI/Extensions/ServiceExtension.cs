using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ProjectStructureHW.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Project>, Repository<Project>>();
            services.AddScoped<IRepository<Task>, Repository<Task>>();
            services.AddScoped<IRepository<TaskState>, Repository<TaskState>>();
            services.AddScoped<IRepository<Team>, Repository<Team>>();
            services.AddScoped<IRepository<User>, Repository<User>>();

            return services;
        }

        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<ITaskService, TaskService>();
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITaskStateService, TaskStateService>();
            services.AddTransient<ICollectionService, CollectionService>();

            return services;
        }
    }
}
