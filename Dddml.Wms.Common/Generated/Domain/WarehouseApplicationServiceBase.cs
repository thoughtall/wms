﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain
{
	public abstract partial class WarehouseApplicationServiceBase : IWarehouseApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IWarehouseStateRepository StateRepository { get; }

		protected WarehouseApplicationServiceBase()
		{
		}

		protected virtual void Update(IWarehouseCommand c, Action<IWarehouseAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId);
			var aggregate = GetWarehouseAggregate(state);

			var eventStoreAaggregateId = ToEventStoreAaggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAaggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			EventStore.AppendEvents(ToEventStoreAaggregateId(aggregateId), ((IWarehouseStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
		}


		protected bool IsRepeatedCommand(IWarehouseCommand command, IEventStoreAggregateId eventStoreAaggregateId, IWarehouseState state)
		{
			bool repeated = false;
			if (((IWarehouseStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IWarehouseStateEvent), eventStoreAaggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateWarehouse c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchWarehouse c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteWarehouse c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IWarehouseState Get(string warehouseId)
        {
            var state = StateRepository.Get(warehouseId);

            if (state != null && state.IsUnsaved) { state = null; }

            return state;
        }

        public virtual IEnumerable<IWarehouseState> GetAll(int firstResult, int maxResults)
		{
            var states = StateRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IWarehouseState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IWarehouseState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IWarehouseState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var states = StateRepository.GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
			return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
            return StateRepository.GetCount(filter);
		}

        public virtual long GetCount(ICriterion filter)
		{
            return StateRepository.GetCount(filter);
		}

	    public virtual IWarehouseStateEvent GetStateEvent(string warehouseId, long version)
        {
            var e = (IWarehouseStateEvent)EventStore.GetStateEvent(ToEventStoreAaggregateId(warehouseId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            return e;
        }


		public abstract IWarehouseAggregate GetWarehouseAggregate(IWarehouseState state);

		public abstract IEventStoreAggregateId ToEventStoreAaggregateId(string aggregateId);


	}

}

