using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoListSystem.Startup))]
namespace ToDoListSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
