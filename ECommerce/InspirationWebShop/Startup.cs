using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InspirationWebShop.Startup))]
namespace InspirationWebShop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
