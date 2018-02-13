using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGit2.Startup))]
namespace TestGit2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
