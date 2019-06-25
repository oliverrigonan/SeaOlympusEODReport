using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeaOlympusEODReport.Startup))]
namespace SeaOlympusEODReport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
