﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserRoleMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserRoleMvo
{

    public class UserRoleMvoStateEventDtoConverter
    {
        public virtual UserRoleMvoStateCreatedOrMergePatchedOrDeletedDto ToUserRoleMvoStateEventDto(IUserRoleMvoStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IUserRoleMvoStateCreated)stateEvent;
                return ToUserRoleMvoStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IUserRoleMvoStateMergePatched)stateEvent;
                return ToUserRoleMvoStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IUserRoleMvoStateDeleted)stateEvent;
                return ToUserRoleMvoStateDeletedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual UserRoleMvoStateCreatedDto ToUserRoleMvoStateCreatedDto(IUserRoleMvoStateCreated e)
        {
            var dto = new UserRoleMvoStateCreatedDto();
            dto.StateEventId = new UserRoleMvoStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.UserUserName = e.UserUserName;
            dto.UserAccessFailedCount = e.UserAccessFailedCount;
            dto.UserEmail = e.UserEmail;
            dto.UserEmailConfirmed = e.UserEmailConfirmed;
            dto.UserLockoutEnabled = e.UserLockoutEnabled;
            dto.UserLockoutEndDateUtc = e.UserLockoutEndDateUtc;
            dto.UserPasswordHash = e.UserPasswordHash;
            dto.UserPhoneNumber = e.UserPhoneNumber;
            dto.UserPhoneNumberConfirmed = e.UserPhoneNumberConfirmed;
            dto.UserTwoFactorEnabled = e.UserTwoFactorEnabled;
            dto.UserSecurityStamp = e.UserSecurityStamp;
            dto.UserCreatedBy = e.UserCreatedBy;
            dto.UserCreatedAt = e.UserCreatedAt;
            dto.UserUpdatedBy = e.UserUpdatedBy;
            dto.UserUpdatedAt = e.UserUpdatedAt;
            dto.UserActive = e.UserActive;
            dto.UserDeleted = e.UserDeleted;
            return dto;
        }

        public virtual UserRoleMvoStateMergePatchedDto ToUserRoleMvoStateMergePatchedDto(IUserRoleMvoStateMergePatched e)
        {
            var dto = new UserRoleMvoStateMergePatchedDto();
            dto.StateEventId = new UserRoleMvoStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.UserUserName = e.UserUserName;
            dto.UserAccessFailedCount = e.UserAccessFailedCount;
            dto.UserEmail = e.UserEmail;
            dto.UserEmailConfirmed = e.UserEmailConfirmed;
            dto.UserLockoutEnabled = e.UserLockoutEnabled;
            dto.UserLockoutEndDateUtc = e.UserLockoutEndDateUtc;
            dto.UserPasswordHash = e.UserPasswordHash;
            dto.UserPhoneNumber = e.UserPhoneNumber;
            dto.UserPhoneNumberConfirmed = e.UserPhoneNumberConfirmed;
            dto.UserTwoFactorEnabled = e.UserTwoFactorEnabled;
            dto.UserSecurityStamp = e.UserSecurityStamp;
            dto.UserCreatedBy = e.UserCreatedBy;
            dto.UserCreatedAt = e.UserCreatedAt;
            dto.UserUpdatedBy = e.UserUpdatedBy;
            dto.UserUpdatedAt = e.UserUpdatedAt;
            dto.UserActive = e.UserActive;
            dto.UserDeleted = e.UserDeleted;
            dto.IsPropertyVersionRemoved = e.IsPropertyVersionRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;
            dto.IsPropertyUserUserNameRemoved = e.IsPropertyUserUserNameRemoved;
            dto.IsPropertyUserAccessFailedCountRemoved = e.IsPropertyUserAccessFailedCountRemoved;
            dto.IsPropertyUserEmailRemoved = e.IsPropertyUserEmailRemoved;
            dto.IsPropertyUserEmailConfirmedRemoved = e.IsPropertyUserEmailConfirmedRemoved;
            dto.IsPropertyUserLockoutEnabledRemoved = e.IsPropertyUserLockoutEnabledRemoved;
            dto.IsPropertyUserLockoutEndDateUtcRemoved = e.IsPropertyUserLockoutEndDateUtcRemoved;
            dto.IsPropertyUserPasswordHashRemoved = e.IsPropertyUserPasswordHashRemoved;
            dto.IsPropertyUserPhoneNumberRemoved = e.IsPropertyUserPhoneNumberRemoved;
            dto.IsPropertyUserPhoneNumberConfirmedRemoved = e.IsPropertyUserPhoneNumberConfirmedRemoved;
            dto.IsPropertyUserTwoFactorEnabledRemoved = e.IsPropertyUserTwoFactorEnabledRemoved;
            dto.IsPropertyUserSecurityStampRemoved = e.IsPropertyUserSecurityStampRemoved;
            dto.IsPropertyUserCreatedByRemoved = e.IsPropertyUserCreatedByRemoved;
            dto.IsPropertyUserCreatedAtRemoved = e.IsPropertyUserCreatedAtRemoved;
            dto.IsPropertyUserUpdatedByRemoved = e.IsPropertyUserUpdatedByRemoved;
            dto.IsPropertyUserUpdatedAtRemoved = e.IsPropertyUserUpdatedAtRemoved;
            dto.IsPropertyUserActiveRemoved = e.IsPropertyUserActiveRemoved;
            dto.IsPropertyUserDeletedRemoved = e.IsPropertyUserDeletedRemoved;

            return dto;
        }


        public virtual UserRoleMvoStateDeletedDto ToUserRoleMvoStateDeletedDto(IUserRoleMvoStateDeleted e)
        {
            var dto = new UserRoleMvoStateDeletedDto();
            dto.StateEventId = new UserRoleMvoStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

