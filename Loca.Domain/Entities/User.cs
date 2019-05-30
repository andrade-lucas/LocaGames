using Loca.Domain.ValueObjects;
using Loca.Shared.Entities;
using System;

namespace Loca.Domain.Entities
{
    public class User : Entity
    {
        public Name Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
        public string Image { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public User(Name name, DateTime birthDate, Email email, string password, string image)
        {
            Name = name;
            BirthDate = birthDate;
            Email = email;
            Password = password;
            Image = image;
            CreatedAt = DateTime.Now;
        }
    }
}
