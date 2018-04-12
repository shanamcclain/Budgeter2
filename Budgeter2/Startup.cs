using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Budgeter2.Startup))]
namespace Budgeter2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
