using System;
using System.Collections.Generic;
using System.Data;
namespace ByeBikari.Framework.UnitOfWorkInterface
{
    public interface IUnitOfWork: IDisposable
    {
        //Guid Id { get; }
        //IDbConnection Connection { get; }
        //IDbTransaction Transaction { get; }
        //void Begin();
        void commit();
        //void Rollback();
    }
}
