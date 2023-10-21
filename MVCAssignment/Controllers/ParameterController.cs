
using MVCAssignment.Factories;
using MVCAssignment.Models.Search;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Web.Mvc;
using System.Collections;
using System.Collections.Generic;
using Libraries.Services;

namespace MVCAssignment.Controllers
{
    public class ParameterController : Controller
    {
        private readonly ISearchModelFactory _searchModelFactory;
        private readonly IParameterService _parameterService;
        public ParameterController(ISearchModelFactory searchModelFactory, IParameterService parameterService)
        {
            _searchModelFactory = searchModelFactory;
            _parameterService = parameterService;
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

            List<SearchParameterModel> parameters = new List<SearchParameterModel>
            {
                new SearchParameterModel
                {
                     FieldName=model.FieldName,
                     MaskPattern=model.MaskPattern,
                     MaxFieldLength=model.MaxFieldLength,
                     MaxLimit=model.MaxLimit,
                     MinLimit=model.MinLimit,
                     Required=model.IsRequired?"required":string.Empty,
                     SelectedControlType= (Enums.ControlTypeEnum) model.SelectedControlType,
                     SelectedDataType= (Enums.DataTypeEnum)model.SelectedDataType
                }
            };

            var jsonString = JsonConvert.SerializeObject(parameters);
            _parameterService.Add(userId, jsonString);
            return View(model);
        }

    }
}