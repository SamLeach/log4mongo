using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sam.MongoLogging.Web.Startup))]
namespace Sam.MongoLogging.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
