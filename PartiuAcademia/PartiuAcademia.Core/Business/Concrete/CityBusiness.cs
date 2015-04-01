using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.Entities;

namespace PartiuAcademia.Core.Business.Concrete
{
    public class CityBusiness : Business<City>, ICityBusiness
    {

        public override void Insert(City entidade)
        {
            if (Query.Any(c => c.Name == entidade.Name))
            {
                throw new InvalidOperationException("Cidade já cadastrado no banco");
            }

            base.Insert(entidade);
        }


        public override void Update(City entidade)
        {
            if (Query.Any(s => s.Name == entidade.Name && !s.Id.Equals(entidade.Id)))
            {
                throw new InvalidOperationException("Não foi possivél alterar dados, dados já cadastrados no banco");
            }

            base.Update(entidade);
        }

       
    }
}
