using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoomRentalManagementClient.Startup))]
namespace RoomRentalManagementClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
