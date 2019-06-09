using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Facebook.Startup))]
namespace Facebook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
