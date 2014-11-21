using FluentNHibernate.Mapping;
using QMP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMP.Infrastructure.NHibernateMaps.FluentMappings
{ 
    public class DimensionMap : ClassMap<Dimension>
    {
        public DimensionMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);          
            HasMany(x => x.SubAssociations).KeyColumn("SourceId");
            HasMany(x => x.BaseAssociations).KeyColumn("TargetId");
                

        }
    }
}
