using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCtrainingmva.Startup))]
namespace MVCtrainingmva
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
