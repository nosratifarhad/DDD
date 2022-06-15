namespace ByeBikari.CoreDomain.JobSeekerAuthenticationAggregate
{
    public class JobSeekerForgotPasswordVO
    {
        private string _emailaddress;

        public JobSeekerForgotPasswordVO(string emailaddress)
        {
            this._emailaddress = emailaddress;
        }

        public void SetForgotPasswordVO(string emailaddress)
        {
            this._emailaddress = emailaddress;
        }

        public JobSeekerForgotPasswordVOSnapShot GetSnapShot()
        {
            return new JobSeekerForgotPasswordVOSnapShot
            {
                emailaddress=_emailaddress
            };
        }
    }
}
