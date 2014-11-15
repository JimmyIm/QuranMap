namespace Framework.Core.Domain.PersistenceSupport
{
    public interface ILinqRepository<T> : ILinqRepositoryWithTypedId<T, int>
    {
    }
}