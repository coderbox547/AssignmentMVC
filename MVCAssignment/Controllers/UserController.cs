using MVCAssignment.Models.Request;
using MVCAssignment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {

            // Get the list of the search parameter on the basis of the user
            List<Models.Search.SearchParameterModel> searchParameters = new List<Models.Search.SearchParameterModel>();
            searchParameters.Add(new Models.Search.SearchParameterModel
            {
                FieldName = "EmpCode",
                SelectedControlType = Enums.ControlTypeEnum.TextBox,
                SelectedDataType = Enums.DataTypeEnum.String,
                MaskPattern = "[a-z]{3}[0-9]{4}",// "XXX9999",
                MaxFieldLength =7,
                Required = "required"
            });
            searchParameters.Add(new Models.Search.SearchParameterModel
            {
                FieldName = "Seniority",
                SelectedControlType = Enums.ControlTypeEnum.NumericTextBox,
                SelectedDataType = Enums.DataTypeEnum.Numeric,
                MaxFieldLength = 4,
                MinLimit=0,
                MaxLimit=3.5,
            });

            searchParameters.Add(new Models.Search.SearchParameterModel
            {
                FieldName = "DOJ",
                SelectedControlType = Enums.ControlTypeEnum.DateTime,
                SelectedDataType = Enums.DataTypeEnum.DateTime,
            });

            return View(new ViewModels.ParameterViewModel
            {
                SearchParameters = searchParameters
            });
        }

        [HttpPost]
        public void Submit(List<UserFilterRequest> data)
        {

        }

    }
}