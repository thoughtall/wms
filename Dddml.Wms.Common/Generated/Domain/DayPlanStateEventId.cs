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

	public class DayPlanStateEventId
	{

		private PersonalName _personalName = new PersonalName();

		public virtual PersonalName PersonalName { 
			get { return this._personalName; } 
			internal set { _personalName = value; } 
		}

		private int _year;

		public virtual int Year { 
			get { return this._year; } 
			internal set { _year = value; } 
		}

		private int _month;

		public virtual int Month { 
			get { return this._month; } 
			internal set { _month = value; } 
		}

		private int _day;

		public virtual int Day { 
			get { return this._day; } 
			internal set { _day = value; } 
		}

		private long _personVersion;

		public virtual long PersonVersion { 
			get { return this._personVersion; } 
			internal set { _personVersion = value; } 
		}


        #region  Flattened Properties


		public virtual string PersonalNameFirstName {
			get { return PersonalName.FirstName; }
			internal set { PersonalName.FirstName = value; }
		}

		public virtual string PersonalNameLastName {
			get { return PersonalName.LastName; }
			internal set { PersonalName.LastName = value; }
		}

        #endregion

		internal DayPlanStateEventId ()
		{
		}

		public DayPlanStateEventId (PersonalName personalName, int year, int month, int day, long personVersion)
		{
			this._personalName = personalName;
			this._year = year;
			this._month = month;
			this._day = day;
			this._personVersion = personVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			DayPlanStateEventId other = obj as DayPlanStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.PersonalName, other.PersonalName)
				&& Object.Equals (this.Year, other.Year)
				&& Object.Equals (this.Month, other.Month)
				&& Object.Equals (this.Day, other.Day)
				&& Object.Equals (this.PersonVersion, other.PersonVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.PersonalName != null) {
				hash += 13 * this.PersonalName.GetHashCode ();
			}
			if (this.Year != null) {
				hash += 13 * this.Year.GetHashCode ();
			}
			if (this.Month != null) {
				hash += 13 * this.Month.GetHashCode ();
			}
			if (this.Day != null) {
				hash += 13 * this.Day.GetHashCode ();
			}
			if (this.PersonVersion != null) {
				hash += 13 * this.PersonVersion.GetHashCode ();
			}
			return hash;
		}

	}

}


