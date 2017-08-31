using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsSite.Web.Startup))]
namespace SportsSite.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
