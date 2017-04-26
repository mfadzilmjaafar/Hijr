using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hijr.Startup))]
namespace Hijr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
