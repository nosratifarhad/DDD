using ByeBikari.InfraEntityFrameWork.DataModels.Users;
using System;
using System.Linq;

namespace ByeBikari.InfraEntityFrameWork
{
    class Program
    {
        static void Main(string[] args)
        {

            ByeBikariReadContext contest = new ByeBikariReadContext();



            //User userDTO = new User();

            //userDTO.Name = "userDTO";
            //userDTO.SurName = "userDTO";
            //userDTO.UserName = "userDTO";
            //userDTO.PassWord = "userDTO";
            //userDTO.Emailaddress = "userDTO";
            //userDTO.TestProp = "userDTO";
            //userDTO.TestProp2 = "userDTO";

            //contest.Users.Add(userDTO);

            //contest.SaveChanges();
            var ssss = contest.Users.Where(a => a.Name == "userDTO").ToString();
            Console.WriteLine(ssss);

            Console.WriteLine("Hello World!");
        }
    }
}
