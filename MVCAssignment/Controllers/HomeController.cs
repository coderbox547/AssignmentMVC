using Libraries.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IParameterService _parameterService;

        public HomeController(IParameterService parameterService)
        {
            _parameterService = parameterService;
        }

        public ActionResult Index()
        {
            List<Models.Response.Parameter> retVal = new List<Models.Response.Parameter>();

            // Get the list of the search parameter on the basis of the user
            var parameter = _parameterService.Get(userId: 1);

            if (parameter != null)
            {
                retVal = JsonConvert.DeserializeObject<List<Models.Response.Parameter>>(parameter.Json);
            }

            return View(new ViewModels.ParameterViewModel
            {
                SearchParameters = retVal
            });
        }
    }
}