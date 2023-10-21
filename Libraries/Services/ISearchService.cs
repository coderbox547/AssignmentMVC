using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Domain.Users;

namespace Libraries.Services.Search
{
    public interface ISearchService
    {
        IList<Users> GetAllUsers();

        void InsertSearchParameter(int userId, string jsonString);
    }
}
