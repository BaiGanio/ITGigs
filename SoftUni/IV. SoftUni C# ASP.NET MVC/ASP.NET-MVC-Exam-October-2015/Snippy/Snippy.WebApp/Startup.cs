using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Snippy.WebApp.Startup))]
namespace Snippy.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
