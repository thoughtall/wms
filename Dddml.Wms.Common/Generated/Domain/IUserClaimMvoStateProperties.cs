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

	public interface IUserClaimMvoStateProperties
	{
		UserClaimId UserClaimId { get; set; }

		string ClaimType { get; set; }

		string ClaimValue { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

		string UserUserName { get; set; }

		int UserAccessFailedCount { get; set; }

		string UserEmail { get; set; }

		bool UserEmailConfirmed { get; set; }

		bool UserLockoutEnabled { get; set; }

		DateTime? UserLockoutEndDateUtc { get; set; }

		string UserPasswordHash { get; set; }

		string UserPhoneNumber { get; set; }

		bool UserPhoneNumberConfirmed { get; set; }

		bool UserTwoFactorEnabled { get; set; }

		string UserSecurityStamp { get; set; }

		long UserVersion { get; set; }

		string UserCreatedBy { get; set; }

		DateTime UserCreatedAt { get; set; }

		string UserUpdatedBy { get; set; }

		DateTime UserUpdatedAt { get; set; }

		bool UserActive { get; set; }

		bool UserDeleted { get; set; }

	}

}
