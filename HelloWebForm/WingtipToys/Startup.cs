using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WingtipToys.StartupOwin))]

namespace WingtipToys
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
