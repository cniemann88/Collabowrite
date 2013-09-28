using Collabowrite.Shared.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Collabowrite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            List<User> users = new List<Shared.DataContracts.User>();
            users.Add(new User() { Username = "Test1", Age = 12, Email = "Test@Test.com", Id = 0 });
            users.Add(new User() { Username = "Test1", Age = 12, Email = "Test@Test.com", Id = 0 });
            users.Add(new User() { Username = "Test1", Age = 12, Email = "Test@Test.com", Id = 0 });
            users.Add(new User() { Username = "Test1", Age = 12, Email = "Test@Test.com", Id = 0 });
            users.Add(new User() { Username = "Test1", Age = 12, Email = "Test@Test.com", Id = 0 });
            users.Add(new User() { Username = "Test1", Age = 12, Email = "Test@Test.com", Id = 0 });
            users.Add(new User() { Username = "Test1", Age = 12, Email = "Test@Test.com", Id = 0 });

            var mgr = new CollabowriteManager.CollabowriteManager();

            mgr.CreateManyUser(users);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
