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

	public class UserClaimMvoStateEventIdDto
	{

		public UserClaimMvoStateEventIdDto()
		{
		}

        public virtual UserClaimMvoStateEventId ToUserClaimMvoStateEventId()
        {
            UserClaimMvoStateEventId v = new UserClaimMvoStateEventId();
            v.UserClaimId = this.UserClaimId.ToUserClaimId();
            v.UserVersion = this.UserVersion;
            return v;
        }

		private UserClaimIdDto _userClaimId = new UserClaimIdDto();

		public virtual UserClaimIdDto UserClaimId { 
			get { return this._userClaimId; } 
			set { this._userClaimId = value; } 
		}

		public virtual long UserVersion { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UserClaimMvoStateEventIdDto other = obj as UserClaimMvoStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.UserClaimId, other.UserClaimId)
				&& Object.Equals (this.UserVersion, other.UserVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.UserClaimId != null) {
				hash += 13 * this.UserClaimId.GetHashCode ();
			}
			if (this.UserVersion != null) {
				hash += 13 * this.UserVersion.GetHashCode ();
			}
			return hash;
		}

	}

}

