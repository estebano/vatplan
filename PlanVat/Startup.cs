using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlanVat.Startup))]
namespace PlanVat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
