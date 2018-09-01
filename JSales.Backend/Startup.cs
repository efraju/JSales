using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JSales.Backend.Startup))]
namespace JSales.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
