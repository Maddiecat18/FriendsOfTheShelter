using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FOTSV2.Startup))]
namespace FOTSV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
