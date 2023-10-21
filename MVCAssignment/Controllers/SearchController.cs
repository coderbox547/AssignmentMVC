using Libraries.Services.Search;
using MVCAssignment.Factories;
using MVCAssignment.Models.Search;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Web.Mvc;

namespace MVCAssignment.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchModelFactory _searchModelFactory;
        private readonly ISearchService _searchService;
        public SearchController(ISearchModelFactory searchModelFactory, ISearchService searchService)
        {
            _searchModelFactory = searchModelFactory;
            _searchService = searchService;
        }

        public ActionResult Create()
        {
            var model = new SearchParametersModel();
            _searchModelFactory.PrepareSearchParameterModel(model);
            return View(model);
        }


        [HttpPost]
        public ActionResult Create(SearchParametersModel model)
        {
            var userId = model.SelectedUser;
            var jsonString = JsonConvert.SerializeObject(model);
            _searchService.InsertSearchParameter(userId, jsonString);
            return View(model);
        }

    }
}