using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VictoriasWardrobe.Startup))]
namespace VictoriasWardrobe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
