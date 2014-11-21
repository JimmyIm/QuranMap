using FluentNHibernate.Mapping;
using QMP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMP.Infrastructure.NHibernateMaps.FluentMappings
{
    public class FactMap : ClassMap<Fact>
    {
        public FactMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Value).Not.Nullable();  
            References(x => x.Dimension);
            References(x => x.ValueType);
            HasMany(x => x.SubAssociations).KeyColumn("SourceId");
            HasMany(x => x.BaseAssociations).KeyColumn("TargetId");
                

        }
    }
  
}
