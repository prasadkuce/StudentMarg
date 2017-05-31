using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentMarg.Web.Startup))]
namespace StudentMarg.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
