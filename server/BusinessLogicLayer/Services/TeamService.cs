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
    public class TeamService : BaseService, ITeamService
    {
        private readonly IRepository<Team> _repository;

        public TeamService(IRepository<Team> repository,
                           IMapper mapper) : base(mapper)
        {
            _repository = repository;
        }

        public async Task<int> CreateTeam(TeamDTO teamDto)
        {
            if (teamDto == null)
                throw new NullEntityException(typeof(TeamDTO));

            var team = _mapper.Map<Team>(teamDto);

            await _repository.Create(team);
            await _repository.unitOfWork.SaveChangesAsync();

            teamDto.Id = team.Id;

            return teamDto.Id;
        }

        public async ThreadTask DeleteTeam(int teamId)
        {
            if (await GetTeam(teamId) == null)
                throw new NotFoundException(typeof(Team), teamId);

            await _repository.Delete(teamId);
            await _repository.unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<TeamDTO>> GetAllTeams()
        {
            return await _repository.Get().Select(t => _mapper.Map<TeamDTO>(t)).ToArrayAsync();
        }

        public async Task<TeamDTO> GetTeam(int teamId)
        {
            Team entity = await _repository.Get(teamId);

            if (entity == null)
                throw new NotFoundException(typeof(Team), teamId);

            var dto = _mapper.Map<TeamDTO>(entity);
            return dto;
        }

        public async ThreadTask UpdateTeam(TeamDTO team)
        {
            if (team == null)
                throw new NullEntityException(typeof(TeamDTO));

            if (await GetTeam(team.Id) == null)
                throw new NotFoundException(typeof(Team), team.Id);

            var teamEntity = await _repository.Get(team.Id);
            teamEntity = _mapper.Map(team, teamEntity);

            _repository.Update(teamEntity);
            await _repository.unitOfWork.SaveChangesAsync();
        }
    }
}
