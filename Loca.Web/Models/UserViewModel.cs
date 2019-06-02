using Loca.Domain.Entities;
using Loca.Domain.Repositories;
using Loca.Domain.ValueObjects;
using Loca.Infra.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loca.Web.Models
{
    public class UserViewModel
    {
        private readonly IUserRepository _repository;

        //public async Task Create(FormCollection form)
        //{
        //    Name name = new Name(form["FirstName"], form["LastName"]);
        //    Email email = new Email(form["Email"]);
        //    var birthdate = DateTime.Parse(form["Birthdate"]);
        //    User user = new User(name, birthdate, email, form["Password"], form["Image"]);

        //    await _repository.Create(user);
        //}
    }
}
