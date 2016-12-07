﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{
	public interface IInOutLineMvoState : IInOutLineMvoStateProperties, 
		IGlobalIdentity<InOutLineId>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IInOutLineMvoStateCreated e);

		void When(IInOutLineMvoStateMergePatched e);

		void When(IInOutLineMvoStateDeleted e);

		void Mutate(IEvent e);


        bool IsUnsaved { get; }

	}
}

