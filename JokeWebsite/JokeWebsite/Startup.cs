using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JokeWebsite.Startup))]
namespace JokeWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
