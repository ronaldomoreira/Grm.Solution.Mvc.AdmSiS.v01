using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GrmWebAppAdmSiSv01.Startup))]
namespace GrmWebAppAdmSiSv01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
