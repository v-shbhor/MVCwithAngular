using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCwithAngular.Startup))]
namespace MVCwithAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
