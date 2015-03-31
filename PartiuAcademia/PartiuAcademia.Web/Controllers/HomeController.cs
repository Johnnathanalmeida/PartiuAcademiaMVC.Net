using Ninject;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartiuAcademia.Web.Controllers
{
    public class HomeController : Controller
    {



      
       
        
        public ActionResult Index()
        {

          
            return View();
        }

        public ActionResult IndexTemplate() {
            return View();
        }

        public ActionResult Gym() {
            return View();
        }

        public ActionResult Modality()
        {
            return View();
        }

        public ActionResult Promotion()
        {
            return View();
        }
                
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}