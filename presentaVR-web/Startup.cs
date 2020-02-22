using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(presentaVR.Startup))]
namespace presentaVR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
