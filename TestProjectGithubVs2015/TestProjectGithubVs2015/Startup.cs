using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestProjectGithubVs2015.Startup))]
namespace TestProjectGithubVs2015
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
