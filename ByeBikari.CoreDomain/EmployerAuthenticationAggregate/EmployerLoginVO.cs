using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ByeBikari.CoreDomain.EmployerAuthenticationAggregate
{
    public class EmployerLoginVO
    {
        private string _username;
        private string _password;

        public EmployerLoginVO(string username, string pasword)
        {
            this._username = username;
            this._password = pasword;
        }

        public EmployerLoginVO SetUserLogin(string username, string pasword)
        {
            this._username = username;
            this._password = pasword;
            return new EmployerLoginVO(this._username, this._password);
        }

        public bool IsEqualUsername(string username)
        {
            return this._username == username;
        }

        public bool IsEqualPassword(string password)
        {
            string hashcode = string.Empty;
            using (var sha1 = new SHA1Managed())
            {
                hashcode = BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(password)));
            }
            return this._password == hashcode;
        }
        //internal
        public EmployerLoginVOSnapShot GetSnapShot()
        {
            return new EmployerLoginVOSnapShot
            {
                username = _username,
                password = _password
            };
        }

    }
}
