using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Code_First_Artist.Startup))]
namespace Code_First_Artist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
