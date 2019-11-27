using Microsoft.Owin;
using Owin;
using System.Data.Entity;
using FinalProject.Models;

[assembly: OwinStartupAttribute(typeof(FinalProject.Startup))]
namespace FinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
