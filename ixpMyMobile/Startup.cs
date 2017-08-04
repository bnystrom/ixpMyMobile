using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ixpMyMobile.Startup))]
namespace ixpMyMobile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
