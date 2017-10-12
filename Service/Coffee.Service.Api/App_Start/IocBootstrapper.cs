using Castle.Windsor;
using Nancy.Bootstrappers.Windsor;

namespace Coffee.Service.Api.App_Start
{
    public class IocBootstrapper : WindsorNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(IWindsorContainer container)
        {
            container = new WindsorContainer();
            //Register components
        }
    }
}
