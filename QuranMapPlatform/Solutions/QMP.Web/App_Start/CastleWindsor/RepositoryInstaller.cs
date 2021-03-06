namespace QMP.Web.CastleWindsor
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    using Framework.Core.Domain.PersistenceSupport;
    using Framework.Data.NHibernate;
    using Framework.Data.NHibernate.Contracts.Repositories;

    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            AddGenericRepositoriesTo(container);
            AddCustomRepositoriesTo(container);
        }

        private static void AddCustomRepositoriesTo(IWindsorContainer container)
        {
            container.Register(
                Classes.FromAssemblyNamed("QMP.Infrastructure")
                    .BasedOn(typeof(IRepositoryWithTypedId<,>))
                    .WithService.DefaultInterfaces().LifestylePerWebRequest());
        }

        private static void AddGenericRepositoriesTo(IWindsorContainer container)
        {
            container.Register(
                Component.For(typeof(INHibernateRepository<>))
                    .ImplementedBy(typeof(NHibernateRepository<>))
                    .Named("nhibernateRepositoryType")
                    .Forward(typeof(IRepository<>))
                    .LifestylePerWebRequest());
            
            container.Register(
                Component.For(typeof(INHibernateRepositoryWithTypedId<,>))
                    .ImplementedBy(typeof(LinqRepositoryWithTypedId<,>))
                    .Named("nhibernateRepositoryWithTypedId")
                    .Forward(typeof(IRepositoryWithTypedId<,>) , typeof(ILinqRepositoryWithTypedId<,>))
                    .LifestylePerWebRequest());
            
	        container.Register(
                    Component.For(typeof(ILinqRepository<>))
                        .ImplementedBy(typeof(LinqRepository<>))
                        .Named("nhibernateLinqRepositoryType")
                        .LifestylePerWebRequest());
            
        }
    }
}
