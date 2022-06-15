using System;
using System.Security.Cryptography;
using System.Text;

namespace ByeBikari.CoreDomain.JobSeekerAuthenticationAggregate
{
    public class JobSeekerLoginVO
    {
        private string _username;
        private string _password;

        public JobSeekerLoginVO(string username, string pasword)
        {
            this._username = username;
            this._password = pasword;
        }

        public JobSeekerLoginVO SetJobSeekerLogin(string username, string pasword)
        {
            this._username = username;
            this._password = pasword;
            return new JobSeekerLoginVO(this._username, this._password);
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
        public JobSeekerLoginVOSnapShot GetSnapShot()
        {
            return new JobSeekerLoginVOSnapShot
            {
                username = _username,
                password = _password
            };
        }

    }
}
