using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testM7.Startup))]
namespace testM7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
