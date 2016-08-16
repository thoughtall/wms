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

	public abstract class MonthPlanMvoCommandBase : IMonthPlanMvoCommand
	{
		public virtual MonthPlanId MonthPlanId { get; set; }


		MonthPlanId IAggregateCommand<MonthPlanId, long>.AggregateId
		{
			get
			{
				return this.MonthPlanId;
			}
		}


		long IAggregateCommand<MonthPlanId, long>.AggregateVersion
		{
			get
			{
				return this.PersonVersion;
			}
		}

		public virtual long PersonVersion { get; set; }

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

		public virtual string Description { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string YearPlanDescription { get; set; }

		public virtual long? YearPlanVersion { get; set; }

		public virtual string YearPlanCreatedBy { get; set; }

		public virtual DateTime? YearPlanCreatedAt { get; set; }

		public virtual string YearPlanUpdatedBy { get; set; }

		public virtual DateTime? YearPlanUpdatedAt { get; set; }

		public virtual bool? YearPlanActive { get; set; }

		public virtual bool? YearPlanDeleted { get; set; }

		public virtual DateTime? PersonBirthDate { get; set; }

		public virtual PersonalName PersonLoves { get; set; }

		public virtual string PersonCreatedBy { get; set; }

		public virtual DateTime? PersonCreatedAt { get; set; }

		public virtual string PersonUpdatedBy { get; set; }

		public virtual DateTime? PersonUpdatedAt { get; set; }

		public virtual bool? PersonActive { get; set; }

		public virtual bool? PersonDeleted { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


    public abstract class MonthPlanMvoIdGeneratorBase : IIdGenerator<MonthPlanId, ICreateMonthPlanMvo>
    {
        public abstract MonthPlanId GenerateId(ICreateMonthPlanMvo command);

        public abstract MonthPlanId GetNextId();

        public virtual MonthPlanId GetOrGenerateId(ICreateMonthPlanMvo command, out bool reused)
        {
            throw new NotSupportedException();
        }

    }

	public class CreateMonthPlanMvo : MonthPlanMvoCommandBase, ICreateMonthPlanMvo
	{
		
		public CreateMonthPlanMvo ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchMonthPlanMvo :MonthPlanMvoCommandBase, IMergePatchMonthPlanMvo
	{

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyYearPlanDescriptionRemoved { get; set; }

		public virtual bool IsPropertyYearPlanVersionRemoved { get; set; }

		public virtual bool IsPropertyYearPlanCreatedByRemoved { get; set; }

		public virtual bool IsPropertyYearPlanCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyYearPlanUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyYearPlanUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyYearPlanActiveRemoved { get; set; }

		public virtual bool IsPropertyYearPlanDeletedRemoved { get; set; }

		public virtual bool IsPropertyPersonBirthDateRemoved { get; set; }

		public virtual bool IsPropertyPersonLovesRemoved { get; set; }

		public virtual bool IsPropertyPersonCreatedByRemoved { get; set; }

		public virtual bool IsPropertyPersonCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyPersonUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyPersonUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyPersonActiveRemoved { get; set; }

		public virtual bool IsPropertyPersonDeletedRemoved { get; set; }


		public MergePatchMonthPlanMvo ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteMonthPlanMvo : MonthPlanMvoCommandBase, IDeleteMonthPlanMvo
	{
		public DeleteMonthPlanMvo ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}



}

