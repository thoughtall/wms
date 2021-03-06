﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{

	public class UserClaimIdDto
	{

		public UserClaimIdDto()
		{
		}

        public virtual UserClaimId ToUserClaimId()
        {
            UserClaimId v = new UserClaimId();
            v.UserId = this.UserId;
            v.ClaimId = this.ClaimId;
            return v;
        }

		public virtual string UserId { 
			get;
			set;
		}

		public virtual int ClaimId { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UserClaimIdDto other = obj as UserClaimIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.UserId, other.UserId)
				&& Object.Equals (this.ClaimId, other.ClaimId)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.UserId != null) {
				hash += 13 * this.UserId.GetHashCode ();
			}
			if (this.ClaimId != null) {
				hash += 13 * this.ClaimId.GetHashCode ();
			}
			return hash;
		}

	}

}


