using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChallengeEpicSpies.Startup))]
namespace ChallengeEpicSpies
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
