using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TablerosMiSEV.Startup))]
namespace TablerosMiSEV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
