namespace Framework.Data.NHibernate.FluentNHibernate
{
    using System;

    using global::FluentNHibernate.Automapping;

    public interface IAutoPersistenceModelGenerator
    {
        AutoPersistenceModel Generate();
    }
}