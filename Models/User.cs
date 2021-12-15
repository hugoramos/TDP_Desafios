using System;
namespace Desafio_Trimania_Re00.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreationDate { get; set; }
        public Adress Adress { get; set; }

        public User(int userId, string name, string login, string password, string cpf, string email,
         DateTime birthday, Adress adress)
        {
            this.Name = name;
            this.UserId = userId;
            this.Login = login;
            this.Password = password;
            this.Cpf = cpf;
            this.Email = email;
            this.Birthday = birthday;
            this.Adress = adress;
            CreationDate = DateTime.Now;

        }

    }

}