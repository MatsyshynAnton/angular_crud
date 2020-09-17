using AutoMapper;
using BusinessLogicLayer.Exceptions;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Services.Abstractions;
using Common.DTO;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

using ApplicationTask = DataAccessLayer.Models.Task;
using ThreadTask = System.Threading.Tasks.Task;

namespace BusinessLogicLayer.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<TaskState> _taskStateRepository;

        public UserService(IRepository<User> userRepository,
                           IRepository<TaskState> taskStateRepository,
                           IMapper mapper) : base(mapper)
        {
            _userRepository = userRepository;
            _taskStateRepository = taskStateRepository;
        }
        public async Task<int> CreateUser(UserDTO userDto)
        {
            if (userDto == null)
                throw new NullEntityException(typeof(UserDTO));

            var user = _mapper.Map<User>(userDto);

            await _userRepository.Create(user);
            await _userRepository.unitOfWork.SaveChangesAsync();

            userDto.Id = user.Id;

            return userDto.Id;
        }

        public async ThreadTask DeleteUser(int userId)
        {
            if (await GetUser(userId) == null)
                throw new NotFoundException(typeof(User), userId);

            await _userRepository.Delete(userId);
            await _userRepository.unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsers()
        {
            return await _userRepository.Get().Select(u => _mapper.Map<UserDTO>(u)).ToArrayAsync();
        }

        public async Task<UserDTO> GetUser(int userId)
        {
            User entity = await _userRepository.Get(userId);

            if (entity == null)
                throw new NotFoundException(typeof(User), userId);

            var dto = _mapper.Map<UserDTO>(entity);
            return dto;
        }

        public async Task<IEnumerable<TaskDTO>> GetUserUnfinishedTasks(int userId)
        {
            if (await GetUser(userId) == null)
                throw new NotFoundException(typeof(User), userId);

            var finishedTaskStatus = await _taskStateRepository.Get().FirstOrDefaultAsync(t => t.State == "Finished");

            var tasks = await _userRepository.Get().Where(u => u.Id == userId)
                                             .Include(u => u.Tasks)
                                             .SelectMany(u => u.Tasks)
                                             .Where(t => t.TaskStateId != finishedTaskStatus.Id)
                                             .Select(t => _mapper.Map<TaskDTO>(t))
                                             .ToArrayAsync();

            return tasks;
        }

        public async ThreadTask UpdateUser(UserDTO userDto)
        {
            if (userDto == null)
                throw new NullEntityException(typeof(UserDTO));

            if (GetUser(userDto.Id) == null)
                throw new NotFoundException(typeof(User), userDto.Id);

            var userEntity = await _userRepository.Get(userDto.Id);
            userEntity = _mapper.Map(userDto, userEntity);

            _userRepository.Update(userEntity);
            _userRepository.unitOfWork.SaveChanges();
        }
    }
}
