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
    public partial class AttributeValueMvoAggregate : AggregateBase, IAttributeValueMvoAggregate
    {

        readonly IAttributeValueMvoState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IAttributeValueMvoState State
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

        AttributeValueId IGlobalIdentity<AttributeValueId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public AttributeValueMvoAggregate(IAttributeValueMvoState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IAttributeValueMvoStateProperties)_state).AttributeVersion == AttributeValueMvoState.VersionZero)
            {
                if (IsCommandCreate((IAttributeValueMvoCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IAttributeValueMvoCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IAttributeValueMvoCommand c)
        {
            return c.AttributeVersion == AttributeValueMvoState.VersionZero;
        }

        protected virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateAttributeValueMvo c)
        {
            IAttributeValueMvoStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchAttributeValueMvo c)
        {
            IAttributeValueMvoStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteAttributeValueMvo c)
        {
            IAttributeValueMvoStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IAttributeValueMvoStateCreated Map(ICreateAttributeValueMvo c)
        {
			var stateEventId = new AttributeValueMvoStateEventId(c.AttributeValueId, c.AttributeVersion);
            IAttributeValueMvoStateCreated e = NewAttributeValueMvoStateCreated(stateEventId);
		
            e.Name = c.Name;
            e.Description = c.Description;
            e.ReferenceId = c.ReferenceId;
            e.Version = c.Version;
            e.Active = c.Active;
            e.AttributeName = c.AttributeName;
            e.AttributeOrganizationId = c.AttributeOrganizationId;
            e.AttributeDescription = c.AttributeDescription;
            e.AttributeIsMandatory = c.AttributeIsMandatory;
            e.AttributeIsInstanceAttribute = c.AttributeIsInstanceAttribute;
            e.AttributeAttributeValueType = c.AttributeAttributeValueType;
            e.AttributeAttributeValueLength = c.AttributeAttributeValueLength;
            e.AttributeIsList = c.AttributeIsList;
            e.AttributeFieldName = c.AttributeFieldName;
            e.AttributeReferenceId = c.AttributeReferenceId;
            e.AttributeCreatedBy = c.AttributeCreatedBy;
            e.AttributeCreatedAt = c.AttributeCreatedAt;
            e.AttributeUpdatedBy = c.AttributeUpdatedBy;
            e.AttributeUpdatedAt = c.AttributeUpdatedAt;
            e.AttributeActive = c.AttributeActive;
            e.AttributeDeleted = c.AttributeDeleted;
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var attributeVersion = c.AttributeVersion;


            return e;
        }

        protected virtual IAttributeValueMvoStateMergePatched Map(IMergePatchAttributeValueMvo c)
        {
			var stateEventId = new AttributeValueMvoStateEventId(c.AttributeValueId, c.AttributeVersion);
            IAttributeValueMvoStateMergePatched e = NewAttributeValueMvoStateMergePatched(stateEventId);

            e.Name = c.Name;
            e.Description = c.Description;
            e.ReferenceId = c.ReferenceId;
            e.Version = c.Version;
            e.Active = c.Active;
            e.AttributeName = c.AttributeName;
            e.AttributeOrganizationId = c.AttributeOrganizationId;
            e.AttributeDescription = c.AttributeDescription;
            e.AttributeIsMandatory = c.AttributeIsMandatory;
            e.AttributeIsInstanceAttribute = c.AttributeIsInstanceAttribute;
            e.AttributeAttributeValueType = c.AttributeAttributeValueType;
            e.AttributeAttributeValueLength = c.AttributeAttributeValueLength;
            e.AttributeIsList = c.AttributeIsList;
            e.AttributeFieldName = c.AttributeFieldName;
            e.AttributeReferenceId = c.AttributeReferenceId;
            e.AttributeCreatedBy = c.AttributeCreatedBy;
            e.AttributeCreatedAt = c.AttributeCreatedAt;
            e.AttributeUpdatedBy = c.AttributeUpdatedBy;
            e.AttributeUpdatedAt = c.AttributeUpdatedAt;
            e.AttributeActive = c.AttributeActive;
            e.AttributeDeleted = c.AttributeDeleted;
            e.IsPropertyNameRemoved = c.IsPropertyNameRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyReferenceIdRemoved = c.IsPropertyReferenceIdRemoved;
            e.IsPropertyVersionRemoved = c.IsPropertyVersionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;
            e.IsPropertyAttributeNameRemoved = c.IsPropertyAttributeNameRemoved;
            e.IsPropertyAttributeOrganizationIdRemoved = c.IsPropertyAttributeOrganizationIdRemoved;
            e.IsPropertyAttributeDescriptionRemoved = c.IsPropertyAttributeDescriptionRemoved;
            e.IsPropertyAttributeIsMandatoryRemoved = c.IsPropertyAttributeIsMandatoryRemoved;
            e.IsPropertyAttributeIsInstanceAttributeRemoved = c.IsPropertyAttributeIsInstanceAttributeRemoved;
            e.IsPropertyAttributeAttributeValueTypeRemoved = c.IsPropertyAttributeAttributeValueTypeRemoved;
            e.IsPropertyAttributeAttributeValueLengthRemoved = c.IsPropertyAttributeAttributeValueLengthRemoved;
            e.IsPropertyAttributeIsListRemoved = c.IsPropertyAttributeIsListRemoved;
            e.IsPropertyAttributeFieldNameRemoved = c.IsPropertyAttributeFieldNameRemoved;
            e.IsPropertyAttributeReferenceIdRemoved = c.IsPropertyAttributeReferenceIdRemoved;
            e.IsPropertyAttributeCreatedByRemoved = c.IsPropertyAttributeCreatedByRemoved;
            e.IsPropertyAttributeCreatedAtRemoved = c.IsPropertyAttributeCreatedAtRemoved;
            e.IsPropertyAttributeUpdatedByRemoved = c.IsPropertyAttributeUpdatedByRemoved;
            e.IsPropertyAttributeUpdatedAtRemoved = c.IsPropertyAttributeUpdatedAtRemoved;
            e.IsPropertyAttributeActiveRemoved = c.IsPropertyAttributeActiveRemoved;
            e.IsPropertyAttributeDeletedRemoved = c.IsPropertyAttributeDeletedRemoved;

            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var attributeVersion = c.AttributeVersion;


            return e;
        }

        protected virtual IAttributeValueMvoStateDeleted Map(IDeleteAttributeValueMvo c)
        {
			var stateEventId = new AttributeValueMvoStateEventId(c.AttributeValueId, c.AttributeVersion);
            IAttributeValueMvoStateDeleted e = NewAttributeValueMvoStateDeleted(stateEventId);
			
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;


            return e;
        }

        private void ThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (!Object.Equals(innerIdValue, outerIdValue))
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected AttributeValueMvoStateCreated NewAttributeValueMvoStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new AttributeValueMvoStateEventId(_state.AttributeValueId, ((IAttributeValueMvoStateProperties)_state).AttributeVersion);
            var e = NewAttributeValueMvoStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected AttributeValueMvoStateMergePatched NewAttributeValueMvoStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new AttributeValueMvoStateEventId(_state.AttributeValueId, ((IAttributeValueMvoStateProperties)_state).AttributeVersion);
            var e = NewAttributeValueMvoStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected AttributeValueMvoStateDeleted NewAttributeValueMvoStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new AttributeValueMvoStateEventId(_state.AttributeValueId, ((IAttributeValueMvoStateProperties)_state).AttributeVersion);
            var e = NewAttributeValueMvoStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private AttributeValueMvoStateCreated NewAttributeValueMvoStateCreated(AttributeValueMvoStateEventId stateEventId)
		{
			return new AttributeValueMvoStateCreated(stateEventId);			
		}

        private AttributeValueMvoStateMergePatched NewAttributeValueMvoStateMergePatched(AttributeValueMvoStateEventId stateEventId)
		{
			return new AttributeValueMvoStateMergePatched(stateEventId);
		}

        private AttributeValueMvoStateDeleted NewAttributeValueMvoStateDeleted(AttributeValueMvoStateEventId stateEventId)
		{
			return new AttributeValueMvoStateDeleted(stateEventId);
		}

    }

}

