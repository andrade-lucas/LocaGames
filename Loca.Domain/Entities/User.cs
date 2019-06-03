using Loca.Domain.ValueObjects;
using Loca.Shared.Entities;
using System;

namespace Loca.Domain.Entities
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public Name Name { get; private set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        //public Email Email { get; private set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }

        public User()
        {
            FirstName = String.Empty;
            LastName = String.Empty;
            BirthDate = DateTime.Now;
            Email = String.Empty;
            Password = String.Empty;
            Image = String.Empty;
            CreatedAt = DateTime.Now;
        }

        public User(string firstName, string lastName, string birthDate, string email, string password, string image)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = DateTime.Parse(birthDate);
            Email = email;
            Password = password;
            Image = image;
            CreatedAt = DateTime.Now;
        }

        //public User(Name name, DateTime birthDate, Email email, string password, string image)
        //{
        //    Name = name;
        //    BirthDate = birthDate;
        //    Email = email;
        //    Password = password;
        //    Image = image;
        //    CreatedAt = DateTime.Now;
        //}
    }
}
