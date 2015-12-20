using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QK.QuartzManage.Startup))]
namespace QK.QuartzManage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
