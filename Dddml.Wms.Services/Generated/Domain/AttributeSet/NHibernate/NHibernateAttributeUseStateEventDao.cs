﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.AttributeSet.NHibernate
{

	public class NHibernateAttributeUseStateEventDao : IAttributeUseStateEventDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

		public NHibernateAttributeUseStateEventDao ()
		{
		}

		public void Save(IAttributeUseStateEvent stateEvent)
		{
			CurrentSession.Save(stateEvent);
            var saveable = stateEvent as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }

        [Transaction(ReadOnly = true)]
        public IEnumerable<IAttributeUseStateEvent> FindByAttributeSetStateEventId(AttributeSetStateEventId attributeSetStateEventId)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeUseStateEventBase>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("StateEventId.AttributeSetId", attributeSetStateEventId.AttributeSetId))
                .Add(Restrictions.Eq("StateEventId.AttributeSetVersion", attributeSetStateEventId.Version))
                ;

            return criteria.Add(partIdCondition).List<AttributeUseStateEventBase>();
        }

	}
}

