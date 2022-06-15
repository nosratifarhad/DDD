using ByeBikari.ApplicationServices.ServiceInterface.IAuthenticationServices.IAuthenticationCommandServices;
using ByeBikari.CoreDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ByeBikari.ApplicationServices.Services.AuthenticationServices.AuthenticationCommandServices
{
    public class AuthenticationCommandService : IAuthenticationCommandService
    {
        private readonly IByeBikariUnitOfWork _byeBikariUnitOfWork;
        public AuthenticationCommandService(IByeBikariUnitOfWork byeBikariUnitOfWork)
        {
            this._byeBikariUnitOfWork = byeBikariUnitOfWork;
        }

        public void Execute()
        {
            //add

            _byeBikariUnitOfWork.commit();
        }
        public Task GegisterUser()
        {            
            throw new NotImplementedException();
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
