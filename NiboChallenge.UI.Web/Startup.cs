using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NiboChallenge.UI.Web.Startup))]
namespace NiboChallenge.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
