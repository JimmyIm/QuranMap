namespace QMP.Tests
{
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;

    using CommonServiceLocator.WindsorAdapter;
    using Microsoft.Practices.ServiceLocation;
    using Framework.Core.Domain.PersistenceSupport;
    using Framework.Data.NHibernate;
    using Castle.Windsor.Installer;
    using Framework.Core.Domain.Events;
    using Castle.MicroKernel.SubSystems.Configuration;

    public class ServiceLocatorInitializer
    {
        public static void Init()
        {
            IWindsorContainer container = new WindsorContainer();

            container.Register(
                    Component
                        .For(typeof(IEntityDuplicateChecker))
                        .ImplementedBy(typeof(EntityDuplicateChecker))
                        .Named("entityDuplicateChecker"));

            container.Register(
                    Component
                        .For(typeof(ISessionFactoryKeyProvider))
                        .ImplementedBy(typeof(DefaultSessionFactoryKeyProvider))
                        .Named("sessionFactoryKeyProvider"));
            container.Install(FromAssembly.This());
            ServiceLocator.SetLocatorProvider(() => new WindsorServiceLocator(container));


       

           
        }
    }
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
