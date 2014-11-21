using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMP.Infrastructure.NHibernateMaps.Conventions
{
    public class ReferenceConvention : IReferenceConvention
    {
        public void Apply(IManyToOneInstance instance)
        {
            //instance.ForeignKey(string.Format("FK_{0}_{1}",
            //     instance.EntityType.Name,
            //     instance.Name));
        }
    }
}
 