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

	public abstract class AttributeSetStateEventDtoBase : IStateEventDto, IAttributeSetStateCreated, IAttributeSetStateMergePatched, IAttributeSetStateDeleted
	{

        private AttributeSetStateEventIdDto _stateEventId;

		protected internal virtual AttributeSetStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new AttributeSetStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string AttributeSetId
        {
            get { return StateEventId.AttributeSetId; }
            set { StateEventId.AttributeSetId = value; }
        }

        public virtual long Version
        {
            get { return StateEventId.Version; }
            set { StateEventId.Version = value; }
        }

		public virtual string Name { get; set; }

		public virtual string OrganizationId { get; set; }

		public virtual string Description { get; set; }

		public virtual string SerialNumberAttributeId { get; set; }

		public virtual string LotAttributeId { get; set; }

		public virtual string ReferenceId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		AttributeSetStateEventId IGlobalIdentity<AttributeSetStateEventId>.GlobalId {
			get {
				return this.StateEventId.ToAttributeSetStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeSetStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }

		public virtual bool? IsPropertyNameRemoved { get; set; }

        bool IAttributeSetStateMergePatched.IsPropertyNameRemoved
        {
            get 
            {
                var b = this.IsPropertyNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrganizationIdRemoved { get; set; }

        bool IAttributeSetStateMergePatched.IsPropertyOrganizationIdRemoved
        {
            get 
            {
                var b = this.IsPropertyOrganizationIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOrganizationIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IAttributeSetStateMergePatched.IsPropertyDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertySerialNumberAttributeIdRemoved { get; set; }

        bool IAttributeSetStateMergePatched.IsPropertySerialNumberAttributeIdRemoved
        {
            get 
            {
                var b = this.IsPropertySerialNumberAttributeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySerialNumberAttributeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyLotAttributeIdRemoved { get; set; }

        bool IAttributeSetStateMergePatched.IsPropertyLotAttributeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyLotAttributeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLotAttributeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyReferenceIdRemoved { get; set; }

        bool IAttributeSetStateMergePatched.IsPropertyReferenceIdRemoved
        {
            get 
            {
                var b = this.IsPropertyReferenceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyReferenceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IAttributeSetStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}


        private AttributeUseStateCreatedOrMergePatchedOrRemovedDtos _attributeUseEvents = new AttributeUseStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual AttributeUseStateCreatedOrMergePatchedOrRemovedDto[] AttributeUseEvents
        {
            get
            {
                return _attributeUseEvents.ToArray();
            }
            set
            {
                _attributeUseEvents.Clear();
                _attributeUseEvents.AddRange(value);
            }
        }



        private AttributeUseStateEventIdDto NewAttributeUseStateEventId(string attributeId)
        {
            var eId = new AttributeUseStateEventIdDto();
            eId.AttributeSetId = this.StateEventId.AttributeSetId;
            eId.AttributeId = attributeId;
            eId.AttributeSetVersion = this.StateEventId.Version;
            return eId;
        }

        public virtual AttributeUseStateCreatedDto NewAttributeUseStateCreated(string attributeId)
        {
            var e = new AttributeUseStateCreatedDto();
            var eId = NewAttributeUseStateEventId(attributeId);
            e.StateEventId = eId;
            return e;
        }

        public virtual AttributeUseStateMergePatchedDto NewAttributeUseStateMergePatched(string attributeId)
        {
            var e = new AttributeUseStateMergePatchedDto();
            var eId = NewAttributeUseStateEventId(attributeId);
            e.StateEventId = eId;
            return e;
        }

        public virtual AttributeUseStateRemovedDto NewAttributeUseStateRemoved(string attributeId)
        {
            var e = new AttributeUseStateRemovedDto();
            var eId = NewAttributeUseStateEventId(attributeId);
            e.StateEventId = eId;
            return e;
        }

        IEnumerable<IAttributeUseStateCreated> IAttributeSetStateCreated.AttributeUseEvents
        {
            get { return this._attributeUseEvents; }
        }

        void IAttributeSetStateCreated.AddAttributeUseEvent(IAttributeUseStateCreated e)
        {
            this._attributeUseEvents.AddAttributeUseEvent(e);
        }

        IAttributeUseStateCreated IAttributeSetStateCreated.NewAttributeUseStateCreated(string attributeId)
        {
            return NewAttributeUseStateCreated(attributeId);
        }

        IEnumerable<IAttributeUseStateEvent> IAttributeSetStateMergePatched.AttributeUseEvents
        {
            get { return this._attributeUseEvents; }
        }

        void IAttributeSetStateMergePatched.AddAttributeUseEvent(IAttributeUseStateEvent e)
        {
            this._attributeUseEvents.AddAttributeUseEvent(e);
        }

        IAttributeUseStateCreated IAttributeSetStateMergePatched.NewAttributeUseStateCreated(string attributeId)
        {
            return NewAttributeUseStateCreated(attributeId);
        }

        IAttributeUseStateMergePatched IAttributeSetStateMergePatched.NewAttributeUseStateMergePatched(string attributeId)
        {
            return NewAttributeUseStateMergePatched(attributeId);
        }

        IAttributeUseStateRemoved IAttributeSetStateMergePatched.NewAttributeUseStateRemoved(string attributeId)
        {
            return NewAttributeUseStateRemoved(attributeId);
        }


        IEnumerable<IAttributeUseStateRemoved> IAttributeSetStateDeleted.AttributeUseEvents
        {
            get { return this._attributeUseEvents; }
        }

        void IAttributeSetStateDeleted.AddAttributeUseEvent(IAttributeUseStateRemoved e)
        {
            this._attributeUseEvents.AddAttributeUseEvent(e);
        }

        IAttributeUseStateRemoved IAttributeSetStateDeleted.NewAttributeUseStateRemoved(string attributeId)
        {
            return NewAttributeUseStateRemoved(attributeId);
        }



        AttributeSetStateEventId IAttributeSetStateEvent.StateEventId
        {
            get { return this.StateEventId.ToAttributeSetStateEventId(); }
        }

        protected AttributeSetStateEventDtoBase()
        {
        }

        protected AttributeSetStateEventDtoBase(AttributeSetStateEventIdDto stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class AttributeSetStateCreatedOrMergePatchedOrDeletedDto : AttributeSetStateEventDtoBase
    {
        private string _stateEventType;

        public virtual string StateEventType
        {
            get { return _stateEventType; }
            set { _stateEventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._stateEventType;
        }

    }



	public class AttributeSetStateCreatedDto : AttributeSetStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeSetStateCreatedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class AttributeSetStateMergePatchedDto : AttributeSetStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeSetStateMergePatchedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class AttributeSetStateDeletedDto : AttributeSetStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeSetStateDeletedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class AttributeSetStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IAttributeSetStateCreated>, IEnumerable<IAttributeSetStateMergePatched>, IEnumerable<IAttributeSetStateDeleted>
    {
        private List<AttributeSetStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<AttributeSetStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual AttributeSetStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<AttributeSetStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeSetStateCreated> IEnumerable<IAttributeSetStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeSetStateMergePatched> IEnumerable<IAttributeSetStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeSetStateDeleted> IEnumerable<IAttributeSetStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddAttributeSetEvent(IAttributeSetStateCreated e)
        {
            _innerStateEvents.Add((AttributeSetStateCreatedDto)e);
        }

        public void AddAttributeSetEvent(IAttributeSetStateEvent e)
        {
            _innerStateEvents.Add((AttributeSetStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddAttributeSetEvent(IAttributeSetStateDeleted e)
        {
            _innerStateEvents.Add((AttributeSetStateDeletedDto)e);
        }

    }


}

