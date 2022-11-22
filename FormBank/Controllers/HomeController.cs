using FormBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormBank.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult FormBank()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult FormBank(Person person)
        {
            return View (person);
        }
    }
}