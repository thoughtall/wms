﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationStructureDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrganizationStructure;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.OrganizationStructure.NHibernate
{

	public class NHibernateOrganizationStructureEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new OrganizationStructureStateEventId((OrganizationStructureId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(OrganizationStructureStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(OrganizationStructureStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            OrganizationStructureId idObj = (OrganizationStructureId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<OrganizationStructureStateEventBase>();
            criteria.Add(Restrictions.Eq("StateEventId.IdOrganizationStructureTypeId", idObj.OrganizationStructureTypeId));
            criteria.Add(Restrictions.Eq("StateEventId.IdParentId", idObj.ParentId));
            criteria.Add(Restrictions.Eq("StateEventId.IdSubsidiaryId", idObj.SubsidiaryId));
            criteria.Add(Restrictions.Le("StateEventId.Version", version));
            criteria.AddOrder(Order.Asc("StateEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (OrganizationStructureStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((OrganizationStructureStateEventBase)es.Last()).StateEventId.Version : default(long),
                Events = es
            };
        }

	}

}

