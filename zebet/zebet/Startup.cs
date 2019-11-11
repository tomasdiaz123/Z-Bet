using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zebet.Startup))]
namespace zebet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
