﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Organization;

namespace Dddml.Wms.Domain.Organization
{

	public class OrganizationStateEventIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "OrganizationId", "Version" };

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
            if (fieldName.Equals("OrganizationId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("Version", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(long);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private OrganizationStateEventIdDto _value = new OrganizationStateEventIdDto();

		public OrganizationStateEventIdFlattenedDto()
		{
		}

		public OrganizationStateEventIdFlattenedDto(OrganizationStateEventIdDto val)
		{
			this._value = val;
		}

        public OrganizationStateEventIdDto ToOrganizationStateEventIdDto()
        {
            return this._value;
        }

		public OrganizationStateEventIdFlattenedDto(OrganizationStateEventId val)
		{
			this._value = new OrganizationStateEventIdDtoWrapper(val);
		}

        public OrganizationStateEventId ToOrganizationStateEventId()
        {
            return this._value.ToOrganizationStateEventId();
        }

		public virtual string OrganizationId { 
			get { return _value.OrganizationId; } 
			set { _value.OrganizationId = value; } 
		}

		public virtual long Version { 
			get { return _value.Version; } 
			set { _value.Version = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			OrganizationStateEventIdFlattenedDto other = obj as OrganizationStateEventIdFlattenedDto;
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

    public class OrganizationStateEventIdFlattenedDtoFormatter : IdFlattenedDtoFormatterBase<OrganizationStateEventIdFlattenedDto>
    {

    }

}


