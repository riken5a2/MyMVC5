using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMVC5.Startup))]
namespace MyMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
