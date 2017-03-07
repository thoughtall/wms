﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Attribute.NHibernate
{

	public class NHibernateAttributeValueStateEventDao : IAttributeValueStateEventDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

		public NHibernateAttributeValueStateEventDao ()
		{
		}

		public void Save(IAttributeValueStateEvent stateEvent)
		{
			CurrentSession.Save(stateEvent);
            var saveable = stateEvent as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }

        [Transaction(ReadOnly = true)]
        public IEnumerable<IAttributeValueStateEvent> FindByAttributeStateEventId(AttributeStateEventId attributeStateEventId)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeValueStateEventBase>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("StateEventId.AttributeId", attributeStateEventId.AttributeId))
                .Add(Restrictions.Eq("StateEventId.AttributeVersion", attributeStateEventId.Version))
                ;

            return criteria.Add(partIdCondition).List<AttributeValueStateEventBase>();
        }

	}
}

