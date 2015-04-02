using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.Business.Concrete;
using PartiuAcademia.Core.Entities;
using PartiuAcademia.Core.Repository.Configuration;

namespace PartiuAcademia.Web.Controllers
{
    public class DistrictController : Controller
    {



        //private readonly IDistrictBusiness DistrictBusiness;

        //private readonly PartiuAcademiaContext PartiuAcademiaContext;



        //public DistrictController(PartiuAcademiaContext partiuAcademia,IDistrictBusiness district)
        //{

        //    DistrictBusiness = district;
        //    PartiuAcademiaContext = partiuAcademia;
        //}



        //public ActionResult Index()
        //{
        //    var Ldistrict = PartiuAcademiaContext.District.Include("City").ToList();


        //    return View(Ldistrict);
        //}



        //public ActionResult Insert()
        //{

        //    ViewBag.Cidade = PartiuAcademiaContext.City.OrderBy(c => c.Name);
        //    ViewBag.Estado = PartiuAcademiaContext.State.OrderBy(c => c.Name);
        //    return View();
        //}


        //[HttpPost]
        //public ActionResult Insert(District district)
        //{
        //    try
        //    {

        //        if (ModelState.IsValid)
        //        {
        //            DistrictBusiness.Insert(district);

        //            return RedirectToAction("Index");

        //            TempData["msgErro"] = "Stado inserido com sucesso";

        //        }
        //    }

        //    catch (InvalidOperationException ex)
        //    {
        //        ViewBag.Estado = PartiuAcademiaContext.State.OrderBy(c => c.Name);
        //        TempData["msgErro"] = ex.Message;
        //        return View(district);
        //    }


        //    return View(district);
        //}
	}
}