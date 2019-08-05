using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(g_cloud.Startup))]
namespace g_cloud
{
    public partial class Startup
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
