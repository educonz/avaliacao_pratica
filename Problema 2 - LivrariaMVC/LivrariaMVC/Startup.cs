using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LivrariaMVC.Startup))]
namespace LivrariaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
