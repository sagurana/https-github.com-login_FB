using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Login_FB.Startup))]
namespace Login_FB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
