using Libraries.Domain;
using MVCAssignment.Factories;
using MVCAssignment.Models.Request;
using MVCAssignment.Models.Response;
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
        private readonly ISearchModelFactory _searchModelFactory;

        public UserController(ISearchModelFactory searchModelFactory)
        {
            this._searchModelFactory=searchModelFactory;
        }

        [HttpPost]
        public ActionResult Submit(List<UserFilterRequest> data)
        {

            var responseList = _searchModelFactory.PrepareSearchUsers(data);

            return PartialView("_UserView",responseList);


        }


    }
}