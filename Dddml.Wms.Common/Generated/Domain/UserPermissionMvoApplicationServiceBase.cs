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
	public abstract partial class UserPermissionMvoApplicationServiceBase : IUserPermissionMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IUserPermissionMvoStateRepository StateRepository { get; }

		protected UserPermissionMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IUserPermissionMvoCommand c, Action<IUserPermissionMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId);
			var aggregate = GetUserPermissionMvoAggregate(state);

			var eventStoreAaggregateId = ToEventStoreAaggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAaggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			EventStore.AppendEvents(ToEventStoreAaggregateId(aggregateId), ((IUserPermissionMvoStateProperties)state).UserVersion, aggregate.Changes, () => { StateRepository.Save(state); });
		}


		protected bool IsRepeatedCommand(IUserPermissionMvoCommand command, IEventStoreAggregateId eventStoreAaggregateId, IUserPermissionMvoState state)
		{
			bool repeated = false;
			if (((IUserPermissionMvoStateProperties)state).UserVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IUserPermissionMvoStateEvent), eventStoreAaggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateUserPermissionMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchUserPermissionMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteUserPermissionMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IUserPermissionMvoState Get(UserPermissionId userPermissionId)
        {
            var state = StateRepository.Get(userPermissionId);

            if (state != null && state.IsUnsaved) { state = null; }

            return state;
        }

        public virtual IEnumerable<IUserPermissionMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserPermissionMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserPermissionMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserPermissionMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IUserPermissionMvoStateEvent GetStateEvent(UserPermissionId userPermissionId, long version)
        {
            var e = (IUserPermissionMvoStateEvent)EventStore.GetStateEvent(ToEventStoreAaggregateId(userPermissionId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            return e;
        }


		public abstract IUserPermissionMvoAggregate GetUserPermissionMvoAggregate(IUserPermissionMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAaggregateId(UserPermissionId aggregateId);


	}

}

