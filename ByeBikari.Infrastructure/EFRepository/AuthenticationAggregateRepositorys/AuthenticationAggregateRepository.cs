using ByeBikari.CoreDomain.AuthenticationAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByeBikari.Infrastructure.EFRepository.AuthenticationAggregateRepositorys
{
    public class AuthenticationAggregateRepository : IAuthenticationAggregateRepository
    {
        private readonly ByeBikariContext _byeBikariContext;
        public AuthenticationAggregateRepository(ByeBikariContext byeBikariContext)
        {
            this._byeBikariContext = byeBikariContext;
        }

        public void Login(UserLogin userLogin)
        {
            var snapp = userLogin.GetSnapShot();


        }
    }
}
