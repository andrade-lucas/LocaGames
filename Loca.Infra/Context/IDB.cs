using System;
using System.Data;

namespace Loca.Infra.Context
{
    public interface IDB : IDisposable
    {
        IDbConnection GetCon();
    }
}
