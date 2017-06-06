﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{

	public class AttributeValueId
	{

		private string _attributeId;

		public virtual string AttributeId { 
			get { return this._attributeId; } 
			internal set { _attributeId = value; } 
		}

		private string _value;

		public virtual string Value { 
			get { return this._value; } 
			internal set { _value = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal AttributeValueId ()
		{
		}

		public AttributeValueId (string attributeId, string value)
		{
			this._attributeId = attributeId;
			this._value = value;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeValueId other = obj as AttributeValueId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.AttributeId, other.AttributeId)
				&& Object.Equals (this.Value, other.Value)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.AttributeId != null) {
				hash += 13 * this.AttributeId.GetHashCode ();
			}
			if (this.Value != null) {
				hash += 13 * this.Value.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(AttributeValueId obj1, AttributeValueId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(AttributeValueId obj1, AttributeValueId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}

