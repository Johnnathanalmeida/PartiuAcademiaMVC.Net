using Ninject.Modules;
using Ninject.Extensions.Conventions;
using PartiuAcademia.Core.Repository.Abstract;
using PartiuAcademia.Core.Repository.Concrete;

namespace PartiuAcademia.Core.DI
{
    public class PartiuAcademiaNinjectModule : NinjectModule
    {

        public override void Load()
        {
            AddBindingsGenerics();
        }

        private void AddBindingsGenerics() {
            Kernel.Bind(c => c.FromThisAssembly()
                    .SelectAllClasses()
                    .BindDefaultInterfaces());
            Kernel.Bind(typeof(IRepository<>)).To(typeof(BaseRepository<>));
        }

    }
}
