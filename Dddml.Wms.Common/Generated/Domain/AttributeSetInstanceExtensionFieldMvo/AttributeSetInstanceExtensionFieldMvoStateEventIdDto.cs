﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldMvo;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldMvo
{

	public class AttributeSetInstanceExtensionFieldMvoStateEventIdDto
	{

		public AttributeSetInstanceExtensionFieldMvoStateEventIdDto()
		{
		}

        public virtual AttributeSetInstanceExtensionFieldMvoStateEventId ToAttributeSetInstanceExtensionFieldMvoStateEventId()
        {
            AttributeSetInstanceExtensionFieldMvoStateEventId v = new AttributeSetInstanceExtensionFieldMvoStateEventId();
            v.AttributeSetInstanceExtensionFieldId = this.AttributeSetInstanceExtensionFieldId.ToAttributeSetInstanceExtensionFieldId();
            v.AttrSetInstEFGroupVersion = this.AttrSetInstEFGroupVersion;
            return v;
        }

		private AttributeSetInstanceExtensionFieldIdDto _attributeSetInstanceExtensionFieldId = new AttributeSetInstanceExtensionFieldIdDto();

		public virtual AttributeSetInstanceExtensionFieldIdDto AttributeSetInstanceExtensionFieldId { 
			get { return this._attributeSetInstanceExtensionFieldId; } 
			set { this._attributeSetInstanceExtensionFieldId = value; } 
		}

		public virtual long AttrSetInstEFGroupVersion { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeSetInstanceExtensionFieldMvoStateEventIdDto other = obj as AttributeSetInstanceExtensionFieldMvoStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.AttributeSetInstanceExtensionFieldId, other.AttributeSetInstanceExtensionFieldId)
				&& Object.Equals (this.AttrSetInstEFGroupVersion, other.AttrSetInstEFGroupVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.AttributeSetInstanceExtensionFieldId != null) {
				hash += 13 * this.AttributeSetInstanceExtensionFieldId.GetHashCode ();
			}
			if (this.AttrSetInstEFGroupVersion != null) {
				hash += 13 * this.AttrSetInstEFGroupVersion.GetHashCode ();
			}
			return hash;
		}

	}

}


