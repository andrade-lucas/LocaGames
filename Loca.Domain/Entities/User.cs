using Loca.Domain.ValueObjects;
using Loca.Shared.Entities;
using System;

namespace Loca.Domain.Entities
{
    public class User : Entity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        //public Name Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }
        //public Email Email { get; private set; }
        public string Password { get; private set; }
        public string Image { get; private set; }
        public DateTime CreatedAt { get; private set; }
        
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
