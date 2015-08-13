using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BMIBase.Startup))]
namespace BMIBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
