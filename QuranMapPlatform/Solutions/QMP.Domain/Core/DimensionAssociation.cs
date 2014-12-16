using Framework.Core.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QMP.Domain.Core
{
    public class DimensionAssociation : Entity, IAssociation<Dimension>
    {

        public virtual Dimension Source
        {
            get;
            set;
        }

        public virtual Dimension Target
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
