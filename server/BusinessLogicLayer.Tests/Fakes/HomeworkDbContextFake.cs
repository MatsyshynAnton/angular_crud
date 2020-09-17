using DataAccessLayer;
using DataAccessLayer.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace BusinessLogicLayer.Tests.Fakes
{
    public class HomeworkDbContextFake:HomeworkDbContext
    {
        readonly DbConnection _connection;
        public HomeworkDbContextFake():base(new DbContextOptionsBuilder<HomeworkDbContext>()
                .UseSqlite(CreateInMemoryDatabase())
                .Options)
        {
            
        }

        private static DbConnection CreateInMemoryDatabase()
        {
            var connection = new SqliteConnection("Filename=:memory:");

            connection.Open();
            
            return connection;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public override void Dispose()
        {
            _connection.Dispose();
            base.Dispose();
        }
    }
}
