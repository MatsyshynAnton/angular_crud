using DataAccessLayer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectStructureHW;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;

namespace WebAPI.IntegrationTests
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Startup>
    {
        DbConnection connection;
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<HomeworkDbContext>));

                if (descriptor != null)
                {
                    services.Remove(descriptor);
                }

                connection = new SqliteConnection("Filename=:memory:");
                connection.Open();

                services.AddDbContext<HomeworkDbContext>(options =>
                {
                    options.UseSqlite(connection);
                });

                var sp = services.BuildServiceProvider();

                using (var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var db = scopedServices.GetRequiredService<HomeworkDbContext>();

                    var a = db.Database.EnsureCreated();
                }
            });
        }
    }
}