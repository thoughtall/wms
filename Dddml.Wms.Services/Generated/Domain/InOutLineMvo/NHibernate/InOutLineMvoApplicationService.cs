﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutLineMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using NodaMoney;
using Dddml.Wms.Domain.InOut;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.InOutLineMvo.NHibernate
{

	public class InOutLineMvoApplicationService : InOutLineMvoApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IInOutLineMvoStateRepository _stateRepository;

		protected override IInOutLineMvoStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IInOutLineMvoStateQueryRepository _stateQueryRepository;

		protected override IInOutLineMvoStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public InOutLineMvoApplicationService(IEventStore eventStore, IInOutLineMvoStateRepository stateRepository, IInOutLineMvoStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(InOutLineId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IInOutLineMvoAggregate GetInOutLineMvoAggregate(IInOutLineMvoState state)
		{
			return new InOutLineMvoAggregate(state);
		}

	}

}

