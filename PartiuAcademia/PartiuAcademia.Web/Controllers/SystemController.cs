using PartiuAcademia.Web.InfraStructure.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartiuAcademia.Web.Controllers
{
    [Autorizacao]
    public class SystemController : Controller
    {
        // GET: System
        public ActionResult Index()
        {
            return View();
        }
    }
}