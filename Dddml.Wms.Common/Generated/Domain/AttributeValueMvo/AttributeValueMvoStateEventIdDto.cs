﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeValueMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeValueMvo;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.AttributeValueMvo
{

	public class AttributeValueMvoStateEventIdDto
	{

		public AttributeValueMvoStateEventIdDto()
		{
		}

        public virtual AttributeValueMvoStateEventId ToAttributeValueMvoStateEventId()
        {
            AttributeValueMvoStateEventId v = new AttributeValueMvoStateEventId();
            v.AttributeValueId = this.AttributeValueId.ToAttributeValueId();
            v.AttributeVersion = this.AttributeVersion;
            return v;
        }

		private AttributeValueIdDto _attributeValueId = new AttributeValueIdDto();

		public virtual AttributeValueIdDto AttributeValueId { 
			get { return this._attributeValueId; } 
			set { this._attributeValueId = value; } 
		}

		public virtual long AttributeVersion { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeValueMvoStateEventIdDto other = obj as AttributeValueMvoStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.AttributeValueId, other.AttributeValueId)
				&& Object.Equals (this.AttributeVersion, other.AttributeVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.AttributeValueId != null) {
				hash += 13 * this.AttributeValueId.GetHashCode ();
			}
			if (this.AttributeVersion != null) {
				hash += 13 * this.AttributeVersion.GetHashCode ();
			}
			return hash;
		}

	}

}


