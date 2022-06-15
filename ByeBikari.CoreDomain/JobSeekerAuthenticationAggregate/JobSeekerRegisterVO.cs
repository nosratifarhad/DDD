namespace ByeBikari.CoreDomain.JobSeekerAuthenticationAggregate
{
    public class JobSeekerRegisterVO
    {
        private string _username;
        private string _emailaddress;
        private string _password;

        public JobSeekerRegisterVO(string username, string emailaddress, string phonenumber, string password)
        {
            this._username = username;
            this._emailaddress = emailaddress;
            this._password = password;
        }

        public void SetJobSeekerRegister(string username, string emailaddress, string phonenumber, string password)
        {
            this._username = username;
            this._emailaddress = emailaddress;
            this._password = password;
            
        }
        
        public bool IsEqual(string username)
        {
            return _username == username;
        }
        public JobSeekerRegisterVOSnapShot GetSnapShot()
        {
            return new JobSeekerRegisterVOSnapShot
            {
                username = _username,
                password = _password,
                emailaddress = _emailaddress
            };
        }
    }
}
