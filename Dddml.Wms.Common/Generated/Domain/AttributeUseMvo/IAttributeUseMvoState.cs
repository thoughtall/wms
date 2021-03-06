﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeUseMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeUseMvo;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeUseMvo
{
	public interface IAttributeUseMvoState : IAttributeUseMvoStateProperties, 
		IGlobalIdentity<AttributeSetAttributeUseId>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IAggregateVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IAttributeUseMvoStateCreated e);

		void When(IAttributeUseMvoStateMergePatched e);

		void When(IAttributeUseMvoStateDeleted e);

		void Mutate(IEvent e);


        bool IsUnsaved { get; }

	}
}

