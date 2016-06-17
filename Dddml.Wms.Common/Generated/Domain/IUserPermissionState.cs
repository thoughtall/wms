﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{
	public interface IUserPermissionState : IUserPermissionStateProperties, 
		IGlobalIdentity<UserPermissionId>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IVersioned<long>
	{
		
		void When(IUserPermissionStateCreated e);

		void When(IUserPermissionStateMergePatched e);

		void When(IUserPermissionStateDeleted e);

		void Mutate(IEvent e);


	}
}
