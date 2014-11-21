using Framework.Core.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMP.Domain.Core
{
    public interface IHasAssociation<T> where T :Entity
    {
        IList<T> SubAssociations
        {
            get;
            set;
        }
        IList<T> BaseAssociations
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
