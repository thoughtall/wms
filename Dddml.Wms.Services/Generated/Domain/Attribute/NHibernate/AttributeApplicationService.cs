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
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Attribute.NHibernate
{

	public class AttributeApplicationService : AttributeApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IAttributeStateRepository _stateRepository;

		protected override IAttributeStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IAttributeStateQueryRepository _stateQueryRepository;

		protected override IAttributeStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public AttributeApplicationService(IEventStore eventStore, IAttributeStateRepository stateRepository, IAttributeStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IAttributeAggregate GetAttributeAggregate(IAttributeState state)
		{
			return new AttributeAggregate(state);
		}

	}

}

