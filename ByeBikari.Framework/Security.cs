//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace ByeBikari.Framework
//{
//    public static class Security
//    {
//        const int FaieldCountLimitation = 5;
//        private static Atlantic_DBEntities context = new Atlantic_DBEntities();


//        public static bool AddSystemUser(RegisterViewModel registerViewModel)
//        {
//            if (registerViewModel.phone <= 0)
//            {
//                HttpContext.Current.Session["Message"] = ErrorMessage.GetMessage(6);
//            }
//            //if (registerViewModel.reagentCode <= 0)
//            //{
//            //    HttpContext.Current.Session["Message"] = ErrorMessage.GetMessage(7);
//            //    return false;
//            //}
//            //if ((userName == null) || (userName == ""))
//            //{
//            //    HttpContext.Current.Session["Message"] = ErrorMessage.GetMessage(8);
//            //    return false;
//            //}
//            //if ((password == null) || (password == ""))
//            //{
//            //    HttpContext.Current.Session["Message"] = ErrorMessage.GetMessage(9);
//            //    return false;
//            //}

//            var member = context.Users.FirstOrDefault(m => m.phone == registerViewModel.phone);
//            if (member != null)
//            {
//                HttpContext.Current.Session["Message"] = ErrorMessage.GetMessage(10);
//                return false;
//            }
//            var membership = new Membership
//            {
//                UserID = userId,
//                RoleID = roleId,
//                UserName = userName,
//                Password = Cryptography.Encrypt(password),
//                CreateDate = DateTime.Today,
//                QuestionID = questionId,
//                Answer = answer,
//                FailedAnswerCount = 0,
//                FailedPasswordCount = 0
//            };
//            context.Users.Add(membership);
//            context.SaveChanges();
//            return true;
//        }

//        public static bool RemoveSystemUser(int id, Membership currentMember)
//        {
//            var member = context.Memberships.FirstOrDefault(m => m.ID == id);
//            if (member == null) return false;
//            if (member != currentMember)
//            {
//                context.Memberships.Remove(member);
//                context.SaveChanges();
//                return true;
//            }
//            HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(11);
//            return false;
//        }

//        public static bool ChangePassword(int currentMemberId, string oldPassword, string newPassword)
//        {
//            var currentMember = context.Memberships.FirstOrDefault(m => m.ID == currentMemberId);
//            if ((newPassword == "") || (newPassword == null))
//            {
//                HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(12);
//                return false;
//            }
//            if (Cryptography.Decrypt(currentMember.Password) != oldPassword)
//            {
//                HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(3);
//                return false;
//            }
//            currentMember.Password = Cryptography.Encrypt(newPassword);
//            context.SaveChanges();
//            return true;
//        }

//        public static bool ResetPassword(string userName, string nationalCode, int questionId, string answer)
//        {
//            var member = context.Memberships.FirstOrDefault(m => m.UserName == userName && m.NationalCode == nationalCode);
//            if (member == null) return false;
//            if (member.FailedAnswerCount <= FaieldCountLimitation)
//                if ((member.QuestionID == questionId) && (member.Answer == answer))
//                {
//                    member.Password = Cryptography.Encrypt("123");
//                    member.FailedPasswordCount = 0;
//                    member.FailedAnswerCount = 0;
//                    context.SaveChanges();
//                    HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(13);
//                    return true;
//                }
//                else
//                {
//                    member.FailedAnswerCount += 1;
//                    context.SaveChanges();
//                    return false;
//                }
//            HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(5);
//            return false;
//        }

//        public static bool AdminResetPassword(int memberId)
//        {
//            var member = context.Memberships.FirstOrDefault(m => m.ID == memberId);
//            if (member == null) return false;
//            member.Password = Cryptography.Encrypt("123");
//            member.FailedPasswordCount = 0;
//            member.FailedAnswerCount = 0;
//            context.SaveChanges();
//            HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(15);
//            return true;
//        }

//        public static bool UnlockUser(int memberId)
//        {
//            try
//            {
//                var member = context.Memberships.FirstOrDefault(m => m.ID == memberId);
//                if (member == null) return false;
//                member.FailedPasswordCount = 0;
//                member.FailedAnswerCount = 0;
//                context.SaveChanges();
//                HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(16);
//                return true;
//            }
//            catch
//            { return false; }
//        }

//        public static Membership Login(string userName, string password)
//        {
//            SimabEntities context = new SimabEntities();
//            var member = context.Memberships.FirstOrDefault(m => m.UserName == userName);
//            if (member == null)
//            {
//                HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(1);
//                return null;
//            }
//            if (member.AdminLockDate != null)
//            {
//                HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(2);
//                return null;
//            }

//            if (member.FailedPasswordCount <= FaieldCountLimitation)
//            {
//                string pass = Cryptography.Decrypt(member.Password);
//                if (password != pass)
//                {
//                    HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(3);
//                    member.FailedPasswordCount += 1;
//                    context.Configuration.ValidateOnSaveEnabled = false;
//                    context.SaveChanges();
//                    return null;
//                }
//                member.FailedPasswordCount = 0;
//                member.FailedAnswerCount = 0;
//                context.Configuration.ValidateOnSaveEnabled = false;
//                context.SaveChanges();
//                return member;
//            }

//            if (member.Role.RoleLevelID == 1)
//                HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(4);
//            else
//                HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(5);

//            return null;
//        }

//        public static Authorization Authorization(int roleId, int pageId, bool isWeb)
//        {
//            var authorization = context.Authorizations.FirstOrDefault(a => a.RoleID == roleId && a.PageID == pageId && a.ApplicationPage.IsWeb == isWeb);
//            return authorization;
//        }


//        public static Membership LoginRegistration(string nationalCode, string securityCode)
//        {
//            SimabEntities context = new SimabEntities();
//            var member = context.Memberships.FirstOrDefault(m => m.NationalCode == nationalCode);
//            if (member == null)
//            {
//                HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(16);
//                return null;
//            }

//            var CodeSecurity = Cryptography.Decrypt(member.SecurityCode);
//            if (CodeSecurity != securityCode)
//            {
//                HttpContext.Current.Session["Message"] = ErrorMessage.ErrorMessage.GetMessage(17);
//                return null;
//            }

//            return member;
//        }

//    }

//}
