using System;
using System.Collections.Generic;
using System.Text;

namespace ByeBikari.CoreDomain.EmployerAuthenticationAggregate
{
    public interface IEmployerAuthenticationAggregateRepository
    {
        void Login(EmployerLoginVO employerLoginVO);

        //void Register(UserLoginVO userLoginVO);

        //void ForgotPassword(UserForgotPasswordVO userForgotPasswordVO);
    }
}
