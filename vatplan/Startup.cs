using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vatplan.Startup))]
namespace vatplan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
