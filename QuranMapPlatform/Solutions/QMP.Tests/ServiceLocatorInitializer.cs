namespace QMP.Tests
{
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;

    using CommonServiceLocator.WindsorAdapter;
    using Microsoft.Practices.ServiceLocation;
    using Framework.Core.Domain.PersistenceSupport;
    using Framework.Data.NHibernate;

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

            ServiceLocator.SetLocatorProvider(() => new WindsorServiceLocator(container));
        }
    }
}
