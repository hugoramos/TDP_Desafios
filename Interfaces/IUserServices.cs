using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Desafio_Trimania_Re00.Data;
using Desafio_Trimania_Re00.Models;
using System.Collections.Generic;

namespace Desafio_Trimania_Re00.Interfaces
{

    public interface IUserServices
    {

        List<User> GetUsers();

        User GetUser(int id);

        User CreateUser(User user);

        User UpdateUser(User user);

        User DeleteUser(int id);
    }

}