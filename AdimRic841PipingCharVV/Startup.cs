using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdimRic841PipingCharVV.Startup))]
namespace AdimRic841PipingCharVV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
