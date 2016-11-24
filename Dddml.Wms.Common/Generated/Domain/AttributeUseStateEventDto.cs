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

	public abstract class AttributeUseStateEventDtoBase : IStateEventDto, IAttributeUseStateCreated, IAttributeUseStateMergePatched, IAttributeUseStateRemoved
	{

        private AttributeUseStateEventIdDto _stateEventId;

		protected internal virtual AttributeUseStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new AttributeUseStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string AttributeId
        {
            get { return StateEventId.AttributeId; }
            set { StateEventId.AttributeId = value; }
        }

		public virtual int? SequenceNumber { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		AttributeUseStateEventId IGlobalIdentity<AttributeUseStateEventId>.GlobalId {
			get {
				return this.StateEventId.ToAttributeUseStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeUseStateEvent.ReadOnly
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

		public virtual long Version { get; set; }

		public virtual bool? IsPropertySequenceNumberRemoved { get; set; }

        bool IAttributeUseStateMergePatched.IsPropertySequenceNumberRemoved
        {
            get 
            {
                var b = this.IsPropertySequenceNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySequenceNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IAttributeUseStateMergePatched.IsPropertyActiveRemoved
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


        AttributeUseStateEventId IAttributeUseStateEvent.StateEventId
        {
            get { return this.StateEventId.ToAttributeUseStateEventId(); }
        }

        protected AttributeUseStateEventDtoBase()
        {
        }

        protected AttributeUseStateEventDtoBase(AttributeUseStateEventIdDto stateEventId)
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


    public class AttributeUseStateCreatedOrMergePatchedOrRemovedDto : AttributeUseStateEventDtoBase
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



	public class AttributeUseStateCreatedDto : AttributeUseStateCreatedOrMergePatchedOrRemovedDto
	{
		public AttributeUseStateCreatedDto()
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


	public class AttributeUseStateMergePatchedDto : AttributeUseStateCreatedOrMergePatchedOrRemovedDto
	{
		public AttributeUseStateMergePatchedDto()
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


	public class AttributeUseStateRemovedDto : AttributeUseStateCreatedOrMergePatchedOrRemovedDto
	{
		public AttributeUseStateRemovedDto()
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
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }

	}


    public partial class AttributeUseStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IAttributeUseStateCreated>, IEnumerable<IAttributeUseStateMergePatched>, IEnumerable<IAttributeUseStateRemoved>
    {
        private List<AttributeUseStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<AttributeUseStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual AttributeUseStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<AttributeUseStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeUseStateCreated> IEnumerable<IAttributeUseStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeUseStateMergePatched> IEnumerable<IAttributeUseStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeUseStateRemoved> IEnumerable<IAttributeUseStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddAttributeUseEvent(IAttributeUseStateCreated e)
        {
            _innerStateEvents.Add((AttributeUseStateCreatedDto)e);
        }

        public void AddAttributeUseEvent(IAttributeUseStateEvent e)
        {
            _innerStateEvents.Add((AttributeUseStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddAttributeUseEvent(IAttributeUseStateRemoved e)
        {
            _innerStateEvents.Add((AttributeUseStateRemovedDto)e);
        }

    }


}

