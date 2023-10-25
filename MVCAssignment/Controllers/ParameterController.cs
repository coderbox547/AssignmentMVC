
using MVCAssignment.Factories;
using MVCAssignment.Models.Search;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Web.Mvc;
using System.Collections;
using System.Collections.Generic;
using Libraries.Services;
using MVCAssignment.Models.Request;

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
        public ActionResult Create(CreateParameterRequest model)
        {
            List<Models.Response.Parameter> parameters = new List<Models.Response.Parameter>();

            foreach (var parameter in model.Parameters)
            {
                parameters.Add(new Models.Response.Parameter
                {
                    FieldName = parameter.FieldName,
                    MaskPattern = parameter.MaskPattern,
                    MaxFieldLength = parameter.MaxFieldLength,
                    MaxLimit = parameter.MaxLimit,
                    MinLimit = parameter.MinLimit,
                    Required = parameter.IsRequired ? "required" : string.Empty,
                    SelectedControlType = (Enums.ControlTypeEnum)parameter.SelectedControlType,
                    SelectedDataType = (Enums.DataTypeEnum)parameter.SelectedDataType
                });
            }

            var jsonString = JsonConvert.SerializeObject(parameters);
            _parameterService.Add(model.UserId, jsonString);
            return Json(new { success = true });
        }
    }
}