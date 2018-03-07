using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rastgelebirproje1.Startup))]
namespace rastgelebirproje1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
