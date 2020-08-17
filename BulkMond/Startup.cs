using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BulkMond.Startup))]
namespace BulkMond
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
