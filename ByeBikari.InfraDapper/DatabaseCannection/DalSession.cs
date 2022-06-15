//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Text;

//namespace ByeBikari.InfraDapper.DatabaseCannection
//{
//    public class MyPoco
//    {
//        public int MyProperty { get; set; }
//    }
//    public sealed class MyRepository
//    {
//        public MyRepository(IUnitOfWork unitOfWork)
//        {
//            this.unitOfWork = unitOfWork;
//        }

//        IUnitOfWork unitOfWork = null;

//        //You also need to handle other parameters like 'sql', 'param' ect. This is out of scope of this answer.
//        public MyPoco Get()
//        {
//            return unitOfWork.Connection.Query(sql, param, unitOfWork.Transaction, .......);
//        }

//        public void Insert(MyPoco poco)
//        {
//            return unitOfWork.Connection.Execute(sql, param, unitOfWork.Transaction, .........);
//        }
//    }
//    public sealed class DalSession : IDisposable
//    {
//        public DalSession()
//        {
//            _connection = new OleDbConnection(DalCommon.ConnectionString);
//            _connection.Open();
//            _unitOfWork = new UnitOfWork(_connection);
//        }

//        IDbConnection _connection = null;
//        UnitOfWork _unitOfWork = null;

//        public UnitOfWork UnitOfWork
//        {
//            get { return _unitOfWork; }
//        }

//        public void Dispose()
//        {
//            _unitOfWork.Dispose();
//            _connection.Dispose();
//        }
//    }

//    public sealed class UnitOfWork : IUnitOfWork
//    {
//        internal UnitOfWork(IDbConnection connection)
//        {
//            _id = Guid.NewGuid();
//            _connection = connection;
//        }

//        IDbConnection _connection = null;
//        IDbTransaction _transaction = null;
//        Guid _id = Guid.Empty;

//        IDbConnection IUnitOfWork.Connection
//        {
//            get { return _connection; }
//        }
//        IDbTransaction IUnitOfWork.Transaction
//        {
//            get { return _transaction; }
//        }
//        Guid IUnitOfWork.Id
//        {
//            get { return _id; }
//        }

//        public void Begin()
//        {
//            _transaction = _connection.BeginTransaction();
//        }

//        public void Commit()
//        {
//            _transaction.Commit();
//            Dispose();
//        }

//        public void Rollback()
//        {
//            _transaction.Rollback();
//            Dispose();
//        }

//        public void Dispose()
//        {
//            if (_transaction != null)
//                _transaction.Dispose();
//            _transaction = null;
//        }
//    }

//    interface IUnitOfWork : IDisposable
//    {
//        Guid Id { get; }
//        IDbConnection Connection { get; }
//        IDbTransaction Transaction { get; }
//        void Begin();
//        void Commit();
//        void Rollback();
//    }
//}
