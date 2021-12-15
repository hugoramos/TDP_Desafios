using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Desafio_Trimania_Re00.Data;

namespace Desafio_Trimania_Re00.Services
{

    public class UserServices : DbContext
    {
        private readonly ApplicationContext _applicationContext;

        public UserServices(ApplicationContext context)
        {
            _applicationContext = context;
            _applicationContext.Database.EnsureCreated();
        }


            

    }

}