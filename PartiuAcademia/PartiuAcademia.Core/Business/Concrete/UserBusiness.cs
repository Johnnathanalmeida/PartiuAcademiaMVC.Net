using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Core.Business.Concrete
{
    public class UserBusiness : Business<User>, IUserBusiness
    {
        public override void Insert(User User, string IdUser)
        {
            if (Query.Any(u => u.Email == User.Email))
                throw new InvalidOperationException("Não é possível inserir usuário com o mesmo login.");
            base.Insert(User, IdUser);
        }
    }
}
