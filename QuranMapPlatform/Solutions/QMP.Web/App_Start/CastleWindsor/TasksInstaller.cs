namespace QMP.Web.CastleWindsor
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    public class TasksInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromAssemblyNamed("QMP.Tasks")
                    .Pick().Unless(t => t.Namespace.EndsWith("Handlers"))
                    .WithService.DefaultInterfaces()
                    .Configure(c => c.LifestylePerWebRequest())
                );
        }
    }
}