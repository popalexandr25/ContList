using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContList.Startup))]
namespace ContList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
