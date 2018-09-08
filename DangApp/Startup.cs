using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DangApp.Startup))]
namespace DangApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
