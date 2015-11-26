using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TopSonic.Startup))]
namespace TopSonic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
