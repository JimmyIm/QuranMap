namespace Framework.Data.NHibernate.NHibernateValidator
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Framework.Core.Domain;
    using Framework.Core.Domain.DomainModel;
    using Framework.Core.Domain.PersistenceSupport;

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class HasUniqueDomainSignatureWithGuidIdAttribute : ValidationAttribute
    {
        public HasUniqueDomainSignatureWithGuidIdAttribute()
            : base("Provided values matched an existing, duplicate entity")
        {
        }

        public override bool IsValid(object value)
        {
            var entityToValidate = value as IEntityWithTypedId<Guid>;
            Check.Require(
                entityToValidate != null,
                "This validator must be used at the class level of an IDomainWithTypedId<Guid>. The type you provided was " + value.GetType());

            var duplicateChecker = SafeServiceLocator<IEntityDuplicateChecker>.GetService();
            return !duplicateChecker.DoesDuplicateExistWithTypedIdOf(entityToValidate);
        }
    }
}