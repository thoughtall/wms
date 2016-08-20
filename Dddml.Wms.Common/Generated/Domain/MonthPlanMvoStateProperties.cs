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

	public abstract class MonthPlanMvoStateProperties : IMonthPlanMvoStateProperties
	{
		public virtual MonthPlanId MonthPlanId { get; set; }

		public virtual string Description { get; set; }

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

		public virtual string YearPlanDescription { get; set; }

		public virtual long YearPlanVersion { get; set; }

		public virtual string YearPlanCreatedBy { get; set; }

		public virtual DateTime YearPlanCreatedAt { get; set; }

		public virtual string YearPlanUpdatedBy { get; set; }

		public virtual DateTime YearPlanUpdatedAt { get; set; }

		public virtual bool YearPlanActive { get; set; }

		public virtual bool YearPlanDeleted { get; set; }

		public virtual DateTime PersonBirthDate { get; set; }

		public virtual PersonalName PersonLoves { get; set; }

		public virtual long PersonVersion { get; set; }

		public virtual string PersonCreatedBy { get; set; }

		public virtual DateTime PersonCreatedAt { get; set; }

		public virtual string PersonUpdatedBy { get; set; }

		public virtual DateTime PersonUpdatedAt { get; set; }

		public virtual bool PersonActive { get; set; }

		public virtual bool PersonDeleted { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}