using PartiuAcademia.Core.Entities;
using System.Linq;

namespace PartiuAcademia.Core.Business.Concrete
{
    public interface IBusiness<T> where T : EntityBase
    {
        IQueryable<T> Query { get; }

        void Delete(string id);

        void Insert(T entidade);

        void Update(T entidade);

        T GetById(string id);
    }
}
