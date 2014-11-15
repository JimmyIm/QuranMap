namespace Framework.Core.Domain.PersistenceSupport
{
    using Framework.Core.Domain.DomainModel;

    public interface IEntityDuplicateChecker
    {
        bool DoesDuplicateExistWithTypedIdOf<TId>(IEntityWithTypedId<TId> entity);
    }
}