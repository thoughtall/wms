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
	public interface IPermissionStateEvent : IEvent, IStateEventDto, IGlobalIdentity<PermissionStateEventId>, ICreated<string>
	{
		PermissionStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		string Name { get; set; }

		string ParentPermissionId { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }


	}

	public interface IPermissionStateCreated : IPermissionStateEvent//, IPermissionStateProperties
	{
	
	}


	public interface IPermissionStateMergePatched : IPermissionStateEvent//, IPermissionStateProperties
	{
		bool IsPropertyNameRemoved { get; set; }

		bool IsPropertyParentPermissionIdRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IPermissionStateDeleted : IPermissionStateEvent
	{
	}


}

