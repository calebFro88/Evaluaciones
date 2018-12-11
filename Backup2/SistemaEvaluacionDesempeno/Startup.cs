using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaEvaluacionDesempeno.Startup))]
namespace SistemaEvaluacionDesempeno
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
