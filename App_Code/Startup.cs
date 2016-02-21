using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KHAMBLEYMAPDEMO.Startup))]
namespace KHAMBLEYMAPDEMO
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
