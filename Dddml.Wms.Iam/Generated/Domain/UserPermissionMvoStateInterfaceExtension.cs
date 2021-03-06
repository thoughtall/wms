﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserPermissionMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserPermissionMvo
{

	public static partial class UserPermissionMvoStateInterfaceExtension
	{

        public static IUserPermissionMvoCommand ToCreateOrMergePatchUserPermissionMvo<TCreateUserPermissionMvo, TMergePatchUserPermissionMvo>(this IUserPermissionMvoState state)
            where TCreateUserPermissionMvo : ICreateUserPermissionMvo, new()
            where TMergePatchUserPermissionMvo : IMergePatchUserPermissionMvo, new()
        {
            bool bUnsaved = ((IUserPermissionMvoState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateUserPermissionMvo<TCreateUserPermissionMvo>();
            }
            else 
            {
                return state.ToMergePatchUserPermissionMvo<TMergePatchUserPermissionMvo>();
            }
        }

        public static TDeleteUserPermissionMvo ToDeleteUserPermissionMvo<TDeleteUserPermissionMvo>(this IUserPermissionMvoState state)
            where TDeleteUserPermissionMvo : IDeleteUserPermissionMvo, new()
        {
            var cmd = new TDeleteUserPermissionMvo();
            cmd.UserPermissionId = state.UserPermissionId;
            cmd.UserVersion = ((IUserPermissionMvoStateProperties)state).UserVersion;

            return cmd;
        }

        public static TMergePatchUserPermissionMvo ToMergePatchUserPermissionMvo<TMergePatchUserPermissionMvo>(this IUserPermissionMvoState state)
            where TMergePatchUserPermissionMvo : IMergePatchUserPermissionMvo, new()
        {
            var cmd = new TMergePatchUserPermissionMvo();

            cmd.UserVersion = ((IUserPermissionMvoStateProperties)state).UserVersion;

            cmd.UserPermissionId = state.UserPermissionId;
            cmd.Version = ((IUserPermissionMvoStateProperties)state).Version;
            cmd.Active = ((IUserPermissionMvoStateProperties)state).Active;
            cmd.UserUserName = state.UserUserName;
            cmd.UserAccessFailedCount = state.UserAccessFailedCount;
            cmd.UserEmail = state.UserEmail;
            cmd.UserEmailConfirmed = state.UserEmailConfirmed;
            cmd.UserLockoutEnabled = state.UserLockoutEnabled;
            cmd.UserLockoutEndDateUtc = state.UserLockoutEndDateUtc;
            cmd.UserPasswordHash = state.UserPasswordHash;
            cmd.UserPhoneNumber = state.UserPhoneNumber;
            cmd.UserPhoneNumberConfirmed = state.UserPhoneNumberConfirmed;
            cmd.UserTwoFactorEnabled = state.UserTwoFactorEnabled;
            cmd.UserSecurityStamp = state.UserSecurityStamp;
            cmd.UserCreatedBy = state.UserCreatedBy;
            cmd.UserCreatedAt = state.UserCreatedAt;
            cmd.UserUpdatedBy = state.UserUpdatedBy;
            cmd.UserUpdatedAt = state.UserUpdatedAt;
            cmd.UserActive = state.UserActive;
            cmd.UserDeleted = state.UserDeleted;
            
            if (state.UserUserName == null) { cmd.IsPropertyUserUserNameRemoved = true; }
            if (state.UserEmail == null) { cmd.IsPropertyUserEmailRemoved = true; }
            if (state.UserLockoutEndDateUtc == null) { cmd.IsPropertyUserLockoutEndDateUtcRemoved = true; }
            if (state.UserPasswordHash == null) { cmd.IsPropertyUserPasswordHashRemoved = true; }
            if (state.UserPhoneNumber == null) { cmd.IsPropertyUserPhoneNumberRemoved = true; }
            if (state.UserSecurityStamp == null) { cmd.IsPropertyUserSecurityStampRemoved = true; }
            if (state.UserCreatedBy == null) { cmd.IsPropertyUserCreatedByRemoved = true; }
            if (state.UserUpdatedBy == null) { cmd.IsPropertyUserUpdatedByRemoved = true; }
            return cmd;
        }

        public static TCreateUserPermissionMvo ToCreateUserPermissionMvo<TCreateUserPermissionMvo>(this IUserPermissionMvoState state)
            where TCreateUserPermissionMvo : ICreateUserPermissionMvo, new()
        {
            var cmd = new TCreateUserPermissionMvo();

            cmd.UserVersion = ((IUserPermissionMvoStateProperties)state).UserVersion;

            cmd.UserPermissionId = state.UserPermissionId;
            cmd.Version = ((IUserPermissionMvoStateProperties)state).Version;
            cmd.Active = ((IUserPermissionMvoStateProperties)state).Active;
            cmd.UserUserName = state.UserUserName;
            cmd.UserAccessFailedCount = state.UserAccessFailedCount;
            cmd.UserEmail = state.UserEmail;
            cmd.UserEmailConfirmed = state.UserEmailConfirmed;
            cmd.UserLockoutEnabled = state.UserLockoutEnabled;
            cmd.UserLockoutEndDateUtc = state.UserLockoutEndDateUtc;
            cmd.UserPasswordHash = state.UserPasswordHash;
            cmd.UserPhoneNumber = state.UserPhoneNumber;
            cmd.UserPhoneNumberConfirmed = state.UserPhoneNumberConfirmed;
            cmd.UserTwoFactorEnabled = state.UserTwoFactorEnabled;
            cmd.UserSecurityStamp = state.UserSecurityStamp;
            cmd.UserCreatedBy = state.UserCreatedBy;
            cmd.UserCreatedAt = state.UserCreatedAt;
            cmd.UserUpdatedBy = state.UserUpdatedBy;
            cmd.UserUpdatedAt = state.UserUpdatedAt;
            cmd.UserActive = state.UserActive;
            cmd.UserDeleted = state.UserDeleted;
            return cmd;
        }
		

	}

}

