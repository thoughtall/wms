﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeValueMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeValueMvo;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.AttributeValueMvo
{

	public abstract class AttributeValueMvoStateEventDtoBase : IStateEventDto, IAttributeValueMvoStateCreated, IAttributeValueMvoStateMergePatched, IAttributeValueMvoStateDeleted
	{

        private AttributeValueMvoStateEventIdDto _stateEventId;

		protected internal virtual AttributeValueMvoStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new AttributeValueMvoStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual AttributeValueIdDto AttributeValueId
        {
            get { return StateEventId.AttributeValueId; }
            set { StateEventId.AttributeValueId = value; }
        }

        public virtual long AttributeVersion
        {
            get { return StateEventId.AttributeVersion; }
            set { StateEventId.AttributeVersion = value; }
        }

		public virtual string Name { get; set; }

		public virtual string Description { get; set; }

		public virtual string ReferenceId { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string AttributeName { get; set; }

		public virtual string AttributeOrganizationId { get; set; }

		public virtual string AttributeDescription { get; set; }

		public virtual bool? AttributeIsMandatory { get; set; }

		public virtual bool? AttributeIsInstanceAttribute { get; set; }

		public virtual string AttributeAttributeValueType { get; set; }

		public virtual int? AttributeAttributeValueLength { get; set; }

		public virtual bool? AttributeIsList { get; set; }

		public virtual string AttributeFieldName { get; set; }

		public virtual string AttributeReferenceId { get; set; }

		public virtual string AttributeCreatedBy { get; set; }

		public virtual DateTime? AttributeCreatedAt { get; set; }

		public virtual string AttributeUpdatedBy { get; set; }

		public virtual DateTime? AttributeUpdatedAt { get; set; }

		public virtual bool? AttributeActive { get; set; }

		public virtual bool? AttributeDeleted { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeValueMvoStateEventId IGlobalIdentity<AttributeValueMvoStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToAttributeValueMvoStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeValueMvoStateEvent.ReadOnly
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

        bool IAttributeValueMvoStateMergePatched.IsPropertyNameRemoved
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

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyReferenceIdRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyReferenceIdRemoved
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

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyVersionRemoved
        {
            get 
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyActiveRemoved
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

		public virtual bool? IsPropertyAttributeNameRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeNameRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeOrganizationIdRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeOrganizationIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeOrganizationIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeOrganizationIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeDescriptionRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeIsMandatoryRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeIsMandatoryRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeIsMandatoryRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeIsMandatoryRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeIsInstanceAttributeRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeIsInstanceAttributeRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeIsInstanceAttributeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeIsInstanceAttributeRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeAttributeValueTypeRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeAttributeValueTypeRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeAttributeValueTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeAttributeValueTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeAttributeValueLengthRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeAttributeValueLengthRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeAttributeValueLengthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeAttributeValueLengthRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeIsListRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeIsListRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeIsListRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeIsListRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeFieldNameRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeFieldNameRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeFieldNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeFieldNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeReferenceIdRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeReferenceIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeReferenceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeReferenceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeCreatedByRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeCreatedAtRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeUpdatedByRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeUpdatedAtRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeActiveRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeDeletedRemoved { get; set; }

        bool IAttributeValueMvoStateMergePatched.IsPropertyAttributeDeletedRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeDeletedRemoved = value;
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


        AttributeValueMvoStateEventId IAttributeValueMvoStateEvent.StateEventId
        {
            get { return this.StateEventId.ToAttributeValueMvoStateEventId(); }
        }

        protected AttributeValueMvoStateEventDtoBase()
        {
        }

        protected AttributeValueMvoStateEventDtoBase(AttributeValueMvoStateEventIdDto stateEventId)
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


    public class AttributeValueMvoStateCreatedOrMergePatchedOrDeletedDto : AttributeValueMvoStateEventDtoBase
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



	public class AttributeValueMvoStateCreatedDto : AttributeValueMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeValueMvoStateCreatedDto()
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


	public class AttributeValueMvoStateMergePatchedDto : AttributeValueMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeValueMvoStateMergePatchedDto()
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


	public class AttributeValueMvoStateDeletedDto : AttributeValueMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeValueMvoStateDeletedDto()
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


    public partial class AttributeValueMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IAttributeValueMvoStateCreated>, IEnumerable<IAttributeValueMvoStateMergePatched>, IEnumerable<IAttributeValueMvoStateDeleted>
    {
        private List<AttributeValueMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<AttributeValueMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual AttributeValueMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<AttributeValueMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeValueMvoStateCreated> IEnumerable<IAttributeValueMvoStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeValueMvoStateMergePatched> IEnumerable<IAttributeValueMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeValueMvoStateDeleted> IEnumerable<IAttributeValueMvoStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddAttributeValueMvoEvent(IAttributeValueMvoStateCreated e)
        {
            _innerStateEvents.Add((AttributeValueMvoStateCreatedDto)e);
        }

        public void AddAttributeValueMvoEvent(IAttributeValueMvoStateEvent e)
        {
            _innerStateEvents.Add((AttributeValueMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddAttributeValueMvoEvent(IAttributeValueMvoStateDeleted e)
        {
            _innerStateEvents.Add((AttributeValueMvoStateDeletedDto)e);
        }

    }


}

