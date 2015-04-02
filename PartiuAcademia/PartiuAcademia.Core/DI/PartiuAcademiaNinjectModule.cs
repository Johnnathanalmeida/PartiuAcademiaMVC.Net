using Ninject.Modules;
using Ninject.Extensions.Conventions;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.Business.Concrete;
using PartiuAcademia.Core.Repository.Abstract;
using PartiuAcademia.Core.Repository.Concrete;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.Business.Concrete;
using PartiuAcademia.Core.Entities;

namespace PartiuAcademia.Core.DI
{
    public class PartiuAcademiaNinjectModule : NinjectModule
    {

        public override void Load()
        {

           
            AddBindingsGenerics();
        }

        private void AddBindingsGenerics()
        {
            Kernel.Bind(c => c.FromThisAssembly()
                .SelectAllClasses()
                .BindDefaultInterfaces());


            Kernel.Bind(typeof (IRepository<>)).To(typeof (BaseRepository<>));
           // Kernel.Bind<IDistrictBusiness>().To<DistrictBusiness>();
            //Kernel.Bind(typeof(IBusiness<>)).To(typeof(Business<>));
        }

    }
}
