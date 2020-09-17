using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Tests.Fakes;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Threading.Tasks;

using ThreadTask = System.Threading.Tasks.Task;
using ApplicationTask = DataAccessLayer.Models.Task;

namespace BusinessLogicLayer.Tests
{
    public class TeamServiceTest
    {
        readonly IRepository<Team> _teamRep;
        readonly IRepository<User> _userRep;

        public TeamServiceTest()
        {
            var context = new HomeworkDbContextFake();
            var unitOfWork = new UnitOfWork(context);

            _teamRep = new RepositoryFake<Team>(context, unitOfWork);
            _userRep = new RepositoryFake<User>(context, unitOfWork);
        }

        [Fact]
        public async ThreadTask AddUserToTeam_CheckIfSuccessfull()
        {
            var team = new Team
            {
                Name = "Test team name"
            };

            await _teamRep.Create(team);
            await _teamRep.unitOfWork.SaveChangesAsync();

            var user = new User
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
            };

            await _userRep.Create(user);
            await _userRep.unitOfWork.SaveChangesAsync();

            user.TeamId = team.Id;

            _userRep.Update(user);
            await _userRep.unitOfWork.SaveChangesAsync();

            var result = await _userRep.Get(user.Id);
            Assert.Equal(team.Id, result.TeamId);
        }
    }
}
