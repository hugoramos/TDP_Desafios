using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Desafio_Trimania_Re00.Models;

namespace Desafio_Trimania_Re00.Data
{

    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite(new SqliteConnection("Filename=ApplicationContext.db"));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Adress> Adresses { get; set; }


    }


}
