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

	public partial class InOutStateDtoWrapper : StateDtoWrapperBase, IInOutStateDto, IInOutState
	{

        internal static IList<string> _collectionFieldNames = new string[] { "InOutLines" };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private InOutState _state;

        public InOutStateDtoWrapper()
        {
            this._state = new InOutState();
        }

		public InOutStateDtoWrapper(InOutState state)
		{
            this._state = state;
		}

		public IInOutState ToInOutState()
		{
			return this._state;
		}

		public virtual string DocumentNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DocumentNumber"))
                {
                    return _state.DocumentNumber;
                }
                return null;
            }
            set
            {
                _state.DocumentNumber = value;
            }
        }

        string IInOutStateProperties.DocumentNumber
        {
            get 
            {
                return (this._state as IInOutStateProperties).DocumentNumber;
            }
            set 
            {
                this._state.DocumentNumber = value;
            }
        }

		public virtual bool? IsSOTransaction
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsSOTransaction"))
                {
                    return _state.IsSOTransaction;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsSOTransaction = value.Value;
                }
            }
        }

        bool IInOutStateProperties.IsSOTransaction
        {
            get 
            {
                return (this._state as IInOutStateProperties).IsSOTransaction;
            }
            set 
            {
                this._state.IsSOTransaction = value;
            }
        }

		public virtual string DocumentStatus
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DocumentStatus"))
                {
                    return _state.DocumentStatus;
                }
                return null;
            }
            set
            {
                _state.DocumentStatus = value;
            }
        }

        string IInOutStateProperties.DocumentStatus
        {
            get 
            {
                return (this._state as IInOutStateProperties).DocumentStatus;
            }
            set 
            {
                this._state.DocumentStatus = value;
            }
        }

		public virtual bool? Posted
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Posted"))
                {
                    return _state.Posted;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Posted = value.Value;
                }
            }
        }

        bool IInOutStateProperties.Posted
        {
            get 
            {
                return (this._state as IInOutStateProperties).Posted;
            }
            set 
            {
                this._state.Posted = value;
            }
        }

		public virtual bool? Processing
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Processing"))
                {
                    return _state.Processing;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Processing = value.Value;
                }
            }
        }

        bool IInOutStateProperties.Processing
        {
            get 
            {
                return (this._state as IInOutStateProperties).Processing;
            }
            set 
            {
                this._state.Processing = value;
            }
        }

		public virtual bool? Processed
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Processed"))
                {
                    return _state.Processed;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Processed = value.Value;
                }
            }
        }

        bool IInOutStateProperties.Processed
        {
            get 
            {
                return (this._state as IInOutStateProperties).Processed;
            }
            set 
            {
                this._state.Processed = value;
            }
        }

		public virtual int? DocumentType
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DocumentType"))
                {
                    return _state.DocumentType;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.DocumentType = value.Value;
                }
            }
        }

        int IInOutStateProperties.DocumentType
        {
            get 
            {
                return (this._state as IInOutStateProperties).DocumentType;
            }
            set 
            {
                this._state.DocumentType = value;
            }
        }

		public virtual string Description
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Description"))
                {
                    return _state.Description;
                }
                return null;
            }
            set
            {
                _state.Description = value;
            }
        }

        string IInOutStateProperties.Description
        {
            get 
            {
                return (this._state as IInOutStateProperties).Description;
            }
            set 
            {
                this._state.Description = value;
            }
        }

		public virtual string OrderNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrderNumber"))
                {
                    return _state.OrderNumber;
                }
                return null;
            }
            set
            {
                _state.OrderNumber = value;
            }
        }

        string IInOutStateProperties.OrderNumber
        {
            get 
            {
                return (this._state as IInOutStateProperties).OrderNumber;
            }
            set 
            {
                this._state.OrderNumber = value;
            }
        }

		public virtual DateTime? DateOrdered
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DateOrdered"))
                {
                    return _state.DateOrdered;
                }
                return null;
            }
            set
            {
                _state.DateOrdered = value;
            }
        }

        DateTime? IInOutStateProperties.DateOrdered
        {
            get 
            {
                return (this._state as IInOutStateProperties).DateOrdered;
            }
            set 
            {
                this._state.DateOrdered = value;
            }
        }

		public virtual bool? IsPrinted
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsPrinted"))
                {
                    return _state.IsPrinted;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsPrinted = value.Value;
                }
            }
        }

        bool IInOutStateProperties.IsPrinted
        {
            get 
            {
                return (this._state as IInOutStateProperties).IsPrinted;
            }
            set 
            {
                this._state.IsPrinted = value;
            }
        }

		public virtual string MovementType
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("MovementType"))
                {
                    return _state.MovementType;
                }
                return null;
            }
            set
            {
                _state.MovementType = value;
            }
        }

        string IInOutStateProperties.MovementType
        {
            get 
            {
                return (this._state as IInOutStateProperties).MovementType;
            }
            set 
            {
                this._state.MovementType = value;
            }
        }

		public virtual DateTime? MovementDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("MovementDate"))
                {
                    return _state.MovementDate;
                }
                return null;
            }
            set
            {
                _state.MovementDate = value;
            }
        }

        DateTime? IInOutStateProperties.MovementDate
        {
            get 
            {
                return (this._state as IInOutStateProperties).MovementDate;
            }
            set 
            {
                this._state.MovementDate = value;
            }
        }

		public virtual string BusinessPartnerId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("BusinessPartnerId"))
                {
                    return _state.BusinessPartnerId;
                }
                return null;
            }
            set
            {
                _state.BusinessPartnerId = value;
            }
        }

        string IInOutStateProperties.BusinessPartnerId
        {
            get 
            {
                return (this._state as IInOutStateProperties).BusinessPartnerId;
            }
            set 
            {
                this._state.BusinessPartnerId = value;
            }
        }

		public virtual string WarehouseId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("WarehouseId"))
                {
                    return _state.WarehouseId;
                }
                return null;
            }
            set
            {
                _state.WarehouseId = value;
            }
        }

        string IInOutStateProperties.WarehouseId
        {
            get 
            {
                return (this._state as IInOutStateProperties).WarehouseId;
            }
            set 
            {
                this._state.WarehouseId = value;
            }
        }

		public virtual string POReference
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("POReference"))
                {
                    return _state.POReference;
                }
                return null;
            }
            set
            {
                _state.POReference = value;
            }
        }

        string IInOutStateProperties.POReference
        {
            get 
            {
                return (this._state as IInOutStateProperties).POReference;
            }
            set 
            {
                this._state.POReference = value;
            }
        }

		public virtual Money? FreightAmount
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("FreightAmount"))
                {
                    return _state.FreightAmount;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.FreightAmount = value.Value;
                }
            }
        }

        Money IInOutStateProperties.FreightAmount
        {
            get 
            {
                return (this._state as IInOutStateProperties).FreightAmount;
            }
            set 
            {
                this._state.FreightAmount = value;
            }
        }

		public virtual string ShipperId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ShipperId"))
                {
                    return _state.ShipperId;
                }
                return null;
            }
            set
            {
                _state.ShipperId = value;
            }
        }

        string IInOutStateProperties.ShipperId
        {
            get 
            {
                return (this._state as IInOutStateProperties).ShipperId;
            }
            set 
            {
                this._state.ShipperId = value;
            }
        }

		public virtual Money? ChargeAmount
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ChargeAmount"))
                {
                    return _state.ChargeAmount;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.ChargeAmount = value.Value;
                }
            }
        }

        Money IInOutStateProperties.ChargeAmount
        {
            get 
            {
                return (this._state as IInOutStateProperties).ChargeAmount;
            }
            set 
            {
                this._state.ChargeAmount = value;
            }
        }

		public virtual DateTime? DatePrinted
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DatePrinted"))
                {
                    return _state.DatePrinted;
                }
                return null;
            }
            set
            {
                _state.DatePrinted = value;
            }
        }

        DateTime? IInOutStateProperties.DatePrinted
        {
            get 
            {
                return (this._state as IInOutStateProperties).DatePrinted;
            }
            set 
            {
                this._state.DatePrinted = value;
            }
        }

		public virtual string SalesRepresentative
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SalesRepresentative"))
                {
                    return _state.SalesRepresentative;
                }
                return null;
            }
            set
            {
                _state.SalesRepresentative = value;
            }
        }

        string IInOutStateProperties.SalesRepresentative
        {
            get 
            {
                return (this._state as IInOutStateProperties).SalesRepresentative;
            }
            set 
            {
                this._state.SalesRepresentative = value;
            }
        }

		public virtual int? NumberOfPackages
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("NumberOfPackages"))
                {
                    return _state.NumberOfPackages;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.NumberOfPackages = value.Value;
                }
            }
        }

        int IInOutStateProperties.NumberOfPackages
        {
            get 
            {
                return (this._state as IInOutStateProperties).NumberOfPackages;
            }
            set 
            {
                this._state.NumberOfPackages = value;
            }
        }

		public virtual DateTime? PickDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PickDate"))
                {
                    return _state.PickDate;
                }
                return null;
            }
            set
            {
                _state.PickDate = value;
            }
        }

        DateTime? IInOutStateProperties.PickDate
        {
            get 
            {
                return (this._state as IInOutStateProperties).PickDate;
            }
            set 
            {
                this._state.PickDate = value;
            }
        }

		public virtual DateTime? ShipDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ShipDate"))
                {
                    return _state.ShipDate;
                }
                return null;
            }
            set
            {
                _state.ShipDate = value;
            }
        }

        DateTime? IInOutStateProperties.ShipDate
        {
            get 
            {
                return (this._state as IInOutStateProperties).ShipDate;
            }
            set 
            {
                this._state.ShipDate = value;
            }
        }

		public virtual string TrackingNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("TrackingNumber"))
                {
                    return _state.TrackingNumber;
                }
                return null;
            }
            set
            {
                _state.TrackingNumber = value;
            }
        }

        string IInOutStateProperties.TrackingNumber
        {
            get 
            {
                return (this._state as IInOutStateProperties).TrackingNumber;
            }
            set 
            {
                this._state.TrackingNumber = value;
            }
        }

		public virtual DateTime? DateReceived
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DateReceived"))
                {
                    return _state.DateReceived;
                }
                return null;
            }
            set
            {
                _state.DateReceived = value;
            }
        }

        DateTime? IInOutStateProperties.DateReceived
        {
            get 
            {
                return (this._state as IInOutStateProperties).DateReceived;
            }
            set 
            {
                this._state.DateReceived = value;
            }
        }

		public virtual bool? IsInTransit
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsInTransit"))
                {
                    return _state.IsInTransit;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsInTransit = value.Value;
                }
            }
        }

        bool IInOutStateProperties.IsInTransit
        {
            get 
            {
                return (this._state as IInOutStateProperties).IsInTransit;
            }
            set 
            {
                this._state.IsInTransit = value;
            }
        }

		public virtual bool? IsApproved
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsApproved"))
                {
                    return _state.IsApproved;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsApproved = value.Value;
                }
            }
        }

        bool IInOutStateProperties.IsApproved
        {
            get 
            {
                return (this._state as IInOutStateProperties).IsApproved;
            }
            set 
            {
                this._state.IsApproved = value;
            }
        }

		public virtual bool? IsInDispute
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsInDispute"))
                {
                    return _state.IsInDispute;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsInDispute = value.Value;
                }
            }
        }

        bool IInOutStateProperties.IsInDispute
        {
            get 
            {
                return (this._state as IInOutStateProperties).IsInDispute;
            }
            set 
            {
                this._state.IsInDispute = value;
            }
        }

		public virtual decimal? Volume
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Volume"))
                {
                    return _state.Volume;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Volume = value.Value;
                }
            }
        }

        decimal IInOutStateProperties.Volume
        {
            get 
            {
                return (this._state as IInOutStateProperties).Volume;
            }
            set 
            {
                this._state.Volume = value;
            }
        }

		public virtual decimal? Weight
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Weight"))
                {
                    return _state.Weight;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Weight = value.Value;
                }
            }
        }

        decimal IInOutStateProperties.Weight
        {
            get 
            {
                return (this._state as IInOutStateProperties).Weight;
            }
            set 
            {
                this._state.Weight = value;
            }
        }

		public virtual string RmaNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("RmaNumber"))
                {
                    return _state.RmaNumber;
                }
                return null;
            }
            set
            {
                _state.RmaNumber = value;
            }
        }

        string IInOutStateProperties.RmaNumber
        {
            get 
            {
                return (this._state as IInOutStateProperties).RmaNumber;
            }
            set 
            {
                this._state.RmaNumber = value;
            }
        }

		public virtual string ReversalNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ReversalNumber"))
                {
                    return _state.ReversalNumber;
                }
                return null;
            }
            set
            {
                _state.ReversalNumber = value;
            }
        }

        string IInOutStateProperties.ReversalNumber
        {
            get 
            {
                return (this._state as IInOutStateProperties).ReversalNumber;
            }
            set 
            {
                this._state.ReversalNumber = value;
            }
        }

		public virtual bool? IsDropShip
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsDropShip"))
                {
                    return _state.IsDropShip;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsDropShip = value.Value;
                }
            }
        }

        bool IInOutStateProperties.IsDropShip
        {
            get 
            {
                return (this._state as IInOutStateProperties).IsDropShip;
            }
            set 
            {
                this._state.IsDropShip = value;
            }
        }

		public virtual string DropShipBusinessPartnerId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DropShipBusinessPartnerId"))
                {
                    return _state.DropShipBusinessPartnerId;
                }
                return null;
            }
            set
            {
                _state.DropShipBusinessPartnerId = value;
            }
        }

        string IInOutStateProperties.DropShipBusinessPartnerId
        {
            get 
            {
                return (this._state as IInOutStateProperties).DropShipBusinessPartnerId;
            }
            set 
            {
                this._state.DropShipBusinessPartnerId = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return _state.Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Active = value.Value;
                }
            }
        }

        bool IInOutStateProperties.Active
        {
            get 
            {
                return (this._state as IInOutStateProperties).Active;
            }
            set 
            {
                this._state.Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return _state.Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Version = value.Value;
                }
            }
        }

        long IInOutStateProperties.Version
        {
            get 
            {
                return (this._state as IInOutStateProperties).Version;
            }
            set 
            {
                this._state.Version = value;
            }
        }

		public virtual string CreatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CreatedBy"))
                {
                    return _state.CreatedBy;
                }
                return null;
            }
            set
            {
                _state.CreatedBy = value;
            }
        }
		public virtual DateTime? CreatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CreatedAt"))
                {
                    return _state.CreatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.CreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.CreatedAt = value.Value;
                }
            }
        }
		public virtual string UpdatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UpdatedBy"))
                {
                    return _state.UpdatedBy;
                }
                return null;
            }
            set
            {
                _state.UpdatedBy = value;
            }
        }
		public virtual DateTime? UpdatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UpdatedAt"))
                {
                    return _state.UpdatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.UpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UpdatedAt = value.Value;
                }
            }
        }

		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get { return (_state as IInOutState).GlobalId; }
		}

		#endregion


		#region IActive implementation

		bool IActive.Active
		{
            get { return (_state as IActive).Active; }
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
            get { return (_state as IDeleted).Deleted; }
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
            get { return (_state as IInOutState).CreatedBy; }
            set { (_state as IInOutState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IInOutState).CreatedAt; }
            set { (_state as IInOutState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IInOutState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IInOutState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.Version; }
		}

		#endregion

        bool IInOutState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == InOutState.VersionZero; }
        }

        public virtual IInOutLineStateDto[] InOutLines
        {
            get 
            {
                if (!(this as IStateDtoWrapper).ReturnedFieldsContains("InOutLines"))
                {
                    return null;
                }
                var dtos = new List<IInOutLineStateDto>();
                if (this._state.InOutLines != null)
                {
                    foreach (var s in this._state.InOutLines)
                    {
                        var dto = new InOutLineStateDtoWrapper((InOutLineState)s);
                        var returnFS = CollectionUtils.DictionaryGetValueIgnoringCase(ReturnedFields, "InOutLines");
                        if (!String.IsNullOrWhiteSpace(returnFS))
                        {
                            (dto as IStateDtoWrapper).ReturnedFieldsString = returnFS;
                        }
                        else
                        {
                            (dto as IStateDtoWrapper).AllFieldsReturned = this.AllFieldsReturned;
                        }
                        dtos.Add(dto);
                    }
                }
                return dtos.ToArray();
            }
            set 
            {
                if (value == null) { value = new InOutLineStateDtoWrapper[0]; }
                var states = new List<IInOutLineState>();
                foreach (var s in value)
                {
                    states.Add(s.ToInOutLineState());
                }
                this._state.SetInOutLines(new DtoInOutLineStates(this._state, states));
            }
        }

        IInOutLineStates IInOutState.InOutLines
        {
            get { return _state.InOutLines; }
        }


		void IInOutState.When(IInOutStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IInOutState.When(IInOutStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IInOutState.When(IInOutStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IInOutState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


        public class DtoInOutLineStates : IInOutLineStates
        {

            private IInOutState _outerState;

            private IEnumerable<IInOutLineState> _innerStates;

            public DtoInOutLineStates(IInOutState outerState, IEnumerable<IInOutLineState> innerStates)
            {
                this._outerState = outerState;
                if (innerStates == null)
                {
                    this._innerStates = new IInOutLineState[] { };
                }
                else
                {
                    this._innerStates = innerStates;
                }
            }

            public IEnumerator<IInOutLineState> GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            public IInOutLineState Get(SkuId skuId)
            {
                throw new NotSupportedException();
            }

            public IInOutLineState Get(SkuId skuId, bool forCreation)
            {
                throw new NotSupportedException();
            }

            public void Remove(IInOutLineState state)
            {
                throw new NotSupportedException();
            }

            public void AddToSave(IInOutLineState state)
            {
                throw new NotSupportedException();
            }

            public void Save()
            {
                throw new NotSupportedException();
            }
        }

	}

    partial class InOutStateDtoWrapperCollection : StateDtoWrapperCollectionBase<InOutStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(InOutStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

