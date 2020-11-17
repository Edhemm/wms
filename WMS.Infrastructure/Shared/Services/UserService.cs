using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Application.Interfaces;
using WMS.Application.Interfaces.GenericRepository;
using WMS.Domain.Entities;

namespace WMS.Infrastructure.Shared.Services

{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _userRepository;

        public UserService(IGenericRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task AddUser(User newUser)
        {
            if (newUser != null)
            {
                await _userRepository.AddAsync(newUser);
            }
        }

        public IList<User> GetAllUsers()
        {
            return _userRepository.GetAllAsync().Result.ToList();
        }

        public Task<User> GetUser(Guid id)
        {
            return _userRepository.GetByGuidAsync(id);
        }

        public async Task EditUser(User user)
        {
            if (user != null)
            {
                await _userRepository.UpdateAsync(user);
            }
        }

        public async Task DeleteUser(Guid id)
        {
            var userToDelete = _userRepository.GetByGuidAsync(id).Result;
            await _userRepository.DeleteAsync(userToDelete);
            
        }
    }
}