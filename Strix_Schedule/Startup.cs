using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Strix_Schedule.Startup))]
namespace Strix_Schedule
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
