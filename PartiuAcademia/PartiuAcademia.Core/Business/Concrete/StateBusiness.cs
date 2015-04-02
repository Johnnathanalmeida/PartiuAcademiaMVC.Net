using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.Entities;

namespace PartiuAcademia.Core.Business.Concrete
{
    public class StateBusiness : Business<State>, IStateBusiness
    {
        public override void Insert(State entidade)
        {
            if (Query.Any(s => s.Name == entidade.Name))
            {
                throw new InvalidOperationException("Estado já cadastrado no banco");
            }

            base.Insert(entidade);
        }


        public override void Update(State entidade)
        {
            if (Query.Any(s => s.Name == entidade.Name || s.Sigla == entidade.Sigla && !s.Id.Equals(entidade.Id)))
            {
                throw new InvalidOperationException("Não foi possivél alterar dados, dados já cadastrados no banco");
            }

            base.Update(entidade);
        }

    }
}
