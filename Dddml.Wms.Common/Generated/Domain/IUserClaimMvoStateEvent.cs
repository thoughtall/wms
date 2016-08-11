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
	public interface IUserClaimMvoStateEvent : IEvent, IStateEventDto, IGlobalIdentity<UserClaimMvoStateEventId>, ICreated<string>
	{
		UserClaimMvoStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		string ClaimType { get; set; }

		string ClaimValue { get; set; }

		long? Version { get; set; }

		bool? Active { get; set; }

		string UserUserName { get; set; }

		int? UserAccessFailedCount { get; set; }

		string UserEmail { get; set; }

		bool? UserEmailConfirmed { get; set; }

		bool? UserLockoutEnabled { get; set; }

		DateTime? UserLockoutEndDateUtc { get; set; }

		string UserPasswordHash { get; set; }

		string UserPhoneNumber { get; set; }

		bool? UserPhoneNumberConfirmed { get; set; }

		bool? UserTwoFactorEnabled { get; set; }

		string UserSecurityStamp { get; set; }

		string UserCreatedBy { get; set; }

		DateTime? UserCreatedAt { get; set; }

		string UserUpdatedBy { get; set; }

		DateTime? UserUpdatedAt { get; set; }

		bool? UserActive { get; set; }

		bool? UserDeleted { get; set; }

	}

	public interface IUserClaimMvoStateCreated : IUserClaimMvoStateEvent//, IUserClaimMvoStateProperties
	{
	
	}


	public interface IUserClaimMvoStateMergePatched : IUserClaimMvoStateEvent//, IUserClaimMvoStateProperties
	{
		bool IsPropertyClaimTypeRemoved { get; set; }

		bool IsPropertyClaimValueRemoved { get; set; }

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyUserUserNameRemoved { get; set; }

		bool IsPropertyUserAccessFailedCountRemoved { get; set; }

		bool IsPropertyUserEmailRemoved { get; set; }

		bool IsPropertyUserEmailConfirmedRemoved { get; set; }

		bool IsPropertyUserLockoutEnabledRemoved { get; set; }

		bool IsPropertyUserLockoutEndDateUtcRemoved { get; set; }

		bool IsPropertyUserPasswordHashRemoved { get; set; }

		bool IsPropertyUserPhoneNumberRemoved { get; set; }

		bool IsPropertyUserPhoneNumberConfirmedRemoved { get; set; }

		bool IsPropertyUserTwoFactorEnabledRemoved { get; set; }

		bool IsPropertyUserSecurityStampRemoved { get; set; }

		bool IsPropertyUserCreatedByRemoved { get; set; }

		bool IsPropertyUserCreatedAtRemoved { get; set; }

		bool IsPropertyUserUpdatedByRemoved { get; set; }

		bool IsPropertyUserUpdatedAtRemoved { get; set; }

		bool IsPropertyUserActiveRemoved { get; set; }

		bool IsPropertyUserDeletedRemoved { get; set; }


	}

	public interface IUserClaimMvoStateDeleted : IUserClaimMvoStateEvent
	{
	}


}

