﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Attribute
{
	public abstract partial class AttributeApplicationServiceBase : IAttributeApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IAttributeStateRepository StateRepository { get; }

		protected abstract IAttributeStateQueryRepository StateQueryRepository { get; }

		protected AttributeApplicationServiceBase()
		{
		}

		protected virtual void Update(IAttributeCommand c, Action<IAttributeAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetAttributeAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IAttributeAggregate aggregate, IAttributeState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IAttributeStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
        }

        public virtual void Initialize(IAttributeStateCreated stateCreated)
        {
            var aggregateId = stateCreated.StateEventId.AttributeId;
            var state = new AttributeState();
            state.AttributeId = aggregateId;
            var aggregate = (AttributeAggregate)GetAttributeAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IAttributeCommand command, IEventStoreAggregateId eventStoreAggregateId, IAttributeState state)
		{
			bool repeated = false;
			if (((IAttributeStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IAttributeStateEvent), eventStoreAggregateId, command.AggregateVersion);
				if (lastEvent != null && lastEvent.CommandId == command.CommandId)
				{
					repeated = true;
				}
			}
			return repeated;
		}


		public virtual void Execute(object command)
		{
			((dynamic)this).When((dynamic)command);
		}


		public virtual void When(ICreateAttribute c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchAttribute c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteAttribute c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IAttributeState Get(string attributeId)
        {
            var state = StateRepository.Get(attributeId, true);
            return state;
        }

        public virtual IEnumerable<IAttributeState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IAttributeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IAttributeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IAttributeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var states = StateQueryRepository.GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
			return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
            return StateQueryRepository.GetCount(filter);
		}

        public virtual long GetCount(ICriterion filter)
		{
            return StateQueryRepository.GetCount(filter);
		}

	    public virtual IAttributeStateEvent GetStateEvent(string attributeId, long version)
        {
            var e = (IAttributeStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(attributeId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(attributeId, 0);
            }
            return e;
        }

        public virtual IAttributeState GetHistoryState(string attributeId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IAttributeStateEvent), ToEventStoreAggregateId(attributeId), version - 1);
            return new AttributeState(eventStream.Events);
        }

        public virtual IAttributeValueState GetAttributeValue(string attributeId, string value)
        {
            return StateQueryRepository.GetAttributeValue(attributeId, value);
        }


		public abstract IAttributeAggregate GetAttributeAggregate(IAttributeState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId);


	}

}

