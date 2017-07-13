using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MelliCalc.Startup))]
namespace MelliCalc
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
