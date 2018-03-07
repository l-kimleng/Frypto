using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(Frypto.Startup))]

namespace Frypto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Enable cross domain
            app.UseCors(CorsOptions.AllowAll);
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            ConfigureAuth(app);
        }
    }
}
