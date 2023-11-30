using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DesktopApplication.StartupOwin))]

namespace DesktopApplication
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
