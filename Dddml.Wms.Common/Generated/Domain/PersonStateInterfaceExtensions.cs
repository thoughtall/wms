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

	public static partial class PersonStateInterfaceExtensions
	{

        public static IPersonCommand ToCreateOrMergePatchPerson<TCreatePerson, TMergePatchPerson, TCreateYearPlan, TMergePatchYearPlan, TCreateMonthPlan, TMergePatchMonthPlan, TCreateDayPlan, TMergePatchDayPlan>(this IPersonState state)
            where TCreatePerson : ICreatePerson, new()
            where TMergePatchPerson : IMergePatchPerson, new()
            where TCreateYearPlan : ICreateYearPlan, new()
            where TMergePatchYearPlan : IMergePatchYearPlan, new()
            where TCreateMonthPlan : ICreateMonthPlan, new()
            where TMergePatchMonthPlan : IMergePatchMonthPlan, new()
            where TCreateDayPlan : ICreateDayPlan, new()
            where TMergePatchDayPlan : IMergePatchDayPlan, new()
        {
            bool bUnsaved = ((IPersonState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreatePerson<TCreatePerson, TCreateYearPlan, TCreateMonthPlan, TCreateDayPlan>();
            }
            else 
            {
                return state.ToMergePatchPerson<TMergePatchPerson, TCreateYearPlan, TMergePatchYearPlan, TCreateMonthPlan, TMergePatchMonthPlan, TCreateDayPlan, TMergePatchDayPlan>();
            }
        }

        public static TDeletePerson ToDeletePerson<TDeletePerson>(this IPersonState state)
            where TDeletePerson : IDeletePerson, new()
        {
            var cmd = new TDeletePerson();
            cmd.PersonalName = state.PersonalName;
            cmd.Version = ((IPersonStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchPerson ToMergePatchPerson<TMergePatchPerson, TCreateYearPlan, TMergePatchYearPlan, TCreateMonthPlan, TMergePatchMonthPlan, TCreateDayPlan, TMergePatchDayPlan>(this IPersonState state)
            where TMergePatchPerson : IMergePatchPerson, new()
            where TCreateYearPlan : ICreateYearPlan, new()
            where TMergePatchYearPlan : IMergePatchYearPlan, new()
            where TCreateMonthPlan : ICreateMonthPlan, new()
            where TMergePatchMonthPlan : IMergePatchMonthPlan, new()
            where TCreateDayPlan : ICreateDayPlan, new()
            where TMergePatchDayPlan : IMergePatchDayPlan, new()
        {
            var cmd = new TMergePatchPerson();

            cmd.Version = ((IPersonStateProperties)state).Version;

            cmd.PersonalName = state.PersonalName;
            cmd.BirthDate = state.BirthDate;
            cmd.Loves = state.Loves;
            cmd.Active = ((IPersonStateProperties)state).Active;
            
            if (state.Loves == null) { cmd.IsPropertyLovesRemoved = true; }
            foreach (var d in state.YearPlans)
            {
                var c = d.ToCreateOrMergePatchYearPlan<TCreateYearPlan, TMergePatchYearPlan, TCreateMonthPlan, TMergePatchMonthPlan, TCreateDayPlan, TMergePatchDayPlan>();
                cmd.YearPlanCommands.Add(c);
            }
            return cmd;
        }

        public static TCreatePerson ToCreatePerson<TCreatePerson, TCreateYearPlan, TCreateMonthPlan, TCreateDayPlan>(this IPersonState state)
            where TCreatePerson : ICreatePerson, new()
            where TCreateYearPlan : ICreateYearPlan, new()
            where TCreateMonthPlan : ICreateMonthPlan, new()
            where TCreateDayPlan : ICreateDayPlan, new()
        {
            var cmd = new TCreatePerson();

            cmd.Version = ((IPersonStateProperties)state).Version;

            cmd.PersonalName = state.PersonalName;
            cmd.BirthDate = state.BirthDate;
            cmd.Loves = state.Loves;
            cmd.Active = ((IPersonStateProperties)state).Active;
            foreach (var d in state.YearPlans)
            {
                var c = d.ToCreateYearPlan<TCreateYearPlan, TCreateMonthPlan, TCreateDayPlan>();
                cmd.YearPlans.Add(c);
            }
            return cmd;
        }
		

	}

}
