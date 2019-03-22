using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_controller.Startup))]
namespace mvc_controller
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
