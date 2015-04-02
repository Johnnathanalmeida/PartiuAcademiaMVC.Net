using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.Entities;
using PartiuAcademia.Core.Repository.Configuration;

namespace PartiuAcademia.Web.Controllers
{
    public class CityController : Controller
    {



        [Inject]
        public ICityBusiness CityBusiness { get; set; }

        [Inject]
        public PartiuAcademiaContext PartiuAcademiaContext { get; set; }

          


        public ActionResult Index()
        {
            var Lcity = PartiuAcademiaContext.City;
            
            
            return View(Lcity);
        }



        public ActionResult Insert()
        {

            ViewBag.Estado = PartiuAcademiaContext.State.OrderBy(c => c.Name);
            //ViewBag.Estado = new SelectList(PartiuAcademiaContext.State, "Id", "Name",);
            return View();
        }


        [HttpPost]
        public ActionResult Insert(City city)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    CityBusiness.Insert(city, "");

                    return RedirectToAction("Index");

                   TempData["msgErro"] = "Stado inserido com sucesso";

                }
            }

            catch (InvalidOperationException ex)
            {
                ViewBag.Estado = PartiuAcademiaContext.State.OrderBy(c => c.Name);
                TempData["msgErro"] = ex.Message;
                return View(city);
            }


            return View(city);
        }

        public ActionResult Edit(string id)
        {
            ViewBag.Estado = PartiuAcademiaContext.State.OrderBy(c => c.Name);
            var City = CityBusiness.GetById(id);
            return View(City);
        }


        [HttpPost]
        public ActionResult Edit(City city)
        {

            ViewBag.Estado = PartiuAcademiaContext.State.OrderBy(c => c.Name);
            try
            {

                if (ModelState.IsValid)
                {
                    CityBusiness.Update(city);

                    RedirectToAction("Index");
                }
            }

            catch (InvalidOperationException ex)
            {
                ViewBag.Estado = PartiuAcademiaContext.State.OrderBy(c => c.Name);
                TempData["msgErro"] = ex.Message;
                return View(city);
            }


            return View(city);
        }

        public ActionResult Delete(string id)
        {

            var city = CityBusiness.GetById(id);
            return View(city);
        }


        [HttpPost]
        public ActionResult Delete(City city)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    CityBusiness.Delete(city.Id, "");
                    TempData["msgErro"] = "Estado Excluido com Sucesso";

                    RedirectToAction("Index");
                }
            }

            catch (InvalidOperationException ex)
            {
                TempData["msgErro"] = ex.Message;
                return View(city);
            }


            return View(city);
        }


    }
}
