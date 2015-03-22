using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartiuAcademia.Web.Startup))]
namespace PartiuAcademia.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
