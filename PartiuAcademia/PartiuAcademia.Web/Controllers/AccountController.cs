using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using PartiuAcademia.Web.Models;

namespace PartiuAcademia.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
                
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            //AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}