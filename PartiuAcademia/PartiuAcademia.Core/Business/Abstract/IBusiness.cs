using PartiuAcademia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Core.Business.Abstract
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
