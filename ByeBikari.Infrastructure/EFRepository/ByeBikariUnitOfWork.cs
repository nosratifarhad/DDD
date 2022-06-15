using ByeBikari.CoreDomain;
using ByeBikari.CoreDomain.AuthenticationAggregate;
using ByeBikari.Infrastructure.EFRepository.AuthenticationAggregateRepositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByeBikari.Infrastructure.EFRepository
{
    public class ByeBikariUnitOfWork: IByeBikariUnitOfWork
    {
        private readonly ByeBikariContext _byeBikariContext;
        public ByeBikariUnitOfWork(ByeBikariContext byeBikariContext)
        {
            this._byeBikariContext = byeBikariContext;
            AuthenticationAggregateRepository =
                new AuthenticationAggregateRepository(_byeBikariContext);
        }

        public IAuthenticationAggregateRepository _authenticationAggregateRepository => throw new NotImplementedException();

        IAuthenticationAggregateRepository AuthenticationAggregateRepository { get; private set; }

        public void commit()
        {
            _byeBikariContext.
        }
    }
}
