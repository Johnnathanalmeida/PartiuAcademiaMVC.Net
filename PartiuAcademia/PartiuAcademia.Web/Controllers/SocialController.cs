using PartiuAcademia.Web.InfraStructure.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartiuAcademia.Web.Controllers
{

    [Autorizacao]
    public class SocialController : Controller
    {
        // GET: Social
        public ActionResult Index()
        {
            return View();
        }
    }
}