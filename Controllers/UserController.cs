using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Trimania_Re00.Data;
using Desafio_Trimania_Re00.Models;
using Desafio_Trimania_Re00.Services;
using Desafio_Trimania_Re00.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Desafio_Trimania_Re00.Controllers
{
    public class UserController : ControllerBase
    {
        public readonly IUserServices _userServices;

        public UserController(IUserServices services)
        {
            _userServices = services;
        }

        [Route("users")]

        [HttpGet]
        public List<User> GetUsers()
        {
            return _userServices.GetUsers();
        }

        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            return _userServices.GetUser(id);
        }

        [HttpPost]
        public User CreateUser([FromBody] User user)
        {
            _userServices.CreateUser(user);
            return user;
        }

        [HttpPut]
        public User UpdateUser([FromBody] User user)
        {
            _userServices.UpdateUser(user);
            return user;
        }


        [HttpDelete("{id}")]
        public int DeleteUser(int id)
        {

            _userServices.DeleteUser(id);
            return id;

        }


    }

}