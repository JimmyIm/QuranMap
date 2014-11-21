﻿using Framework.Core.Domain.DomainModel;
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace QMP.Domain.Core
{
    public class Fact : Entity, IHasAssociation<FactAssociation>
    {

        public virtual Dimension Dimension
        {
            get;
            set;
        }

        public virtual string Name
        {
            get;
            set;
        }

        public virtual string Value
        {
            get;
            set;
        }
        public virtual ValueType ValueType
        {
            get;
            set;
        }
        public virtual IList<FactAssociation> SubAssociations
        {
            get;
            set;
        }
        public virtual IList<FactAssociation> BaseAssociations
        {
            get;
            set;
        }
    }

}