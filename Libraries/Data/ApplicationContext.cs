using Libraries.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("Data Source=PC-PC\\SQLEXPRESS2014;Initial Catalog=Assignment;Integrated Security=True;Persist Security Info=False;") {

           // Database.SetInitializer<ApplicationContext>(new DBInitializer());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Parameter> SearchParameters { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<User>().HasKey(x => x.UserId);
            builder.Entity<User>().HasIndex(x => x.UserName).IsUnique();
            builder.Entity<User>().HasIndex(x => x.EmpCode).IsUnique();

            builder.Entity<Parameter>().HasKey(x => x.Id);
            base.OnModelCreating(builder);
        }
    }
}
