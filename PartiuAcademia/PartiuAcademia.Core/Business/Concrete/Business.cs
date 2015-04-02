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

        public virtual void Delete(string id, string IdUser)
        {
            Repository.Delete(id, IdUser);
        }

        public virtual void Insert(T entidade, string IdUser)
        {
            Repository.Insert(entidade, IdUser);
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
