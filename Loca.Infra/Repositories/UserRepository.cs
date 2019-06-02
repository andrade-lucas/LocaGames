using Loca.Domain.Entities;
using Loca.Domain.Repositories;
using Loca.Infra.Context;
using System;
using System.Collections.Generic;
using Dapper;
using System.Threading.Tasks;

namespace Loca.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDB _db;

        public UserRepository(IDB db)
        {
            _db = db;
        }

        public async Task Create(User user)
        {
            string sql = "insert into [User]([ID], [FirstName], [LastName], [Email], [Password], [Birthdate], [Image], [CreatedAt]) " +
                        "Values(@id, @firstName, @lastName, @email, @password, @birthdate, @image, @createdAt)";
            using (var con = _db.GetCon())
            {
                await con.ExecuteAsync(sql, new
                {
                    id = user.ID,
                    firstName = user.FirstName,
                    lastName = user.LastName,
                    email = user.Email,
                    password = user.Password,
                    birthdate = user.BirthDate,
                    image = user.Image,
                    createdAt = user.CreatedAt
                });
            }
        }

        public async Task Delete(Guid id)
        {
            string sql = "delete from [User] where ID = @id";

            using (var con = _db.GetCon())
            {
                await con.ExecuteAsync(sql, new
                {
                    id = id
                });
            }
        }

        public Task Edit(User user)
        {
            throw new NotImplementedException();
        }

        public Task<IList<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByID(Guid id)
        {
            Task<User> user;
            string sql = "select * from [User] where ID = @id";

            using (var con = _db.GetCon())
            {
                user = con.QueryFirstOrDefaultAsync<User>(sql, new
                {
                    id = id
                });
            }
            return user;
        }

        public Task<User> Login(string email, string password)
        {
            Task<User> user;
            string sql = "select * from [User] where [Email] = @email and [Password] = @password";

            using (var con = _db.GetCon())
            {
                user = con.QuerySingleOrDefaultAsync<User>(sql, new
                {
                    email = email,
                    password = password
                });
            }
            return user;
        }
    }
}
