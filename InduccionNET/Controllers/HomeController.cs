using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InduccionNET.Models;

namespace InduccionNET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            induccionEntities entity = new induccionEntities();
            List<person> person = new List<person>();

            using (entity)
            {
                person = entity.people.ToList();
            }

          ViewBag.Message = "Your application description page.";

            return View(person);
        }
      
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}