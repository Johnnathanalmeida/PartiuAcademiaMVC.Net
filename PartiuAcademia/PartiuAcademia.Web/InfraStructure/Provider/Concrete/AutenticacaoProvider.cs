using Ninject;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.DTO;
using PartiuAcademia.Web.InfraStructure.Provider.Abstract;
using PartiuAcademia.Web.InfraStructure.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace PartiuAcademia.Web.InfraStructure.Provider.Concrete
{
    public class AutenticacaoProvider : IAutenticacaoProvider
    {
        [Inject]
        public IUserBusiness UserBusiness { get; set; }

        [Inject]
        public AutenticacaoModel AutenticacaoModel { get; set; }


        public bool Login(Core.DTO.AutenticacaoModel autenticacaoModel, out string msgErr)
        {
            msgErr = string.Empty;

            var usuario = UserBusiness.Query.FirstOrDefault(c => c.Email == autenticacaoModel.Email);

            if (usuario == null || usuario.Password != autenticacaoModel.Password)
            {
                msgErr = "Login ou senha incorretos";
                return false;
            }

            autenticacaoModel.Name = usuario.Name;
            autenticacaoModel.Id = usuario.Id;

            GerarTicketEArmazenarComoCookie(autenticacaoModel);

            return true;
        }

        private void GerarTicketEArmazenarComoCookie(Core.DTO.AutenticacaoModel autenticacaoModel, int expiracaoEmMinutos = 180)
        {
            var ticketEncriptado = setTicketEncrypted(autenticacaoModel, expiracaoEmMinutos);

            var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, ticketEncriptado);

            authCookie.Expires = DateTime.Now.AddMinutes(expiracaoEmMinutos);

            HttpContext.Current.Response.Cookies.Add(authCookie);


        }

        public void Logout()
        {
            FormsAuthentication.SignOut();
        }

        public bool Authenticated
        {
            get { return HttpContext.Current.User.Identity.IsAuthenticated; }
        }

        public Core.DTO.AutenticacaoModel UserAuthenticated
        {
            get
            {
                if (Authenticated)
                {
                    var identity = (FormsIdentity)HttpContext.Current.User.Identity;

                    var ticket = identity.Ticket;

                    AutenticacaoModel = Serializador.DeserializarAutenticacaoModel(ticket.UserData);

                    return AutenticacaoModel;
                }
                return null;
            }
        }

        public string setTicketEncrypted(Core.DTO.AutenticacaoModel autenticacaoModel, int expiracaoEmMinuto = 180)
        {
            var autenticacaoModelSerializado = Serializador.SerializarAutenticacaoModel(autenticacaoModel);
            var ticket = new FormsAuthenticationTicket(1, autenticacaoModel.Email,
                DateTime.Now, DateTime.Now.AddMinutes(expiracaoEmMinuto), false, autenticacaoModelSerializado,
                FormsAuthentication.FormsCookiePath);
            var ticketEncriptado = FormsAuthentication.Encrypt(ticket);
            return ticketEncriptado;
        }
    
    }
}