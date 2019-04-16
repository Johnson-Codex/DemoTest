using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BMS.Web.Startup))]
namespace BMS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
