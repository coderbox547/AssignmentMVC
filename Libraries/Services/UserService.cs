using Libraries.Data;
using Libraries.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Services
{
    public interface IUserService
    {
        IList<User> GetAllUsers();
    }

    public class UserService : IUserService
    {
        private readonly ApplicationContext _context;

        public UserService(ApplicationContext context)
        {
            _context = context;
        }
        public IList<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
