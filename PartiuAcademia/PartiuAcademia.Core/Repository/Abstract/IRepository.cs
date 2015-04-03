using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartiuAcademia.Core.Entities;

namespace PartiuAcademia.Core.Repository.Abstract
{
    public interface IRepository<T> where T : EntityBase
    {
        IQueryable<T> Query { get; }

        void Delete(string id, string IdUser);

        void  Insert(T entity, string IdUser);

        void Update(T entity);

        T GetById(string id);

        T InsertReturn(T entity, string IdUser);

    }
}
