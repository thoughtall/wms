﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{

	public abstract class AttributeCommandDtoBase : ICommandDto, ICreateAttribute, IMergePatchAttribute, IDeleteAttribute
	{

		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteAttribute)this).AttributeId;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual string AttributeId { get; set; }

		public virtual string Name { get; set; }

		public virtual string OrganizationId { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? IsMandatory { get; set; }

		public virtual bool? IsInstanceAttribute { get; set; }

		public virtual string AttributeValueType { get; set; }

		public virtual int? AttributeValueLength { get; set; }

		public virtual bool? IsList { get; set; }

		public virtual string FieldName { get; set; }

		public virtual string ReferenceId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual bool? IsPropertyNameRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyNameRemoved
        {
            get
            {
                var b = this.IsPropertyNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrganizationIdRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyOrganizationIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrganizationIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrganizationIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsMandatoryRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyIsMandatoryRemoved
        {
            get
            {
                var b = this.IsPropertyIsMandatoryRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsMandatoryRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsInstanceAttributeRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyIsInstanceAttributeRemoved
        {
            get
            {
                var b = this.IsPropertyIsInstanceAttributeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsInstanceAttributeRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeValueTypeRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyAttributeValueTypeRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeValueTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeValueTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeValueLengthRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyAttributeValueLengthRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeValueLengthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeValueLengthRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsListRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyIsListRemoved
        {
            get
            {
                var b = this.IsPropertyIsListRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsListRemoved = value;
            }
        }

		public virtual bool? IsPropertyFieldNameRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyFieldNameRemoved
        {
            get
            {
                var b = this.IsPropertyFieldNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyFieldNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyReferenceIdRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyReferenceIdRemoved
        {
            get
            {
                var b = this.IsPropertyReferenceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyReferenceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyActiveRemoved
        {
            get
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

        ICreateAttributeValueCommands ICreateAttribute.AttributeValues
        {
            get
            {
                return this._attributeValues;
            }
        }

        IAttributeValueCommands IMergePatchAttribute.AttributeValueCommands
        {
            get
            {
                return this._attributeValues;
            }
        }

        public virtual CreateAttributeValueDto NewCreateAttributeValue()
        {
            var c = new CreateAttributeValueDto();
            c.AttributeId = this.AttributeId;

            return c;
        }

        ICreateAttributeValue ICreateAttribute.NewCreateAttributeValue()
        {
            return this.NewCreateAttributeValue();
        }

        ICreateAttributeValue IMergePatchAttribute.NewCreateAttributeValue()
        {
            return this.NewCreateAttributeValue();
        }

        public virtual MergePatchAttributeValueDto NewMergePatchAttributeValue()
        {
            var c = new MergePatchAttributeValueDto();
            c.AttributeId = this.AttributeId;

            return c;
        }

        IMergePatchAttributeValue IMergePatchAttribute.NewMergePatchAttributeValue()
        {
            return this.NewMergePatchAttributeValue();
        }

        public virtual RemoveAttributeValueDto NewRemoveAttributeValue()
        {
            var c = new RemoveAttributeValueDto();
            c.AttributeId = this.AttributeId;

            return c;
        }

        IRemoveAttributeValue IMergePatchAttribute.NewRemoveAttributeValue()
        {
            return this.NewRemoveAttributeValue();
        }

        private CreateOrMergePatchOrRemoveAttributeValueDtos _attributeValues = new CreateOrMergePatchOrRemoveAttributeValueDtos();

        public virtual CreateOrMergePatchOrRemoveAttributeValueDto[] AttributeValues
        {
            get
            {
                return _attributeValues.ToArray();
            }
            set
            {
                _attributeValues.Clear();
                _attributeValues.AddRange(value);
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteAttributeDto : AttributeCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateAttributeDto : CreateOrMergePatchOrDeleteAttributeDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchAttributeDto : CreateOrMergePatchOrDeleteAttributeDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteAttributeDto : CreateOrMergePatchOrDeleteAttributeDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}

    public static partial class AttributeCommandDtos
    {

    }

}

