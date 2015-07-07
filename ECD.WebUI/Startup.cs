using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECD.WebUI.Startup))]
namespace ECD.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
