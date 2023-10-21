using Libraries.Domain.Users;
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
        public ApplicationContext() : base("Data Source=DESKTOP-JMRIN0K\\SQLEXPRESS01;Initial Catalog=Assignment;Integrated Security=True;Persist Security Info=False;") {

           // Database.SetInitializer<ApplicationContext>(new DBInitializer());
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<SearchParameters> SearchParameters { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<Users>().HasKey(x => x.UserId);
            builder.Entity<Users>().HasIndex(x => x.UserName).IsUnique();
            builder.Entity<Users>().HasIndex(x => x.EmpCode).IsUnique();

            builder.Entity<SearchParameters>().HasKey(x => x.Id);
            base.OnModelCreating(builder);
        }
    }
}
