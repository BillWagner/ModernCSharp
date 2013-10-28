using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TemplateCreated.Startup))]
namespace TemplateCreated
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
