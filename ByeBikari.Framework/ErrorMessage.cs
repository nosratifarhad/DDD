using System;
using System.Collections.Generic;
using System.Text;

namespace ByeBikari.Framework
{
    public static class ErrorMessage
    {

        public static string GetMessage(int givenNumber)
        {
            string errorMessage = null;
            switch (givenNumber)
            {
                case 1:
                    errorMessage = "شماره تلفن را صحیح وارد نکرده اید";
                    break;
                case 2:
                    errorMessage = "کد معر";
                    break;
                //case 3:
                //    errorMessage = "کلمه عبور اشتباه است";
                //    break;
                //case 4:
                //    errorMessage = "نام کاربري شما مسدود است. براي بازگرداندن آن با شرکت خانه طراحان تماس بگيريد";
                //    break;
                //case 5:
                //    errorMessage = "نام کاربري شما مسدود است. براي بازگرداندن آن با مدير سيستم تماس بگيريد";
                //    break;
                //case 6:
                //    errorMessage = "کاربر را انتخاب کنيد";
                //    break;
                //case 7:
                //    errorMessage = "نقش کاربر را انتخاب کنيد";
                //    break;
                //case 8:
                //    errorMessage = "نام کاربري را وارد کنيد";
                //    break;
                //case 9:
                //    errorMessage = "کلمه عبور را وارد کنيد";
                //    break;
                case 10:
                    errorMessage = "اين نام کاربري در سيستم موجود است";
                    break;
                //case 11:
                //    errorMessage = "حذف کاربر جاري مجاز نيست";
                //    break;
                //case 12:
                //    errorMessage = "کلمه عبور جديد معتبر نيست";
                //    break;
                //case 13:
                //    errorMessage = "کلمه عبور شما به '123' تغيير يافت. خواهشمنديم بعداز اولين ورود به برنامه کلمه عبور خود را تغيير دهيد";
                //    break;
                //case 14:
                //    errorMessage = "کلمه عبور کاربر مورد نظر به '123' تغيير يافت";
                //    break;
                //case 15:
                //    errorMessage = "عمليات با موفقيت انجام شد";
                //    break;

                default:
                    errorMessage = "";
                    break;
            }


            return errorMessage;
        }
    }

}
