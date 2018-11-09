using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VentureTest.Startup))]
namespace VentureTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
