using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoDataAccess.Interfaces;
using ToDoDataAccess.Models;

namespace ToDoAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("{email}/{password}")]

        public ActionResult GetUser(string email, string password)
        {
            var user = _userRepository.GetUser(email, password);
            return Ok(user);
        }

        [HttpPost]
        public ActionResult Add(User user)
        {
            _userRepository.AddUser(user);
            return Ok("created");
        }
    }
}