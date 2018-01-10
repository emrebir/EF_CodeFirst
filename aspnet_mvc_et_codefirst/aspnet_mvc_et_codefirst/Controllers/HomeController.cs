using aspnet_mvc_et_codefirst.Models;
using aspnet_mvc_et_codefirst.Models.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_mvc_et_codefirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            DatabaseContext db = new DatabaseContext();
            List<Kisiler> kisiler = db.Kisiler.ToList();

            return View(kisiler);
        }
    }
}