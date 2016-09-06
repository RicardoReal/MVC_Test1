using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Test1.Startup))]
namespace MVC_Test1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
