﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;

namespace Dddml.Wms.Domain
{

	public abstract class AttributeStateProperties : IAttributeStateProperties
	{
		public virtual string AttributeId { get; set; }

		public virtual string Name { get; set; }

		public virtual string Description { get; set; }

		public virtual bool IsMandatory { get; set; }

		public virtual bool IsInstanceAttribute { get; set; }

		public virtual string AttributeValueType { get; set; }

		public virtual int? AttributeValueLength { get; set; }

		public virtual bool IsList { get; set; }

		public virtual string FieldName { get; set; }

		public virtual string ReferenceId { get; set; }

		public virtual bool Active { get; set; }


	}
}
