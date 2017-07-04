using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SE_Asp_Net_Ajax.Startup))]
namespace SE_Asp_Net_Ajax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
