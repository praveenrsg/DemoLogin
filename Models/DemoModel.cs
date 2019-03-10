using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoLogin.Models
{
    
    public class LoginModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
    public class PatientDetailsModel
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Doctor { get; set; }
        public string IsNormal { get; set; }
        public string ImgUrl { get; set; }

    }
}