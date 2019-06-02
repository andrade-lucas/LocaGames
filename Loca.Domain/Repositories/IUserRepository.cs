using Loca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Loca.Domain.Repositories
{
    public interface IUserRepository
    {
        Task Create(User user);
        Task Edit(User user);
        Task<User> GetByID(Guid id);
        Task<IList<User>> GetAll();
        Task Delete(Guid id);
        Task<User> Login(string email, string password);
    }
}
