using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SPDataTables.Startup))]
namespace SPDataTables
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
