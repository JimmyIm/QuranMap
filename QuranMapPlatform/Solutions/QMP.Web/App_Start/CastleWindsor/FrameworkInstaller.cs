namespace QMP.Web.CastleWindsor
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    using Framework.Core.Domain.Commands;
    using Framework.Core.Domain.PersistenceSupport;
    using Framework.Data.NHibernate;

    public class FrameworkInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For(typeof(IEntityDuplicateChecker))
                    .ImplementedBy(typeof(EntityDuplicateChecker))
                    .Named("entityDuplicateChecker"));

            container.Register(
                Component.For(typeof(ISessionFactoryKeyProvider))
                    .ImplementedBy(typeof(DefaultSessionFactoryKeyProvider))
                    .Named("sessionFactoryKeyProvider"));

            container.Register(
                Component.For(typeof(ICommandProcessor))
                    .ImplementedBy(typeof(CommandProcessor))
                    .Named("commandProcessor"));
        }
    }
}