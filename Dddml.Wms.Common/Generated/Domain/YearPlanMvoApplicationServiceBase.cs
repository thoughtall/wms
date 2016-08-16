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
	public abstract partial class YearPlanMvoApplicationServiceBase : IYearPlanMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IYearPlanMvoStateRepository StateRepository { get; }

		protected YearPlanMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IYearPlanMvoCommand c, Action<IYearPlanMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId);
			var aggregate = GetYearPlanMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			EventStore.AppendEvents(eventStoreAggregateId, ((IYearPlanMvoStateProperties)state).PersonVersion, aggregate.Changes, () => { StateRepository.Save(state); });
		}


		protected bool IsRepeatedCommand(IYearPlanMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IYearPlanMvoState state)
		{
			bool repeated = false;
			if (((IYearPlanMvoStateProperties)state).PersonVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IYearPlanMvoStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateYearPlanMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchYearPlanMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteYearPlanMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IYearPlanMvoState Get(YearPlanId yearPlanId)
        {
            var state = StateRepository.Get(yearPlanId);

            if (state != null && state.IsUnsaved) { state = null; }

            return state;
        }

        public virtual IEnumerable<IYearPlanMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IYearPlanMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IYearPlanMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IYearPlanMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IYearPlanMvoStateEvent GetStateEvent(YearPlanId yearPlanId, long version)
        {
            var e = (IYearPlanMvoStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(yearPlanId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            return e;
        }


		public abstract IYearPlanMvoAggregate GetYearPlanMvoAggregate(IYearPlanMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(YearPlanId aggregateId);


	}

}

