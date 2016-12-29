using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(evfaWS.Startup))]
namespace evfaWS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
