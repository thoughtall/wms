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

	public static partial class MonthPlanMvoStateExtensions
	{

        public static IMonthPlanMvoCommand ToCreateOrMergePatchMonthPlanMvo(this MonthPlanMvoState state)
        {
            return state.ToCreateOrMergePatchMonthPlanMvo<CreateMonthPlanMvo, MergePatchMonthPlanMvo>();
        }

        public static DeleteMonthPlanMvo ToDeleteMonthPlanMvo(this MonthPlanMvoState state)
        {
            return state.ToDeleteMonthPlanMvo<DeleteMonthPlanMvo>();
        }

        public static MergePatchMonthPlanMvo ToMergePatchMonthPlanMvo(this MonthPlanMvoState state)
        {
            return state.ToMergePatchMonthPlanMvo<MergePatchMonthPlanMvo>();
        }

        public static CreateMonthPlanMvo ToCreateMonthPlanMvo(this MonthPlanMvoState state)
        {
            return state.ToCreateMonthPlanMvo<CreateMonthPlanMvo>();
        }
		

	}

}

