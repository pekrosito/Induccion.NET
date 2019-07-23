using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InduccionNET.Startup))]
namespace InduccionNET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
