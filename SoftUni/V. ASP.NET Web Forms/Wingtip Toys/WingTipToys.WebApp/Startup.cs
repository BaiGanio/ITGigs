using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WingTipToys.WebApp.Startup))]
namespace WingTipToys.WebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
