using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jquery_ornekler.Startup))]
namespace Jquery_ornekler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
