using Ninject;
using PartiuAcademia.Web.InfraStructure.CustomActionResult;
using PartiuAcademia.Web.InfraStructure.Provider.Abstract;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PartiuAcademia.Web.InfraStructure.Filters
{
    public class AutorizacaoAttribute : AuthorizeAttribute
    {
        [Inject]
        public IAutenticacaoProvider AutenticacaoProvider { get; set; }

        private string msgErro;

        public AutorizacaoAttribute()
        {
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (!AutenticacaoProvider.Authenticated)
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