using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_TEST.Startup))]
namespace mvc_TEST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
