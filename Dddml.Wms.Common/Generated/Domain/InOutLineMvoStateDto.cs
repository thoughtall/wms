﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{

    public partial class InOutLineMvoStateDto : IInOutLineMvoStateDto
    {

        public virtual InOutLineIdDto InOutLineId
        {
            get;
            set;
        }

        public virtual long? LineNumber
        {
            get;
            set;
        }

        public virtual string Description
        {
            get;
            set;
        }

        public virtual string LocatorId
        {
            get;
            set;
        }

        public virtual string Product
        {
            get;
            set;
        }

        public virtual string UomId
        {
            get;
            set;
        }

        public virtual decimal? MovementQuantity
        {
            get;
            set;
        }

        public virtual decimal? ConfirmedQuantity
        {
            get;
            set;
        }

        public virtual decimal? ScrappedQuantity
        {
            get;
            set;
        }

        public virtual decimal? TargetQuantity
        {
            get;
            set;
        }

        public virtual decimal? PickedQuantity
        {
            get;
            set;
        }

        public virtual bool? IsInvoiced
        {
            get;
            set;
        }

        public virtual string AttributeSetInstanceId
        {
            get;
            set;
        }

        public virtual bool? IsDescription
        {
            get;
            set;
        }

        public virtual bool? Processed
        {
            get;
            set;
        }

        public virtual decimal? QuantityEntered
        {
            get;
            set;
        }

        public virtual long? RmaLineNumber
        {
            get;
            set;
        }

        public virtual long? ReversalLineNumber
        {
            get;
            set;
        }

        public virtual long? Version
        {
            get;
            set;
        }

        public virtual bool? Active
        {
            get;
            set;
        }

        public virtual bool? InOutIsSOTransaction
        {
            get;
            set;
        }

        public virtual string InOutDocumentStatus
        {
            get;
            set;
        }

        public virtual bool? InOutPosted
        {
            get;
            set;
        }

        public virtual bool? InOutProcessing
        {
            get;
            set;
        }

        public virtual bool? InOutProcessed
        {
            get;
            set;
        }

        public virtual int? InOutDocumentType
        {
            get;
            set;
        }

        public virtual string InOutDescription
        {
            get;
            set;
        }

        public virtual string InOutOrderNumber
        {
            get;
            set;
        }

        public virtual DateTime? InOutDateOrdered
        {
            get;
            set;
        }

        public virtual bool? InOutIsPrinted
        {
            get;
            set;
        }

        public virtual string InOutMovementType
        {
            get;
            set;
        }

        public virtual DateTime? InOutMovementDate
        {
            get;
            set;
        }

        public virtual string InOutBusinessPartnerId
        {
            get;
            set;
        }

        public virtual string InOutWarehouseId
        {
            get;
            set;
        }

        public virtual string InOutPOReference
        {
            get;
            set;
        }

        public virtual Money? InOutFreightAmount
        {
            get;
            set;
        }

        public virtual string InOutShipperId
        {
            get;
            set;
        }

        public virtual Money? InOutChargeAmount
        {
            get;
            set;
        }

        public virtual DateTime? InOutDatePrinted
        {
            get;
            set;
        }

        public virtual string InOutSalesRepresentative
        {
            get;
            set;
        }

        public virtual int? InOutNumberOfPackages
        {
            get;
            set;
        }

        public virtual DateTime? InOutPickDate
        {
            get;
            set;
        }

        public virtual DateTime? InOutShipDate
        {
            get;
            set;
        }

        public virtual string InOutTrackingNumber
        {
            get;
            set;
        }

        public virtual DateTime? InOutDateReceived
        {
            get;
            set;
        }

        public virtual bool? InOutIsInTransit
        {
            get;
            set;
        }

        public virtual bool? InOutIsApproved
        {
            get;
            set;
        }

        public virtual bool? InOutIsInDispute
        {
            get;
            set;
        }

        public virtual decimal? InOutVolume
        {
            get;
            set;
        }

        public virtual decimal? InOutWeight
        {
            get;
            set;
        }

        public virtual string InOutRmaNumber
        {
            get;
            set;
        }

        public virtual string InOutReversalNumber
        {
            get;
            set;
        }

        public virtual bool? InOutIsDropShip
        {
            get;
            set;
        }

        public virtual string InOutDropShipBusinessPartnerId
        {
            get;
            set;
        }

        public virtual string InOutCreatedBy
        {
            get;
            set;
        }

        public virtual DateTime? InOutCreatedAt
        {
            get;
            set;
        }

        public virtual string InOutUpdatedBy
        {
            get;
            set;
        }

        public virtual DateTime? InOutUpdatedAt
        {
            get;
            set;
        }

        public virtual bool? InOutActive
        {
            get;
            set;
        }

        public virtual bool? InOutDeleted
        {
            get;
            set;
        }

        public virtual long? InOutVersion
        {
            get;
            set;
        }

        public virtual string CreatedBy
        {
            get;
            set;
        }

        public virtual DateTime? CreatedAt
        {
            get;
            set;
        }

        public virtual string UpdatedBy
        {
            get;
            set;
        }

        public virtual DateTime? UpdatedAt
        {
            get;
            set;
        }

        public virtual IInOutLineMvoState ToInOutLineMvoState()
        {
            throw new NotImplementedException();
        }

    }

}

