using Ninject;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.Entities;
using PartiuAcademia.Core.Repository.Abstract;
using System.Linq;

namespace PartiuAcademia.Core.Business.Concrete
{
    public class Business<T> : IBusiness<T> where T : Entities.EntityBase
    {
        [Inject]
        public IRepository<T> Repository { get; set; }


        public virtual IQueryable<T> Query
        {
            get { return Repository.Query; }
        }

        public virtual void Delete(string id)
        {
            Repository.Delete(id);
        }

        public virtual void Insert(T entidade)
        {
            Repository.Insert(entidade);
        }

        public virtual void Update(T entidade)
        {
            Repository.Update(entidade);
        }

        public virtual T GetById(string id)
        {
            return Repository.GetById(id);
        }
    }
}
