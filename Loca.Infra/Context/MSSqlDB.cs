using System;
using System.Data;
using System.Data.SqlClient;

namespace Loca.Infra.Context
{
    public class MSSqlDB : IDB
    {
        private readonly string _connectionString = @"Server=DESKTOP-H7HI9UU;Database=LocaGames;User Id=sa;Password=123;";
        private IDbConnection _db;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IDbConnection GetCon()
        {
            _db = new SqlConnection(_connectionString);
            return _db;
        }
    }
}
