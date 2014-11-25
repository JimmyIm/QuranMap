using Framework.Core.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QMP.Domain.Core
{
    public class FactAssociation :Entity//, IAssociation<Fact>
    {
        public virtual DimensionAssociation RelationType
        {
            get;
            set;
        }
        public virtual Fact Source
        {
            get;
            set;
        }

        public virtual Fact Target
        {
            get;
            set;
        }

        public virtual string Name
        {
            get;
            set;
        }
    }
}
