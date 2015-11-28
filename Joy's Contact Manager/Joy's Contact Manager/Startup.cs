using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Joy_Contact_Manager.Startup))]
namespace Joy_Contact_Manager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
