using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HateCrimeDB.Startup))]
namespace HateCrimeDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
