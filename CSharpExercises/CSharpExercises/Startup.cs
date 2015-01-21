using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharpExercises.Startup))]
namespace CSharpExercises
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
