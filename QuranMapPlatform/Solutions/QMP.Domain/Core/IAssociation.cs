using Framework.Core.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMP.Domain.Core
{
    public interface IAssociation<T>  where T : Entity
    {
        T Source
        {
            get;
            set;
        }

        T Target
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }
    }
}
