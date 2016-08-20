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
	public interface IDayPlanCommand : ICommand, ICommandDto
	{

	}


	public interface ICreateOrMergePatchOrRemoveDayPlan : IDayPlanCommand
	{
		int Day { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }

		// Outer Id:

		PersonalName PersonalName { get; set; }

		// Outer Id:

		int Year { get; set; }

		// Outer Id:

		int Month { get; set; }


	}

	public interface ICreateDayPlan : ICreateOrMergePatchOrRemoveDayPlan
	{
	}

	public interface IMergePatchDayPlan : ICreateOrMergePatchOrRemoveDayPlan
	{

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IRemoveDayPlan : ICreateOrMergePatchOrRemoveDayPlan
	{
	}


}
