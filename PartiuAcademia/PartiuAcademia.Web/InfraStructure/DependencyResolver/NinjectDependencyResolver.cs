using Ninject;
using PartiuAcademia.Core.DI;
using PartiuAcademia.Web.InfraStructure.Provider.Abstract;
using PartiuAcademia.Web.InfraStructure.Provider.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartiuAcademia.Web.InfraStructure.DependencyResolver
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        public IKernel Kernel { get; private set; }

        public NinjectDependencyResolver()
        {
            Kernel = new StandardKernel(new PartiuAcademiaNinjectModule());
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return Kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Kernel.Bind<IAutenticacaoProvider>().To<AutenticacaoProvider>();
        }
    }
}