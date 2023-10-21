using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels = Libraries.Domain;

namespace Services.User
{
    public interface IUserService
    {
        IList<DomainModels.User> GetAllUsers();
    }
}
