using System;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using NUnit;
using NUnit.Framework;
using PartiuAcademia.Core.DI;
using PartiuAcademia.Core.Repository.Configuration;

namespace PartiuAcademiaTeste
{

    public abstract class BaseTeste
    {


        protected IKernel Kernel;

        [TestFixtureSetUp]
        public virtual void AntesDeTodosTestes()
        {

            Kernel = new StandardKernel(new PartiuAcademiaNinjectModule());
            Kernel.Inject(this);
        }

        public virtual void AntesDeCadaTest()
        {

            var PartiuAcademiaModule = Kernel.Get<PartiuAcademiaContext>();

            if (PartiuAcademiaModule.Database.Exists())
            {
                PartiuAcademiaModule.Database.Delete();
            }


           Database.SetInitializer(new MigrateDatabaseToLatestVersion<PartiuAcademiaContext, PartiuAcademia.Core.Migrations.Configuration>());

            using (PartiuAcademiaModule)
            {

                PartiuAcademiaModule.Database.Initialize(true);

            }



        }

    }
}

