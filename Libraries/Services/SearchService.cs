using Libraries.Data;
using Libraries.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Services.Search
{
    public class SearchService : ISearchService
    {
        private readonly ApplicationContext _context;

        public SearchService(ApplicationContext context)
        {
            _context = context;
        }
        public IList<Users> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public void InsertSearchParameter(int userId, string jsonString)
        {
            SearchParameters entity = new SearchParameters { SearchJson = jsonString, UserId = userId };
            _context.SearchParameters.Add(entity);
            _context.SaveChanges();
        }
    }
}
