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

	public abstract class UserPermissionMvoStateEventDtoBase : IStateEventDto, IUserPermissionMvoStateCreated, IUserPermissionMvoStateMergePatched, IUserPermissionMvoStateDeleted
	{

        private UserPermissionMvoStateEventIdDto _stateEventId;

		protected internal virtual UserPermissionMvoStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new UserPermissionMvoStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual UserPermissionIdDto UserPermissionId
        {
            get { return StateEventId.UserPermissionId; }
            set { StateEventId.UserPermissionId = value; }
        }

        public virtual long UserVersion
        {
            get { return StateEventId.UserVersion; }
            set { StateEventId.UserVersion = value; }
        }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string UserUserName { get; set; }

		public virtual int? UserAccessFailedCount { get; set; }

		public virtual string UserEmail { get; set; }

		public virtual bool? UserEmailConfirmed { get; set; }

		public virtual bool? UserLockoutEnabled { get; set; }

		public virtual DateTime? UserLockoutEndDateUtc { get; set; }

		public virtual string UserPasswordHash { get; set; }

		public virtual string UserPhoneNumber { get; set; }

		public virtual bool? UserPhoneNumberConfirmed { get; set; }

		public virtual bool? UserTwoFactorEnabled { get; set; }

		public virtual string UserSecurityStamp { get; set; }

		public virtual string UserCreatedBy { get; set; }

		public virtual DateTime? UserCreatedAt { get; set; }

		public virtual string UserUpdatedBy { get; set; }

		public virtual DateTime? UserUpdatedAt { get; set; }

		public virtual bool? UserActive { get; set; }

		public virtual bool? UserDeleted { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		UserPermissionMvoStateEventId IGlobalIdentity<UserPermissionMvoStateEventId>.GlobalId {
			get {
				return this.StateEventId.ToUserPermissionMvoStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IUserPermissionMvoStateEvent.ReadOnly
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

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyVersionRemoved
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

        bool IUserPermissionMvoStateMergePatched.IsPropertyActiveRemoved
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

		public virtual bool? IsPropertyUserUserNameRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserUserNameRemoved
        {
            get 
            {
                var b = this.IsPropertyUserUserNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserUserNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserAccessFailedCountRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserAccessFailedCountRemoved
        {
            get 
            {
                var b = this.IsPropertyUserAccessFailedCountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserAccessFailedCountRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserEmailRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserEmailRemoved
        {
            get 
            {
                var b = this.IsPropertyUserEmailRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserEmailRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserEmailConfirmedRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserEmailConfirmedRemoved
        {
            get 
            {
                var b = this.IsPropertyUserEmailConfirmedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserEmailConfirmedRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserLockoutEnabledRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserLockoutEnabledRemoved
        {
            get 
            {
                var b = this.IsPropertyUserLockoutEnabledRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserLockoutEnabledRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserLockoutEndDateUtcRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserLockoutEndDateUtcRemoved
        {
            get 
            {
                var b = this.IsPropertyUserLockoutEndDateUtcRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserLockoutEndDateUtcRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserPasswordHashRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserPasswordHashRemoved
        {
            get 
            {
                var b = this.IsPropertyUserPasswordHashRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserPasswordHashRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserPhoneNumberRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserPhoneNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyUserPhoneNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserPhoneNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserPhoneNumberConfirmedRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserPhoneNumberConfirmedRemoved
        {
            get 
            {
                var b = this.IsPropertyUserPhoneNumberConfirmedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserPhoneNumberConfirmedRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserTwoFactorEnabledRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserTwoFactorEnabledRemoved
        {
            get 
            {
                var b = this.IsPropertyUserTwoFactorEnabledRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserTwoFactorEnabledRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserSecurityStampRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserSecurityStampRemoved
        {
            get 
            {
                var b = this.IsPropertyUserSecurityStampRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserSecurityStampRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserCreatedByRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyUserCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserCreatedAtRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyUserCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserUpdatedByRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyUserUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserUpdatedAtRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyUserUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserActiveRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyUserActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserDeletedRemoved { get; set; }

        bool IUserPermissionMvoStateMergePatched.IsPropertyUserDeletedRemoved
        {
            get 
            {
                var b = this.IsPropertyUserDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserDeletedRemoved = value;
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


        UserPermissionMvoStateEventId IUserPermissionMvoStateEvent.StateEventId
        {
            get { return this.StateEventId.ToUserPermissionMvoStateEventId(); }
        }

        protected UserPermissionMvoStateEventDtoBase()
        {
        }

        protected UserPermissionMvoStateEventDtoBase(UserPermissionMvoStateEventIdDto stateEventId)
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


    public class UserPermissionMvoStateCreatedOrMergePatchedOrDeletedDto : UserPermissionMvoStateEventDtoBase
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



	public class UserPermissionMvoStateCreatedDto : UserPermissionMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public UserPermissionMvoStateCreatedDto()
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


	public class UserPermissionMvoStateMergePatchedDto : UserPermissionMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public UserPermissionMvoStateMergePatchedDto()
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


	public class UserPermissionMvoStateDeletedDto : UserPermissionMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public UserPermissionMvoStateDeletedDto()
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


    public partial class UserPermissionMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IUserPermissionMvoStateCreated>, IEnumerable<IUserPermissionMvoStateMergePatched>, IEnumerable<IUserPermissionMvoStateDeleted>
    {
        private List<UserPermissionMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<UserPermissionMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual UserPermissionMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<UserPermissionMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserPermissionMvoStateCreated> IEnumerable<IUserPermissionMvoStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserPermissionMvoStateMergePatched> IEnumerable<IUserPermissionMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserPermissionMvoStateDeleted> IEnumerable<IUserPermissionMvoStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddUserPermissionMvoEvent(IUserPermissionMvoStateCreated e)
        {
            _innerStateEvents.Add((UserPermissionMvoStateCreatedDto)e);
        }

        public void AddUserPermissionMvoEvent(IUserPermissionMvoStateEvent e)
        {
            _innerStateEvents.Add((UserPermissionMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddUserPermissionMvoEvent(IUserPermissionMvoStateDeleted e)
        {
            _innerStateEvents.Add((UserPermissionMvoStateDeletedDto)e);
        }

    }


}

