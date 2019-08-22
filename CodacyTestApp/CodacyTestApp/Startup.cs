using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodacyTestApp.Startup))]
namespace CodacyTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
