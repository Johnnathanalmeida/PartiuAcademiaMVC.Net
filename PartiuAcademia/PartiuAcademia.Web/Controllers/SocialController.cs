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

    [Autorizacao]
    public class SocialController : Controller
    {



        [Inject]
        public IStateBusiness StateBusiness { get; set; }





        public SocialController()
        {


            StateBusiness.Insert(new State
            {
                CreationDate = DateTime.Now,
                CreationUser = "Julio",
                Id = "12",
                Name = "Minas Gerais",
                Sigla = "MG",
                TerminationDate = DateTime.MaxValue,
                TerminationUser = string.Empty


            });
        }




    


    public ActionResult Index()
        {
            return View();
        }
    }
}