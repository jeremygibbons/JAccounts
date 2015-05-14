using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JAccounts.Startup))]
namespace JAccounts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
