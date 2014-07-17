using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabThurs0717.Startup))]
namespace LabThurs0717
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
