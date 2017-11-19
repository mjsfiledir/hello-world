using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAppWithIndAuth.Startup))]
namespace MVCAppWithIndAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
