using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture12DataAuthentication.Startup))]
namespace Lecture12DataAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
