using DataAccess.Models;
using System;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        GasStationDBContext GetDBContext();
    }
}