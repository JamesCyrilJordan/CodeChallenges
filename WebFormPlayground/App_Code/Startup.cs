using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormPlayground.Startup))]
namespace WebFormPlayground
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
