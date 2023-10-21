namespace Libraries.Migrations
{
    using Libraries.Domain.Users;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Libraries.Data.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Libraries.Data.ApplicationContext context)
        {
            IList<Users> user = new List<Users>();

            user.Add(new Users() { UserId = 105, UserName = "Acc0185", Role = "A/C Mgr", LastLogin = DateTime.Now, FName = "Sanjay", LName = "Aggarwal", Department = "Accounts", DOJ = DateTime.Now, MgrId = 78, Seniority = 5.08M, EmpCode = "ACC0034" });
            user.Add(new Users() { UserId = 106, UserName = "Acc0567", Role = "Asst", LastLogin = DateTime.Now, FName = "Amit", LName = "Sharma", Department = "Accounts", DOJ = DateTime.Now, MgrId = 105, Seniority = 8.15M, EmpCode = "ACC0598" });

            context.Users.AddRange(user);

            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
