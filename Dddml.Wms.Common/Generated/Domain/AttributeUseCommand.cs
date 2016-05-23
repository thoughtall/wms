﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

	public abstract class AttributeUseCommandBase : AttributeUseStateProperties, IAttributeUseCommand
	{

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

	}

    public abstract class AttributeUseIdGeneratorBase : IIdGenerator<string, ICreateAttributeUse>
    {
        public abstract string GenerateId(ICreateAttributeUse command);

        public abstract string GetNextId();

        public virtual string GetOrGenerateId(ICreateAttributeUse command, out bool reused)
        {
            throw new NotSupportedException();
        }

    }

	public class CreateAttributeUse : AttributeUseCommandBase, ICreateAttributeUse
	{
		
		public CreateAttributeUse ()
		{
		}


	}


	public class MergePatchAttributeUse :AttributeUseCommandBase, IMergePatchAttributeUse
	{

		public virtual bool IsPropertySequenceNumberRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchAttributeUse ()
		{
		}


	}

	public class RemoveAttributeUse : AttributeUseCommandBase, IRemoveAttributeUse
	{
		public RemoveAttributeUse ()
		{
		}
	}



}

