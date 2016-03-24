using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnimeGETCodeLouisvilleProject.Startup))]
namespace AnimeGETCodeLouisvilleProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
