using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jugs_of_Blood.Startup))]
namespace Jugs_of_Blood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
