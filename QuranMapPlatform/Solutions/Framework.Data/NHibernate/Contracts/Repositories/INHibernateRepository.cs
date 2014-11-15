namespace Framework.Data.NHibernate.Contracts.Repositories
{
    using Framework.Core.Domain.PersistenceSupport;

    /// <summary>
    ///     Extends the basic data repository interface with an interface that supports a number 
    ///     of Data.NHibernate specific methods while avoiding a concrete dependency on the Data.NHibernate
    ///     assembly.  For looser coupling, the "Core" layers of the Framework library and of your 
    ///     application should not have a reference to the Data.NHibernate assembly.
    /// </summary>
    public interface INHibernateRepository<T> : INHibernateRepositoryWithTypedId<T, int>, IRepository<T>
    {
    }
}