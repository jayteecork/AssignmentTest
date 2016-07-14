using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssignmentTest.Startup))]
namespace AssignmentTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
