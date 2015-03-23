using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaMuscia.web.Startup))]
namespace SistemaMuscia.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
