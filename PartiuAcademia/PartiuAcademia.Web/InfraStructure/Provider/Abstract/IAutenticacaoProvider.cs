using PartiuAcademia.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Web.InfraStructure.Provider.Abstract
{
    public interface IAutenticacaoProvider
    {
        bool Login(AutenticacaoModel autenticacaoModel, out string msgErr);

        void Logout();

        bool Authenticated { get; }
        AutenticacaoModel UserAuthenticated { get; }

        string setTicketEncrypted(AutenticacaoModel autenticacaoModel, int expiracaoEmMinuto = 180);
    }
}
