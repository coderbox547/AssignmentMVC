using Libraries.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Data
{
    public class DBInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            IList<User> user = new List<User>();

            user.Add(new User() { UserId = 105, UserName ="Acc0185", Role = "A/C Mgr", LastLogin = DateTime.Now, FName = "Sanjay", LName = "Aggarwal",Department ="Accounts", DOJ = DateTime.Now,MgrId = 78, Seniority = 5.08M, EmpCode = "ACC0034" });
            user.Add(new User() { UserId = 106, UserName = "Acc0567", Role = "Asst", LastLogin = DateTime.Now, FName = "Amit", LName = "Sharma", Department = "Accounts", DOJ = DateTime.Now, MgrId = 105, Seniority = 8.15M, EmpCode = "ACC0598" });

            context.Users.AddRange(user);

            base.Seed(context);
        }
    }
}
