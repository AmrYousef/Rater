using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Rater.Services.Http.Startup))]

namespace Rater.Services.Http
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}