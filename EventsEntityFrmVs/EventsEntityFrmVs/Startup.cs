using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventsEntityFrmVs.Startup))]
namespace EventsEntityFrmVs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
