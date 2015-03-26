using PartiuAcademia.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Web.InfraStructure.Provider.Abstract
{
    public interface IAuthenticationProvider
    {
        bool Login(LoginViewModel AuthenticationModel, out string msgErr);

        void Logout();

        bool Authenticated { get; }
        LoginViewModel UserAuthenticated { get; }

        string setTicketEncrypted(LoginViewModel AuthenticationModel, int expiracaoEmMinuto = 180);

    }
}
