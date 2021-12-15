using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Desafio_Trimania_Re00.Data;
using Desafio_Trimania_Re00.Models;
using System.Collections.Generic;
using Desafio_Trimania_Re00.Interfaces;

namespace Desafio_Trimania_Re00.Services
{

    public class UserServices : IUserServices
    {
        private readonly ApplicationContext _applicationContext;

        public UserServices(ApplicationContext context)
        {
            _applicationContext = context;
            _applicationContext.Database.EnsureCreated();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public User CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public User DeleteUser(int id)
        {
            throw new NotImplementedException();
        }
    }

}