using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using QMP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMP.Infrastructure.NHibernateMaps.AutoMappingOverride
{
    public class MyEntity1MappingOverride
  : IAutoMappingOverride<MyEntity1>
    {
        public void Override(AutoMapping<MyEntity1> mapping)
        {
        }
    }
}
