﻿using Loca.Shared.Commands;
using System;

namespace Loca.Domain.Commands.Inputs
{
    public class UserCreateCommand : ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
