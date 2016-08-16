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

	public abstract class PersonStateEventBase : IPersonStateEvent
	{

		public virtual PersonStateEventId StateEventId { get; set; }

		public virtual DateTime? BirthDate { get; set; }

		public virtual PersonalName Loves { get; set; }

		public virtual bool? Active { get; set; }


		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		PersonStateEventId IGlobalIdentity<PersonStateEventId>.GlobalId {
			get {
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IPersonStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }


		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}

        protected PersonStateEventBase()
        {
        }

        protected PersonStateEventBase(PersonStateEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }

		protected IYearPlanStateEventDao YearPlanStateEventDao
		{
			get { return ApplicationContext.Current["YearPlanStateEventDao"] as IYearPlanStateEventDao; }
		}

        protected YearPlanStateEventId NewYearPlanStateEventId(int year)
        {
            var stateEventId = new YearPlanStateEventId(this.StateEventId.PersonalName, year, this.StateEventId.Version);
            return stateEventId;
        }


        protected void ThrowOnInconsistentEventIds(IYearPlanStateEvent e)
        {
            ThrowOnInconsistentEventIds(this, e);
        }

		public static void ThrowOnInconsistentEventIds(IPersonStateEvent oe, IYearPlanStateEvent e)
		{
			if (!oe.StateEventId.PersonalName.Equals(e.StateEventId.PersonalName))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id PersonalName {0} but inner id PersonalName {1}", 
					oe.StateEventId.PersonalName, e.StateEventId.PersonalName);
			}
		}



        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class PersonStateCreated : PersonStateEventBase, IPersonStateCreated, ISaveable
	{
		public PersonStateCreated ()
		{
		}

		public PersonStateCreated (PersonStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<YearPlanStateEventId, IYearPlanStateCreated> _yearPlanEvents = new Dictionary<YearPlanStateEventId, IYearPlanStateCreated>();
		
        private IEnumerable<IYearPlanStateCreated> _readOnlyYearPlanEvents;

        public virtual IEnumerable<IYearPlanStateCreated> YearPlanEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
					return this._yearPlanEvents.Values;
                }
                else
                {
                    if (_readOnlyYearPlanEvents != null) { return _readOnlyYearPlanEvents; }
                    var eventDao = YearPlanStateEventDao;
                    var eL = new List<IYearPlanStateCreated>();
                    foreach (var e in eventDao.FindByPersonStateEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IYearPlanStateCreated)e);
                    }
                    return (_readOnlyYearPlanEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddYearPlanEvent(e);
                    }
                }
                else { this._yearPlanEvents.Clear(); }
            }
        }
	
		public virtual void AddYearPlanEvent(IYearPlanStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._yearPlanEvents[e.StateEventId] = e;
		}

        public virtual IYearPlanStateCreated NewYearPlanStateCreated(int year)
        {
            var stateEvent = new YearPlanStateCreated(NewYearPlanStateEventId(year));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IYearPlanStateCreated e in this.YearPlanEvents) {
				YearPlanStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class PersonStateMergePatched : PersonStateEventBase, IPersonStateMergePatched, ISaveable
	{
		public virtual bool IsPropertyBirthDateRemoved { get; set; }

		public virtual bool IsPropertyLovesRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public PersonStateMergePatched ()
		{
		}

		public PersonStateMergePatched (PersonStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<YearPlanStateEventId, IYearPlanStateEvent> _yearPlanEvents = new Dictionary<YearPlanStateEventId, IYearPlanStateEvent>();

	    private IEnumerable<IYearPlanStateEvent> _readOnlyYearPlanEvents;
		
        public virtual IEnumerable<IYearPlanStateEvent> YearPlanEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
					return this._yearPlanEvents.Values;
                }
                else
                {
                    if (_readOnlyYearPlanEvents != null) { return _readOnlyYearPlanEvents; }
                    var eventDao = YearPlanStateEventDao;
                    var eL = new List<IYearPlanStateEvent>();
                    foreach (var e in eventDao.FindByPersonStateEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IYearPlanStateEvent)e);
                    }
                    return (_readOnlyYearPlanEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddYearPlanEvent(e);
                    }
                }
                else { this._yearPlanEvents.Clear(); }
            }
        }

		public virtual void AddYearPlanEvent(IYearPlanStateEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._yearPlanEvents[e.StateEventId] = e;
		}

        public virtual IYearPlanStateCreated NewYearPlanStateCreated(int year)
        {
            var stateEvent = new YearPlanStateCreated(NewYearPlanStateEventId(year));
            return stateEvent;
        }

        public virtual IYearPlanStateMergePatched NewYearPlanStateMergePatched(int year)
        {
            var stateEvent = new YearPlanStateMergePatched(NewYearPlanStateEventId(year));
            return stateEvent;
        }

        public virtual IYearPlanStateRemoved NewYearPlanStateRemoved(int year)
        {
            var stateEvent = new YearPlanStateRemoved(NewYearPlanStateEventId(year));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IYearPlanStateEvent e in this.YearPlanEvents) {
				YearPlanStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class PersonStateDeleted : PersonStateEventBase, IPersonStateDeleted, ISaveable
	{
		public PersonStateDeleted ()
		{
		}

		public PersonStateDeleted (PersonStateEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

		private Dictionary<YearPlanStateEventId, IYearPlanStateRemoved> _yearPlanEvents = new Dictionary<YearPlanStateEventId, IYearPlanStateRemoved>();
		
        private IEnumerable<IYearPlanStateRemoved> _readOnlyYearPlanEvents;

        public virtual IEnumerable<IYearPlanStateRemoved> YearPlanEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
					return this._yearPlanEvents.Values;
                }
                else
                {
                    if (_readOnlyYearPlanEvents != null) { return _readOnlyYearPlanEvents; }
                    var eventDao = YearPlanStateEventDao;
                    var eL = new List<IYearPlanStateRemoved>();
                    foreach (var e in eventDao.FindByPersonStateEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IYearPlanStateRemoved)e);
                    }
                    return (_readOnlyYearPlanEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddYearPlanEvent(e);
                    }
                }
                else { this._yearPlanEvents.Clear(); }
            }
        }
	
		public virtual void AddYearPlanEvent(IYearPlanStateRemoved e)
		{
			ThrowOnInconsistentEventIds(e);
			this._yearPlanEvents[e.StateEventId] = e;
		}

        public virtual IYearPlanStateRemoved NewYearPlanStateRemoved(int year)
        {
            var stateEvent = new YearPlanStateRemoved(NewYearPlanStateEventId(year));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IYearPlanStateRemoved e in this.YearPlanEvents) {
				YearPlanStateEventDao.Save(e);
			}
		}


	}



}

