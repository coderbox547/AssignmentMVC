using Libraries.Data;
using DomainModels = Libraries.Domain;
using Nest;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.User
{
    public class UserService : IUserService
    {
        private readonly ApplicationContext _context;

        public UserService(ApplicationContext context)
        {
            this._context = context;
        }
        public IList<DomainModels.User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
