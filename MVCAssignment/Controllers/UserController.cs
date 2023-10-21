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
               [HttpPost]
        public void Submit(List<UserFilterRequest> data)
        {

        }

    }
}