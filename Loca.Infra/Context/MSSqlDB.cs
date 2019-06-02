using System;
using System.Data;
using System.Data.SqlClient;

namespace Loca.Infra.Context
{
    public class MSSqlDB : IDB
    {
        private readonly string _connectionString = "";
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
