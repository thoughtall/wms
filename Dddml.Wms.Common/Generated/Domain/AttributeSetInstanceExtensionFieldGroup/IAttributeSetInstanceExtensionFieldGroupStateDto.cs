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

    public interface IAttributeSetInstanceExtensionFieldGroupStateDto
    {
        string Id
        {
            get;
            set;
        }

        string FieldType
        {
            get;
            set;
        }

        int? FieldLength
        {
            get;
            set;
        }

        int? FieldCount
        {
            get;
            set;
        }

        string NameFormat
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }

        bool? Active
        {
            get;
            set;
        }

        long? Version
        {
            get;
            set;
        }

        string CreatedBy
        {
            get;
            set;
        }

        DateTime? CreatedAt
        {
            get;
            set;
        }

        string UpdatedBy
        {
            get;
            set;
        }

        DateTime? UpdatedAt
        {
            get;
            set;
        }

        IAttributeSetInstanceExtensionFieldStateDto[] Fields
        {
            get;
            set;
        }

        IAttributeSetInstanceExtensionFieldGroupState ToAttributeSetInstanceExtensionFieldGroupState();

    }

}

