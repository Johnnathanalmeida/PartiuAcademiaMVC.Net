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

        void Delete(string id, string IdUser);

        void Insert(T entidade, string IdUser);

        void Update(T entidade);

        T GetById(string id);
    }
}
