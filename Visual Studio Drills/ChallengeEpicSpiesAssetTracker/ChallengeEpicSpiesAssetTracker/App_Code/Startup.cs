using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChallengeEpicSpiesAssetTracker.Startup))]
namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
