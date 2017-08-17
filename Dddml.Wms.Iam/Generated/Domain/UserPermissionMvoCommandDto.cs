﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserPermissionMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserPermissionMvo
{

	public abstract class UserPermissionMvoCommandDtoBase : ICommandDto, ICreateUserPermissionMvo, IMergePatchUserPermissionMvo, IDeleteUserPermissionMvo
	{

		UserPermissionId IAggregateCommand<UserPermissionId, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteUserPermissionMvo)this).UserPermissionId;
			}
		}


		long IAggregateCommand<UserPermissionId, long>.AggregateVersion
		{
			get
			{
				return this.UserVersion;
			}
		}

		public virtual long UserVersion { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual UserPermissionIdDto UserPermissionId { get; set; }

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


        UserPermissionId IUserPermissionMvoCommand.UserPermissionId
        {
            get 
            {
                return this.UserPermissionId.ToUserPermissionId();
            }
            set 
            {
                this.UserPermissionId = new UserPermissionIdDtoWrapper(value);
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyVersionRemoved
        {
            get
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyActiveRemoved
        {
            get
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserUserNameRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserUserNameRemoved
        {
            get
            {
                var b = this.IsPropertyUserUserNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserUserNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserAccessFailedCountRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserAccessFailedCountRemoved
        {
            get
            {
                var b = this.IsPropertyUserAccessFailedCountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserAccessFailedCountRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserEmailRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserEmailRemoved
        {
            get
            {
                var b = this.IsPropertyUserEmailRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserEmailRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserEmailConfirmedRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserEmailConfirmedRemoved
        {
            get
            {
                var b = this.IsPropertyUserEmailConfirmedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserEmailConfirmedRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserLockoutEnabledRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserLockoutEnabledRemoved
        {
            get
            {
                var b = this.IsPropertyUserLockoutEnabledRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserLockoutEnabledRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserLockoutEndDateUtcRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserLockoutEndDateUtcRemoved
        {
            get
            {
                var b = this.IsPropertyUserLockoutEndDateUtcRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserLockoutEndDateUtcRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserPasswordHashRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserPasswordHashRemoved
        {
            get
            {
                var b = this.IsPropertyUserPasswordHashRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserPasswordHashRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserPhoneNumberRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserPhoneNumberRemoved
        {
            get
            {
                var b = this.IsPropertyUserPhoneNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserPhoneNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserPhoneNumberConfirmedRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserPhoneNumberConfirmedRemoved
        {
            get
            {
                var b = this.IsPropertyUserPhoneNumberConfirmedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserPhoneNumberConfirmedRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserTwoFactorEnabledRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserTwoFactorEnabledRemoved
        {
            get
            {
                var b = this.IsPropertyUserTwoFactorEnabledRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserTwoFactorEnabledRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserSecurityStampRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserSecurityStampRemoved
        {
            get
            {
                var b = this.IsPropertyUserSecurityStampRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserSecurityStampRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserCreatedByRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserCreatedByRemoved
        {
            get
            {
                var b = this.IsPropertyUserCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserCreatedAtRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserCreatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyUserCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserUpdatedByRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserUpdatedByRemoved
        {
            get
            {
                var b = this.IsPropertyUserUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserUpdatedAtRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserUpdatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyUserUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserActiveRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserActiveRemoved
        {
            get
            {
                var b = this.IsPropertyUserActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserDeletedRemoved { get; set; }

        bool IMergePatchUserPermissionMvo.IsPropertyUserDeletedRemoved
        {
            get
            {
                var b = this.IsPropertyUserDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserDeletedRemoved = value;
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteUserPermissionMvoDto : UserPermissionMvoCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateUserPermissionMvoDto : CreateOrMergePatchOrDeleteUserPermissionMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchUserPermissionMvoDto : CreateOrMergePatchOrDeleteUserPermissionMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteUserPermissionMvoDto : CreateOrMergePatchOrDeleteUserPermissionMvoDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}

    public static partial class UserPermissionMvoCommandDtos
    {

    }

}

