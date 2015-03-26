using System;
using Ninject;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartiuAcademia.Web.InfraStructure.Provider.Abstract;
using System.Web.Security;
using PartiuAcademia.Web.InfraStructure.CustomActionResult;

namespace PartiuAcademia.Web.InfraStructure.Filters
{
    public class AutorizacaoAttribute : AuthorizeAttribute
    {
        [Inject]
        public IAuthenticationProvider AuthenticationProvider { get; set; }

        private string msgErro;

        public AutorizacaoAttribute()
        {
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (!AuthenticationProvider.Authenticated)
            {
                msgErro = "Você precisa se autenticar para acessar essa página";
                return false;
            }
            //if (!gruposComAcesso.Contains(AutenticacaoProvider.UsuarioAutenticado.Grupo.GetValueOrDefault()) && gruposComAcesso.Length > 0)
            //{
            //    msgErro = "Você não tem permissão para acessar essa página com suas credenciais";
            //    return false;
            //}
            return true;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);

            var isAjaxRequest = filterContext.HttpContext.Request.IsAjaxRequest();
            if (isAjaxRequest)
                filterContext.Result = new RedirectResultWithStatus(FormsAuthentication.LoginUrl, ((HttpUnauthorizedResult)filterContext.Result).StatusCode);
            filterContext.Controller.TempData["MensagemErro"] = msgErro;
        }
    }
}