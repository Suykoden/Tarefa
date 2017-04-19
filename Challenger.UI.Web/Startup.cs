using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Challenger.UI.Web.Startup))]
namespace Challenger.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
