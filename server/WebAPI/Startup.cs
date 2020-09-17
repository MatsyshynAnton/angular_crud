using AutoMapper;
using BusinessLogicLayer.Profiles;
using DataAccessLayer;
using DataAccessLayer.UnitOfWork;
using DataAccessLayer.UnitOfWork.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectStructureHW.Extensions;

namespace ProjectStructureHW
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HomeworkDbContext>(options =>
                options.UseSqlServer(Configuration["ConnectionStrings:DatabaseConnection"]));

            services.AddAutoMapper(typeof(MapperConfig));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddRepositories();
            services.AddCustomServices();

            services.AddCors();

            services.AddControllers();

            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, HomeworkDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.ConfigureCustomExceptionHandler();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "HW3");
            });

            //app.UseHttpsRedirection();
          
            app.UseCors(bulder => 
                      bulder.AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials()
                            .WithOrigins("http://localhost:4200"));

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            context.Database.Migrate();
        }
    }
}
