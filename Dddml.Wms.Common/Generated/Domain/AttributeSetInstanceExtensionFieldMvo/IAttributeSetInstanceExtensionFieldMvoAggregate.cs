﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldMvo;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldMvo
{

	public partial interface IAttributeSetInstanceExtensionFieldMvoAggregate : IGlobalIdentity<AttributeSetInstanceExtensionFieldId>
	{
		IAttributeSetInstanceExtensionFieldMvoState State { get; }

		IList<IEvent> Changes { get; }

		void ThrowOnInvalidStateTransition (ICommand c);

		void Create (ICreateAttributeSetInstanceExtensionFieldMvo c);

		void MergePatch (IMergePatchAttributeSetInstanceExtensionFieldMvo c);

		void Delete (IDeleteAttributeSetInstanceExtensionFieldMvo c);


	}

}

