//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ByeBikari.InfraEntityFrameWork.Repositorys.JobSeekerAuthenticationAggregateRepositorys
//{
//    public class JobSeekerAuthenticationAggregateRepository : IJobSeekerAuthenticationAggregateRepository
//    {
//        private readonly ByeBikariDBContext _byeBikariContext;
//        public JobSeekerAuthenticationAggregateRepository(ByeBikariDBContext byeBikariContext)
//        {
//            this._byeBikariContext = byeBikariContext;
//        }

//        public void JobSeekerForgotPassword(JobSeekerForgotPasswordVO userForgotPasswordVO)
//        {
//            throw new NotImplementedException();
//        }

//        public void JobSeekerLogin(JobSeekerLoginVO userLoginVO)
//        {
//            var snapp = userLoginVO.GetSnapShot();

//            //UserLoginDTO userLoginDTO = new UserLoginDTO
//            //{
//            //    userName = snapp.username,
//            //    passWord = snapp.password
//            //};
//            //_byeBikariContext.
//        }

//        public void JobSeekerRegister(JobSeekerLoginVO userLoginVO)
//        {
//            throw new NotImplementedException();
//        }
//    }

//}
