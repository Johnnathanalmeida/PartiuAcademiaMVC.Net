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






            return View();
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
                    CityBusiness.Insert(city);

                    return RedirectToAction("Index");

                   TempData["msgErro"] = "Stado inserido com sucesso";

                }
            }

            catch (InvalidOperationException ex)
            {
                TempData["msgErro"] = ex.Message;
                return View(city);
            }


            return View(city);
        }

        public ActionResult Edit(string id)
        {

            var City = CityBusiness.GetById(id);
            return View(City);
        }


        [HttpPost]
        public ActionResult Edit(City city)
        {
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
                TempData["msgErro"] = ex.Message;
                return View(city);
            }


            return View(city);
        }

        public ActionResult Delete(string id)
        {

            var state = CityBusiness.GetById(id);
            return View(state);
        }


        [HttpPost]
        public ActionResult Delete(State state)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    CityBusiness.Delete(state.Id);
                    TempData["msgErro"] = "Estado Excluido com Sucesso";

                    RedirectToAction("Index");
                }
            }

            catch (InvalidOperationException ex)
            {
                TempData["msgErro"] = ex.Message;
                return View(state);
            }


            return View(state);
        }


    }
}
