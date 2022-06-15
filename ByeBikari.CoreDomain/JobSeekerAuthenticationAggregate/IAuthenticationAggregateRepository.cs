using System;
using System.Collections.Generic;
using System.Text;

namespace ByeBikari.CoreDomain.JobSeekerAuthenticationAggregate
{
    public interface IJobSeekerAuthenticationAggregateRepository
    {
        void JobSeekerLogin(JobSeekerLoginVO jobSeekerLoginVO);

        void JobSeekerRegister(JobSeekerLoginVO jobSeekerLoginVO);

        void JobSeekerForgotPassword(JobSeekerForgotPasswordVO jobSeekerForgotPasswordVO);
    }
}
