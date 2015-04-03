using Ninject;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartiuAcademia.Core.Repository.Configuration;

namespace PartiuAcademia.Core.Business.Concrete
{
    public class UserBusiness : Business<User>, IUserBusiness
    {

        public override void Insert(User user, string IdUser)
        {

            if (Query.Any(u => u.Email == user.Email)){
                throw new InvalidOperationException("Não é possível inserir usuário com o mesmo login.");
                
            }

            if (string.IsNullOrEmpty(user.Address.Bairro))
            {
                user.Address = null;
            }

            base.Insert(user, IdUser);
        }
    }
}
