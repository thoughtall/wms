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

	public abstract class AudienceStateEventDtoBase : IStateEventDto, IAudienceStateCreated, IAudienceStateMergePatched, IAudienceStateDeleted
	{

		public virtual AudienceStateEventIdDto StateEventId { get; set; }

		public virtual string Name { get; set; }

		public virtual string Base64Secret { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		AudienceStateEventId IGlobalIdentity<AudienceStateEventId>.GlobalId {
			get {
				return this.StateEventId.ToAudienceStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAudienceStateEvent.ReadOnly
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

        bool IAudienceStateMergePatched.IsPropertyNameRemoved
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

		public virtual bool? IsPropertyBase64SecretRemoved { get; set; }

        bool IAudienceStateMergePatched.IsPropertyBase64SecretRemoved
        {
            get 
            {
                var b = this.IsPropertyBase64SecretRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyBase64SecretRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IAudienceStateMergePatched.IsPropertyActiveRemoved
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


        AudienceStateEventId IAudienceStateEvent.StateEventId
        {
            get { return this.StateEventId.ToAudienceStateEventId(); }
        }

        protected AudienceStateEventDtoBase()
        {
        }

        protected AudienceStateEventDtoBase(AudienceStateEventIdDto stateEventId)
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


    public class AudienceStateCreatedOrMergePatchedOrDeletedDto : AudienceStateEventDtoBase
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



	public class AudienceStateCreatedDto : AudienceStateCreatedOrMergePatchedOrDeletedDto
	{
		public AudienceStateCreatedDto()
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


	public class AudienceStateMergePatchedDto : AudienceStateCreatedOrMergePatchedOrDeletedDto
	{
		public AudienceStateMergePatchedDto()
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


	public class AudienceStateDeletedDto : AudienceStateCreatedOrMergePatchedOrDeletedDto
	{
		public AudienceStateDeletedDto()
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


    public partial class AudienceStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IAudienceStateCreated>, IEnumerable<IAudienceStateMergePatched>, IEnumerable<IAudienceStateDeleted>
    {
        private List<AudienceStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<AudienceStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual AudienceStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<AudienceStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        public IEnumerator<IAudienceStateCreated> GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAudienceStateMergePatched> IEnumerable<IAudienceStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAudienceStateDeleted> IEnumerable<IAudienceStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddAudienceEvent(IAudienceStateCreated e)
        {
            _innerStateEvents.Add((AudienceStateCreatedDto)e);
        }

        public void AddAudienceEvent(IAudienceStateEvent e)
        {
            _innerStateEvents.Add((AudienceStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddAudienceEvent(IAudienceStateDeleted e)
        {
            _innerStateEvents.Add((AudienceStateDeletedDto)e);
        }

    }


}

