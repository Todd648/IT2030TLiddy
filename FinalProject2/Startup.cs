using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalProject2.Startup))]
namespace FinalProject2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
