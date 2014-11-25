using Framework.Core.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMP.Domain.Core
{
    public class FactValueType : Entity
    {
        public virtual string Name
        {
            get;
            set;
        }
        public virtual string Constant
        {
            get;
            set;
        }
    }
}
