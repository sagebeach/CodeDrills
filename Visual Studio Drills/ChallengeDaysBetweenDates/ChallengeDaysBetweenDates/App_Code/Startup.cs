using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChallengeDaysBetweenDates.Startup))]
namespace ChallengeDaysBetweenDates
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
