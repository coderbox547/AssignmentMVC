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
    public interface IParameterService
    {
       void Add(int userId, string jsonString);
    }

    public class ParameterService : IParameterService
    {
        private readonly ApplicationContext _context;

        public ParameterService(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(int userId, string jsonString)
        {
            Parameter entity = new Parameter { Json = jsonString, UserId = userId };
            _context.SearchParameters.Add(entity);
            _context.SaveChanges();
        }
    }
}
