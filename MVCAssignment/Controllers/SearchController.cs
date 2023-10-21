using MVCAssignment.Factories;
using MVCAssignment.Models.Search;
using System.Diagnostics;
using System.Web.Mvc;

namespace MVCAssignment.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchModelFactory _searchModelFactory;
        public SearchController(ISearchModelFactory searchModelFactory)
        {
            _searchModelFactory = searchModelFactory;
        }

        public ActionResult Index()
        {
            var model = new SearchParametersModel();
            _searchModelFactory.PrepareSearchParameterModel(model);
            return View();
        }


       

    }
}