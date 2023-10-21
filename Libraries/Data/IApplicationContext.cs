using Libraries.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Data
{
    public interface IApplicationContext
    {
        DbSet<Users> Users { get; set; }
        DbSet<SearchParameters> SearchParameters { get; set; }

       // IList<Users> GetAllUsers();
    }
}
