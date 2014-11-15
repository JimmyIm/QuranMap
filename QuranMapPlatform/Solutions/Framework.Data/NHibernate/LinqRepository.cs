namespace Framework.Data.NHibernate
{
    using Framework.Core.Domain.PersistenceSupport;

    public class LinqRepository<T> : LinqRepositoryWithTypedId<T, int>, ILinqRepository<T>
    {
    }
}