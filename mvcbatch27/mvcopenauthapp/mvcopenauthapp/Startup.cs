using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcopenauthapp.Startup))]
namespace mvcopenauthapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
