﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.Entities;
using PartiuAcademia.Core.Repository.Configuration;

namespace PartiuAcademia.Web.Controllers
{
    public class UserController : Controller
    {


        private readonly IUserBusiness  userBusiness;

        private readonly PartiuAcademiaContext partiuAcademiaContext ;

        public UserController(IUserBusiness userBusinessParam, PartiuAcademiaContext _contextParam)
        {

            userBusiness = userBusinessParam;
            partiuAcademiaContext = _contextParam;
        }

      
        public ActionResult Index()
        {
            var Luser = partiuAcademiaContext.User.Include("Address").ToList();

            return View(Luser);
        }


        public ActionResult Inserir()
        {

            ViewBag.Role = partiuAcademiaContext.Role.OrderBy(r => r.Name);
            return View();

        }

        [HttpPost]
        public ActionResult Inserir(User user)
        {

            ViewBag.Role = partiuAcademiaContext.Role.OrderBy(r => r.Name);

            try
            {

                if (ModelState.IsValid)
                {
                    userBusiness.Insert(user);

                    return RedirectToAction("Index");

                    TempData["msgErro"] = "Stado inserido com sucesso";

                }
            }

            catch (InvalidOperationException ex)
            {
                
                TempData["msgErro"] = ex.Message;
                return View(user);
            }


            return View(user);
        }



	}
}