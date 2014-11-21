namespace QMP.Infrastructure.NHibernateMaps.Conventions
{
    #region Using Directives

    using FluentNHibernate.Conventions;

    #endregion

    public class HasManyConvention : IHasManyConvention
    {
        public void Apply(FluentNHibernate.Conventions.Instances.IOneToManyCollectionInstance instance)
        {
            instance.Key.Column(instance.EntityType.Name + "Id");
            //instance.Key.ForeignKey(
            //string.Format(
            //   "[FK_{0}.{1}_{2}.{3}]",
            //   instance.EntityType.Name,
            //   instance.Key.,
            //   instance.Relationship.Class.Name,
            //   instance.StringIdentifierForModel));
            instance.Cascade.AllDeleteOrphan();
            instance.Inverse();
            instance.AsBag();
       
        }
    }
}