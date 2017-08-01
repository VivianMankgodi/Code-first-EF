using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.Books.Startup))]
namespace Web.Books
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
