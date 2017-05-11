using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeWork1.Startup))]
namespace HomeWork1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
