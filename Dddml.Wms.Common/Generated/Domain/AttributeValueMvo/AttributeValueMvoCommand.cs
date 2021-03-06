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

	public abstract class AttributeValueMvoCommandBase : IAttributeValueMvoCommand
	{
		public virtual AttributeValueId AttributeValueId { get; set; }


		AttributeValueId IAggregateCommand<AttributeValueId, long>.AggregateId
		{
			get
			{
				return this.AttributeValueId;
			}
		}


		long IAggregateCommand<AttributeValueId, long>.AggregateVersion
		{
			get
			{
				return this.AttributeVersion;
			}
		}

		public virtual long AttributeVersion { get; set; }

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

		public virtual string Name { get; set; }

		public virtual string Description { get; set; }

		public virtual string ReferenceId { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string AttributeName { get; set; }

		public virtual string AttributeOrganizationId { get; set; }

		public virtual string AttributeDescription { get; set; }

		public virtual bool? AttributeIsMandatory { get; set; }

		public virtual bool? AttributeIsInstanceAttribute { get; set; }

		public virtual string AttributeAttributeValueType { get; set; }

		public virtual int? AttributeAttributeValueLength { get; set; }

		public virtual bool? AttributeIsList { get; set; }

		public virtual string AttributeFieldName { get; set; }

		public virtual string AttributeReferenceId { get; set; }

		public virtual string AttributeCreatedBy { get; set; }

		public virtual DateTime? AttributeCreatedAt { get; set; }

		public virtual string AttributeUpdatedBy { get; set; }

		public virtual DateTime? AttributeUpdatedAt { get; set; }

		public virtual bool? AttributeActive { get; set; }

		public virtual bool? AttributeDeleted { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateAttributeValueMvo : AttributeValueMvoCommandBase, ICreateAttributeValueMvo
	{
		
		public CreateAttributeValueMvo ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchAttributeValueMvo :AttributeValueMvoCommandBase, IMergePatchAttributeValueMvo
	{

		public virtual bool IsPropertyNameRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyReferenceIdRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyAttributeNameRemoved { get; set; }

		public virtual bool IsPropertyAttributeOrganizationIdRemoved { get; set; }

		public virtual bool IsPropertyAttributeDescriptionRemoved { get; set; }

		public virtual bool IsPropertyAttributeIsMandatoryRemoved { get; set; }

		public virtual bool IsPropertyAttributeIsInstanceAttributeRemoved { get; set; }

		public virtual bool IsPropertyAttributeAttributeValueTypeRemoved { get; set; }

		public virtual bool IsPropertyAttributeAttributeValueLengthRemoved { get; set; }

		public virtual bool IsPropertyAttributeIsListRemoved { get; set; }

		public virtual bool IsPropertyAttributeFieldNameRemoved { get; set; }

		public virtual bool IsPropertyAttributeReferenceIdRemoved { get; set; }

		public virtual bool IsPropertyAttributeCreatedByRemoved { get; set; }

		public virtual bool IsPropertyAttributeCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyAttributeUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyAttributeUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyAttributeActiveRemoved { get; set; }

		public virtual bool IsPropertyAttributeDeletedRemoved { get; set; }


		public MergePatchAttributeValueMvo ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteAttributeValueMvo : AttributeValueMvoCommandBase, IDeleteAttributeValueMvo
	{
		public DeleteAttributeValueMvo ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class AttributeValueMvoCommands
    {
    }

}
