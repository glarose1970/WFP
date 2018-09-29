using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeeklyFootballPool.Startup))]
namespace WeeklyFootballPool
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
