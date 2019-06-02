using Loca.Domain.Entities;
using Loca.Domain.Repositories;
using Loca.Infra.Context;
using System;
using System.Collections.Generic;

namespace Loca.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDB _db;

        public UserRepository(IDB db)
        {
            _db = db;
        }

        public void Create(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Edit(User user)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public User Login(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
