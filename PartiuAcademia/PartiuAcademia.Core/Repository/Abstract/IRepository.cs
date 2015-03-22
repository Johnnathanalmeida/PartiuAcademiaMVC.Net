using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Core.Repository.Abstract
{
    public interface IRepository<T> where T : Entities.EntityBase
    {
        IQueryable<T> Query { get; }

        void Delete(string id);

        void Insert(T entity);

        void Update(T entity);

        T GetById(string id);
    }
}
