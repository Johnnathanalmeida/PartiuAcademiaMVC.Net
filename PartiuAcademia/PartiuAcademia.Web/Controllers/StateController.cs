using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.Entities;

namespace PartiuAcademia.Web.Controllers
{
    public class StateController : Controller
    {


        [Inject]
        public IStateBusiness StateBusiness { get; set; }



        public ActionResult Index()
        {
            var Lstate = StateBusiness.Query.ToList();

            return View(Lstate);
        }


        public ActionResult Insert()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Insert(State state)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    StateBusiness.Insert(state, "");

                    TempData["msgErro"] = "Stado inserido com sucesso";

                    return RedirectToAction("Index");


                }
            }

            catch (InvalidOperationException ex)
            {
                TempData["msgErro"] = ex.Message;
                return View(state);
            }


            return View(state);
        }

        public ActionResult Edit(string id)
        {

            var state = StateBusiness.GetById(id);
            return View(state);
        }


        [HttpPost]
        public ActionResult Edit(State state)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    StateBusiness.Update(state);

                   return  RedirectToAction("Index");
                }
            }

            catch (InvalidOperationException ex)
            {
                TempData["msgErro"] = ex.Message;
                return View(state);
            }


            return View(state);
        }

        public ActionResult Delete(string id)
        {

            var state = StateBusiness.GetById(id);
            return View(state);
        }


        [HttpPost]
        public ActionResult Delete(State state)
        {
            try
            {

                    StateBusiness.Delete(state.Id, "");
                    TempData["msgErro"] = "Estado Excluido com Sucesso";

                   return  RedirectToAction("Index");
               
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