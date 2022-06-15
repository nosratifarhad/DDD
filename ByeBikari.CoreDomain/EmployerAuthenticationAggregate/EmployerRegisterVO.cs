using System;
using System.Collections.Generic;
using System.Text;

namespace ByeBikari.CoreDomain.EmployerAuthenticationAggregate
{
    public class EmployerRegisterVO
    {
        private string _username;
        private string _emailaddress;
        private string _password;

        public EmployerRegisterVO(string username, string emailaddress, string phonenumber, string password)
        {
            this._username = username;
            this._emailaddress = emailaddress;
            this._password = password;
        }

        public void SetUserRegister(string username, string emailaddress, string phonenumber, string password)
        {
            this._username = username;
            this._emailaddress = emailaddress;
            this._password = password;

        }

        public bool IsEqual(string username)
        {
            return _username == username;
        }
        public EmployerRegisterVOSnapShot GetSnapShot()
        {
            return new EmployerRegisterVOSnapShot
            {
                username = _username,
                password = _password,
                emailaddress = _emailaddress

            };
        }

    }
}
