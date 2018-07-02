using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArtsCenterEventCalendar.Startup))]
namespace ArtsCenterEventCalendar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
