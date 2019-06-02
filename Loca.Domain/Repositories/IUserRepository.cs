using Loca.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Loca.Domain.Repositories
{
    public interface IUserRepository
    {
        void Create(User user);
        void Edit(User user);
        User GetByID(Guid id);
        IList<User> GetAll();
        void Delete(Guid id);
        User Login(string email, string password);
    }
}
