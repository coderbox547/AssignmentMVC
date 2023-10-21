using Libraries.Data;
using Libraries.Domain.Users;
using Nest;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Search
{
    public class SearchService : ISearchService
    {
        private readonly ApplicationContext _context;

        public SearchService(ApplicationContext context)
        {
            this._context = context;
        }
        public IList<Users> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
