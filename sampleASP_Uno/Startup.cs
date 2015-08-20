using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sampleASP_Uno.Startup))]
namespace sampleASP_Uno
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
