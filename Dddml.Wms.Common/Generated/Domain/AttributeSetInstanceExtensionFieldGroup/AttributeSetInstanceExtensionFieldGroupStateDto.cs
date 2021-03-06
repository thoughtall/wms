﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldGroupDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup
{

    public partial class AttributeSetInstanceExtensionFieldGroupStateDto : IAttributeSetInstanceExtensionFieldGroupStateDto
    {
        public virtual string Id
        {
            get;
            set;
        }

        public virtual string FieldType
        {
            get;
            set;
        }

        public virtual int? FieldLength
        {
            get;
            set;
        }

        public virtual int? FieldCount
        {
            get;
            set;
        }

        public virtual string NameFormat
        {
            get;
            set;
        }

        public virtual string Description
        {
            get;
            set;
        }

        public virtual bool? Active
        {
            get;
            set;
        }

        public virtual long? Version
        {
            get;
            set;
        }

        public virtual string CreatedBy
        {
            get;
            set;
        }

        public virtual DateTime? CreatedAt
        {
            get;
            set;
        }

        public virtual string UpdatedBy
        {
            get;
            set;
        }

        public virtual DateTime? UpdatedAt
        {
            get;
            set;
        }

        public virtual AttributeSetInstanceExtensionFieldStateDto[] Fields
        {
            get;
            set;
        }

        IAttributeSetInstanceExtensionFieldStateDto[] IAttributeSetInstanceExtensionFieldGroupStateDto.Fields
        {
            get { return this.Fields; }
            set { this.Fields = value.Select(e => ((AttributeSetInstanceExtensionFieldStateDto)e)).ToArray(); }
        }

        public virtual IAttributeSetInstanceExtensionFieldGroupState ToAttributeSetInstanceExtensionFieldGroupState()
        {
            var state = new AttributeSetInstanceExtensionFieldGroupState(true);
            state.Id = this.Id;
            state.FieldType = this.FieldType;
            state.FieldLength = this.FieldLength;
            if (this.FieldCount != null && this.FieldCount.HasValue) { state.FieldCount = this.FieldCount.Value; }
            state.NameFormat = this.NameFormat;
            state.Description = this.Description;
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }
            if (this.Fields != null) { foreach (var s in this.Fields) { state.Fields.AddToSave(s.ToAttributeSetInstanceExtensionFieldState()); } };

            return state;
        }

    }

}

