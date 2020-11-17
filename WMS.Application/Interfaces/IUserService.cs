
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WMS.Application.Interfaces.GenericRepository;
using WMS.Domain.Entities;

namespace WMS.Application.Interfaces
{
    public interface IUserService
    {
        public Task AddUser(User newUser);
        public IList<User> GetAllUsers();
        public Task<User> GetUser(Guid id);
        public Task EditUser(User user);
        public Task DeleteUser(Guid id);
    }
}