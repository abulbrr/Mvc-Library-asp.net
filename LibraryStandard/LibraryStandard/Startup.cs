using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryStandard.Startup))]
namespace LibraryStandard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
