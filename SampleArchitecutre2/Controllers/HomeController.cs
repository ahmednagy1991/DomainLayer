using Service.Models;
using Service.ServiceAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleArchitecutre2.Controllers
{
    public class HomeController : Controller
    {
        IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            //var mode = _userService.Login("test", "testpass");
            //var val = mode.Validate();
            //var model = new UserModel();
            //model.Email = "test7";
            //model.Username = "test user7";
            //model.Password = "test password7";
            //model.Phone = "01023456";
            //var val = model.Validate();
            //if (val.IsValid)
            //{
            //    _userService.Register(model);
            //}

            return View();
        }
    }
}
