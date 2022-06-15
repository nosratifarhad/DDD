using System;
using System.Collections.Generic;
using System.Text;

namespace ByeBikari.InfraEntityFrameWork.ModelDTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Emailaddress { get; set; }
        public string TestProp { get; set; }
        public string TestProp2 { get; set; }
    }
}
