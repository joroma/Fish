using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fish.Startup))]
namespace Fish
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
