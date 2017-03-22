using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JoesProject.Startup))]
namespace JoesProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
