﻿using Ninject;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.Entities;
using PartiuAcademia.Web.InfraStructure.Filters;
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

    

   
    public class SocialController : Controller
    {

        [Inject]
        public IUserBusiness UserBusiness { get; set; }


       
        public ActionResult Index()
        {
            return View();
        }
    }
}