using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Domain
{
    public class User 
    {
        public int UserId { get; set; }

        [MaxLength(450)]
        public string UserName { get; set; }    
        public string Role { get; set; }    
        public DateTime LastLogin { get; set; }

        public string FName { get; set; }

        public string LName { get;set; }

        public string Department { get; set; }
        public DateTime DOJ { get; set; }

        public int MgrId { get; set; }

        public decimal Seniority { get; set; }

        [MaxLength(10)]
        public string EmpCode { get; set; }


    }
}
