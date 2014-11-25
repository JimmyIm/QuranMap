namespace QMP.Web.CastleWindsor
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    public class QueryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromAssemblyNamed("QMP.Web")
                    .InNamespace("QMP.Web.Controllers.Queries", true)
                    .WithService.DefaultInterfaces()
                    .LifestylePerWebRequest());
        }
    }
}