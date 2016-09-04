using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(xPlatAuction.MobileApp.Backend.Startup))]

namespace xPlatAuction.MobileApp.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}