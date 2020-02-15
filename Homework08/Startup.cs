using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homework08.Startup))]
namespace Homework08
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
