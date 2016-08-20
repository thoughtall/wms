﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{
    public partial class YearPlanMvoAggregate : AggregateBase, IYearPlanMvoAggregate
    {

        readonly IYearPlanMvoState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IYearPlanMvoState State
        {
            get
            {
                return _state;
            }
        }

        public IList<IEvent> Changes
        {
            get
            {
                return _changes;
            }
        }

        #region IIdentity implementation

        YearPlanId IGlobalIdentity<YearPlanId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public YearPlanMvoAggregate(IYearPlanMvoState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IYearPlanMvoStateProperties)_state).PersonVersion == YearPlanMvoState.VersionZero)
            {
                if (IsCommandCreate((IYearPlanMvoCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IYearPlanMvoCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IYearPlanMvoCommand c)
        {
            return c.PersonVersion == YearPlanMvoState.VersionZero;
        }

        protected virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateYearPlanMvo c)
        {
            IYearPlanMvoStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchYearPlanMvo c)
        {
            IYearPlanMvoStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteYearPlanMvo c)
        {
            IYearPlanMvoStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IYearPlanMvoStateCreated Map(ICreateYearPlanMvo c)
        {
			var stateEventId = new YearPlanMvoStateEventId(c.YearPlanId, c.PersonVersion);
            IYearPlanMvoStateCreated e = NewYearPlanMvoStateCreated(stateEventId);
		
            e.Description = c.Description;
            e.Version = c.Version;
            e.Active = c.Active;
            e.PersonBirthDate = c.PersonBirthDate;
            e.PersonLoves = c.PersonLoves;
            e.PersonCreatedBy = c.PersonCreatedBy;
            e.PersonCreatedAt = c.PersonCreatedAt;
            e.PersonUpdatedBy = c.PersonUpdatedBy;
            e.PersonUpdatedAt = c.PersonUpdatedAt;
            e.PersonActive = c.PersonActive;
            e.PersonDeleted = c.PersonDeleted;
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var personVersion = c.PersonVersion;


            return e;
        }

        protected virtual IYearPlanMvoStateMergePatched Map(IMergePatchYearPlanMvo c)
        {
			var stateEventId = new YearPlanMvoStateEventId(c.YearPlanId, c.PersonVersion);
            IYearPlanMvoStateMergePatched e = NewYearPlanMvoStateMergePatched(stateEventId);

            e.Description = c.Description;
            e.Version = c.Version;
            e.Active = c.Active;
            e.PersonBirthDate = c.PersonBirthDate;
            e.PersonLoves = c.PersonLoves;
            e.PersonCreatedBy = c.PersonCreatedBy;
            e.PersonCreatedAt = c.PersonCreatedAt;
            e.PersonUpdatedBy = c.PersonUpdatedBy;
            e.PersonUpdatedAt = c.PersonUpdatedAt;
            e.PersonActive = c.PersonActive;
            e.PersonDeleted = c.PersonDeleted;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyVersionRemoved = c.IsPropertyVersionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;
            e.IsPropertyPersonBirthDateRemoved = c.IsPropertyPersonBirthDateRemoved;
            e.IsPropertyPersonLovesRemoved = c.IsPropertyPersonLovesRemoved;
            e.IsPropertyPersonCreatedByRemoved = c.IsPropertyPersonCreatedByRemoved;
            e.IsPropertyPersonCreatedAtRemoved = c.IsPropertyPersonCreatedAtRemoved;
            e.IsPropertyPersonUpdatedByRemoved = c.IsPropertyPersonUpdatedByRemoved;
            e.IsPropertyPersonUpdatedAtRemoved = c.IsPropertyPersonUpdatedAtRemoved;
            e.IsPropertyPersonActiveRemoved = c.IsPropertyPersonActiveRemoved;
            e.IsPropertyPersonDeletedRemoved = c.IsPropertyPersonDeletedRemoved;

            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var personVersion = c.PersonVersion;


            return e;
        }

        protected virtual IYearPlanMvoStateDeleted Map(IDeleteYearPlanMvo c)
        {
			var stateEventId = new YearPlanMvoStateEventId(c.YearPlanId, c.PersonVersion);
            IYearPlanMvoStateDeleted e = NewYearPlanMvoStateDeleted(stateEventId);
			
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;


            return e;
        }

        private void SetNullInnerIdOrThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (innerIdValue == null)
            {
                ReflectUtils.SetPropertyValue(innerIdName, innerObject, outerIdValue);
            }
            else if (!Object.Equals(innerIdValue, outerIdValue))
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected YearPlanMvoStateCreated NewYearPlanMvoStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new YearPlanMvoStateEventId(_state.YearPlanId, ((IYearPlanMvoStateProperties)_state).PersonVersion);
            var e = NewYearPlanMvoStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected YearPlanMvoStateMergePatched NewYearPlanMvoStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new YearPlanMvoStateEventId(_state.YearPlanId, ((IYearPlanMvoStateProperties)_state).PersonVersion);
            var e = NewYearPlanMvoStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected YearPlanMvoStateDeleted NewYearPlanMvoStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new YearPlanMvoStateEventId(_state.YearPlanId, ((IYearPlanMvoStateProperties)_state).PersonVersion);
            var e = NewYearPlanMvoStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private YearPlanMvoStateCreated NewYearPlanMvoStateCreated(YearPlanMvoStateEventId stateEventId)
		{
			return new YearPlanMvoStateCreated(stateEventId);			
		}

        private YearPlanMvoStateMergePatched NewYearPlanMvoStateMergePatched(YearPlanMvoStateEventId stateEventId)
		{
			return new YearPlanMvoStateMergePatched(stateEventId);
		}

        private YearPlanMvoStateDeleted NewYearPlanMvoStateDeleted(YearPlanMvoStateEventId stateEventId)
		{
			return new YearPlanMvoStateDeleted(stateEventId);
		}


    }

}
