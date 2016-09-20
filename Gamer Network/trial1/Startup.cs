using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(trial1.Startup))]
namespace trial1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
