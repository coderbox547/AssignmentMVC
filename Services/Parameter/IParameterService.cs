using Libraries.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Parameter
{
    public interface IParameterService
    {
        IList<Libraries.Domain.Parameter> GetAll();
    }
}
