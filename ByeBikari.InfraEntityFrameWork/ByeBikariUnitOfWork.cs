using System;
using System.Collections.Generic;
using System.Text;

namespace ByeBikari.InfraEntityFrameWork
{
    public class ByeBikariUnitOfWork //: IByeBikariUnitOfWork
    {
        private readonly ByeBikariReadContext _byeBikariReadContext;

        //public IJobSeekerAuthenticationAggregateRepository _jobSeekerAuthenticationAggregateRepository { get; }

        public ByeBikariUnitOfWork(ByeBikariReadContext byeBikariReadContext)
        {
            this._byeBikariReadContext = byeBikariReadContext;
            //JobSeekerAuthenticationAggregateRepository authenticationAggregateRepository = new JobSeekerAuthenticationAggregateRepository(_byeBikariContext);
        }

        //public IJobSeekerAuthenticationAggregateRepository IJobSeekerAuthenticationAggregateRepository { get; private set; }

        public void commit()
        {
            _byeBikariReadContext.SaveChanges();
        }
        #region IDisposable Support

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        #endregion

    }

}
