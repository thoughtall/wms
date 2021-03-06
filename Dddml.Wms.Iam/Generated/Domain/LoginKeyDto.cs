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

	public class LoginKeyDto
	{

		public LoginKeyDto()
		{
		}

        public virtual LoginKey ToLoginKey()
        {
            LoginKey v = new LoginKey();
            v.LoginProvider = this.LoginProvider;
            v.ProviderKey = this.ProviderKey;
            return v;
        }

		public virtual string LoginProvider { 
			get;
			set;
		}

		public virtual string ProviderKey { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			LoginKeyDto other = obj as LoginKeyDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.LoginProvider, other.LoginProvider)
				&& Object.Equals (this.ProviderKey, other.ProviderKey)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.LoginProvider != null) {
				hash += 13 * this.LoginProvider.GetHashCode ();
			}
			if (this.ProviderKey != null) {
				hash += 13 * this.ProviderKey.GetHashCode ();
			}
			return hash;
		}

	}

}


