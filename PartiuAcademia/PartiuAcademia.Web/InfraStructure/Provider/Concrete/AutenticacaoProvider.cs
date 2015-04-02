using Ninject;
using PartiuAcademia.Core.Business.Abstract;
using PartiuAcademia.Core.DTO;
using PartiuAcademia.Web.InfraStructure.Provider.Abstract;
using PartiuAcademia.Web.InfraStructure.Utils;
using System;
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
        public LoginViewModel AuthenticationModel { get; set; }


        public bool Login(Core.DTO.LoginViewModel AuthenticationModel, out string msgErr)
        {
            msgErr = string.Empty;

            var usuario = UserBusiness.Query.FirstOrDefault(c => c.Email == AuthenticationModel.Email);

            if (usuario == null || usuario.Password != AuthenticationModel.Password)
            {
                msgErr = "Login ou senha incorretos";
                return false;
            }

            AuthenticationModel.Name = usuario.Name;
            AuthenticationModel.Id = usuario.Id;

            GerarTicketEArmazenarComoCookie(AuthenticationModel);

            return true;
        }

        private void GerarTicketEArmazenarComoCookie(Core.DTO.LoginViewModel model, int expiracaoEmMinutos = 180)
        {
            var ticketEncriptado = setTicketEncrypted(model, expiracaoEmMinutos);
            
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

        public Core.DTO.LoginViewModel UserAuthenticated
        {
            get
            {
                if (Authenticated)
                {
                    var identity = (FormsIdentity)HttpContext.Current.User.Identity;

                    var ticket = identity.Ticket;

                    AuthenticationModel = Serializador.DeserializarAutenticacaoModel(ticket.UserData);

                    return AuthenticationModel;
                }
                return null;
            }
        }

        public string setTicketEncrypted(Core.DTO.LoginViewModel AuthenticationModel, int expiracaoEmMinuto = 180)
        {
            var autenticacaoModelSerializado = Serializador.SerializarAutenticacaoModel(AuthenticationModel);
            var ticket = new FormsAuthenticationTicket(1, AuthenticationModel.Email,
                DateTime.Now, DateTime.Now.AddMinutes(expiracaoEmMinuto), false, autenticacaoModelSerializado,
                FormsAuthentication.FormsCookiePath);
            var ticketEncriptado = FormsAuthentication.Encrypt(ticket);
            return ticketEncriptado;
        }
    
    }
}