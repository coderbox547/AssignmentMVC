using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAssignment
{
    public class UserResponseModel
    {
        public int UserId { get; set; }

        public string UserName { get; set; }
        public string Role { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string Department { get; set; }



        public string EmpCode { get; set; }
    }
}