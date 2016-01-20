using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MauricePOS.Startup))]
namespace MauricePOS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
