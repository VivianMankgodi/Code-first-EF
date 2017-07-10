using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppArtist.Startup))]
namespace WebAppArtist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
