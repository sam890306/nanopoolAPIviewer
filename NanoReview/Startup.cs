using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NanoReview.Startup))]
namespace NanoReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
