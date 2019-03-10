using DemoLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoLogin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LoginModel model = new LoginModel();
            model.UserName = "praveen";
            model.Password = "praveen";
            return View(model);
        }
    }
}