using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeApps.Startup))]
namespace BeApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
