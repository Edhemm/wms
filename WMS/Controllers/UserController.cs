using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WMS.Application.Interfaces;
using WMS.Domain.Entities;
using WMS.Infrastructure.Shared.Services;

namespace WMS.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<User> GetAllUser()
        {
            return _userService.GetAllUsers().ToList();
        }

        [HttpGet("{id}")]
        public async Task<User> GetUser(Guid id)
        {
            return await _userService.GetUser(id);
        }
        
        [HttpPost]
        public async Task<IActionResult> AddUser(User newUser)
        {
           _userService.AddUser(newUser);
           return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> EditUser(User user)
        {
            _userService.EditUser(user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }
    }
}