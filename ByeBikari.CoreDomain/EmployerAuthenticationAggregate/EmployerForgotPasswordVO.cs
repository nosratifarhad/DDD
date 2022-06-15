using System;
using System.Collections.Generic;
using System.Text;

namespace ByeBikari.CoreDomain.EmployerAuthenticationAggregate
{
    public class EmployerForgotPasswordVO
    {
        private string _emailaddress;

        public EmployerForgotPasswordVO(string emailaddress)
        {
            this._emailaddress = emailaddress;
        }

        public void SetForgotPasswordVO(string emailaddress)
        {
            this._emailaddress = emailaddress;
        }

        public EmployerForgotPasswordVOSnapShot GetSnapShot()
        {
            return new EmployerForgotPasswordVOSnapShot
            {
                emailaddress = _emailaddress
            };
        }

    }
}
