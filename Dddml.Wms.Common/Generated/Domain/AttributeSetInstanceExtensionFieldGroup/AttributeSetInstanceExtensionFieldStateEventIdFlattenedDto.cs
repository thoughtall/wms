﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldGroupDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup
{

	public class AttributeSetInstanceExtensionFieldStateEventIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "GroupId", "Index", "AttributeSetInstanceExtensionFieldGroupVersion" };

        string[] IIdFlattenedDto.FieldNames
        {
            get { return _flattenedPropertyNames; }
        }

        object IIdFlattenedDto.GetFieldValue(string fieldName)
        {
            return ReflectUtils.GetPropertyValue(fieldName, this._value);
        }

        void IIdFlattenedDto.SetFieldValue(string fieldName, object fieldValue)
        {
            ReflectUtils.SetPropertyValue(fieldName, this._value, fieldValue);
        }

        Type IIdFlattenedDto.GetFieldType(string fieldName)
        {
            if (fieldName.Equals("GroupId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("Index", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("AttributeSetInstanceExtensionFieldGroupVersion", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(long);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private AttributeSetInstanceExtensionFieldStateEventIdDto _value = new AttributeSetInstanceExtensionFieldStateEventIdDto();

		public AttributeSetInstanceExtensionFieldStateEventIdFlattenedDto()
		{
		}

		public AttributeSetInstanceExtensionFieldStateEventIdFlattenedDto(AttributeSetInstanceExtensionFieldStateEventIdDto val)
		{
			this._value = val;
		}

        public AttributeSetInstanceExtensionFieldStateEventIdDto ToAttributeSetInstanceExtensionFieldStateEventIdDto()
        {
            return this._value;
        }

		public AttributeSetInstanceExtensionFieldStateEventIdFlattenedDto(AttributeSetInstanceExtensionFieldStateEventId val)
		{
			this._value = new AttributeSetInstanceExtensionFieldStateEventIdDtoWrapper(val);
		}

        public AttributeSetInstanceExtensionFieldStateEventId ToAttributeSetInstanceExtensionFieldStateEventId()
        {
            return this._value.ToAttributeSetInstanceExtensionFieldStateEventId();
        }

		public virtual string GroupId { 
			get { return _value.GroupId; } 
			set { _value.GroupId = value; } 
		}

		public virtual string Index { 
			get { return _value.Index; } 
			set { _value.Index = value; } 
		}

		public virtual long AttributeSetInstanceExtensionFieldGroupVersion { 
			get { return _value.AttributeSetInstanceExtensionFieldGroupVersion; } 
			set { _value.AttributeSetInstanceExtensionFieldGroupVersion = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeSetInstanceExtensionFieldStateEventIdFlattenedDto other = obj as AttributeSetInstanceExtensionFieldStateEventIdFlattenedDto;
			if (other == null) {
				return false;
			}

            return _value.Equals(other._value);

		}

		public override int GetHashCode ()
		{
			return _value.GetHashCode();
		}

	}

    public class AttributeSetInstanceExtensionFieldStateEventIdFlattenedDtoFormatter : IdFlattenedDtoFormatterBase<AttributeSetInstanceExtensionFieldStateEventIdFlattenedDto>
    {

    }

}


