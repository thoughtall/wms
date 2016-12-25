﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public partial class AttributeSetInstanceState : AttributeSetInstanceStateProperties, IAttributeSetInstanceState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }

        public virtual string CommandId { get; set; }


		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get
			{
				return this.AttributeSetInstanceId;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
			}
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IAttributeSetInstanceState.IsUnsaved
        {
            get { return this.Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public AttributeSetInstanceState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.AttributeSetInstanceId = ((IAttributeSetInstanceStateEvent)events.First()).StateEventId.AttributeSetInstanceId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.Version += 1;
                }
            }
        }

        public AttributeSetInstanceState() : this(false)
        {
        }

        public AttributeSetInstanceState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IAttributeSetInstanceStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.AttributeSetId = e.AttributeSetId;

			this.OrganizationId = e.OrganizationId;

			this.ReferenceId = e.ReferenceId;

			this.SerialNumber = e.SerialNumber;

			this.Lot = e.Lot;

			this.Description = e.Description;

			this.Hash = e.Hash;

			this._F_B_0_ = e._F_B_0_;

			this._F_I_0_ = e._F_I_0_;

			this._F_L_0_ = e._F_L_0_;

			this._F_DT_0_ = e._F_DT_0_;

			this._F_N_0_ = e._F_N_0_;

			this._F_C5_0_ = e._F_C5_0_;

			this._F_C10_0_ = e._F_C10_0_;

			this._F_C20_0_ = e._F_C20_0_;

			this._F_C50_0_ = e._F_C50_0_;

			this._F_C100_0_ = e._F_C100_0_;

			this._F_C200_0_ = e._F_C200_0_;

			this._F_C500_0_ = e._F_C500_0_;

			this._F_C1000_0_ = e._F_C1000_0_;

			this._F_B_1_ = e._F_B_1_;

			this._F_I_1_ = e._F_I_1_;

			this._F_L_1_ = e._F_L_1_;

			this._F_DT_1_ = e._F_DT_1_;

			this._F_N_1_ = e._F_N_1_;

			this._F_C5_1_ = e._F_C5_1_;

			this._F_C10_1_ = e._F_C10_1_;

			this._F_C20_1_ = e._F_C20_1_;

			this._F_C50_1_ = e._F_C50_1_;

			this._F_C100_1_ = e._F_C100_1_;

			this._F_C200_1_ = e._F_C200_1_;

			this._F_C500_1_ = e._F_C500_1_;

			this._F_C1000_1_ = e._F_C1000_1_;

			this._F_B_2_ = e._F_B_2_;

			this._F_I_2_ = e._F_I_2_;

			this._F_L_2_ = e._F_L_2_;

			this._F_DT_2_ = e._F_DT_2_;

			this._F_N_2_ = e._F_N_2_;

			this._F_C5_2_ = e._F_C5_2_;

			this._F_C10_2_ = e._F_C10_2_;

			this._F_C20_2_ = e._F_C20_2_;

			this._F_C50_2_ = e._F_C50_2_;

			this._F_C100_2_ = e._F_C100_2_;

			this._F_C200_2_ = e._F_C200_2_;

			this._F_C500_2_ = e._F_C500_2_;

			this._F_C1000_2_ = e._F_C1000_2_;

			this._F_B_3_ = e._F_B_3_;

			this._F_I_3_ = e._F_I_3_;

			this._F_L_3_ = e._F_L_3_;

			this._F_DT_3_ = e._F_DT_3_;

			this._F_N_3_ = e._F_N_3_;

			this._F_C5_3_ = e._F_C5_3_;

			this._F_C10_3_ = e._F_C10_3_;

			this._F_C20_3_ = e._F_C20_3_;

			this._F_C50_3_ = e._F_C50_3_;

			this._F_C100_3_ = e._F_C100_3_;

			this._F_C200_3_ = e._F_C200_3_;

			this._F_C500_3_ = e._F_C500_3_;

			this._F_C1000_3_ = e._F_C1000_3_;

			this._F_B_4_ = e._F_B_4_;

			this._F_I_4_ = e._F_I_4_;

			this._F_L_4_ = e._F_L_4_;

			this._F_DT_4_ = e._F_DT_4_;

			this._F_N_4_ = e._F_N_4_;

			this._F_C5_4_ = e._F_C5_4_;

			this._F_C10_4_ = e._F_C10_4_;

			this._F_C20_4_ = e._F_C20_4_;

			this._F_C50_4_ = e._F_C50_4_;

			this._F_C100_4_ = e._F_C100_4_;

			this._F_C200_4_ = e._F_C200_4_;

			this._F_C500_4_ = e._F_C500_4_;

			this._F_C1000_4_ = e._F_C1000_4_;

			this._F_B_5_ = e._F_B_5_;

			this._F_I_5_ = e._F_I_5_;

			this._F_L_5_ = e._F_L_5_;

			this._F_DT_5_ = e._F_DT_5_;

			this._F_N_5_ = e._F_N_5_;

			this._F_C5_5_ = e._F_C5_5_;

			this._F_C10_5_ = e._F_C10_5_;

			this._F_C20_5_ = e._F_C20_5_;

			this._F_C50_5_ = e._F_C50_5_;

			this._F_C100_5_ = e._F_C100_5_;

			this._F_C200_5_ = e._F_C200_5_;

			this._F_C500_5_ = e._F_C500_5_;

			this._F_B_6_ = e._F_B_6_;

			this._F_I_6_ = e._F_I_6_;

			this._F_L_6_ = e._F_L_6_;

			this._F_DT_6_ = e._F_DT_6_;

			this._F_N_6_ = e._F_N_6_;

			this._F_C5_6_ = e._F_C5_6_;

			this._F_C10_6_ = e._F_C10_6_;

			this._F_C20_6_ = e._F_C20_6_;

			this._F_C50_6_ = e._F_C50_6_;

			this._F_C100_6_ = e._F_C100_6_;

			this._F_C200_6_ = e._F_C200_6_;

			this._F_C500_6_ = e._F_C500_6_;

			this._F_B_7_ = e._F_B_7_;

			this._F_I_7_ = e._F_I_7_;

			this._F_L_7_ = e._F_L_7_;

			this._F_DT_7_ = e._F_DT_7_;

			this._F_N_7_ = e._F_N_7_;

			this._F_C5_7_ = e._F_C5_7_;

			this._F_C10_7_ = e._F_C10_7_;

			this._F_C20_7_ = e._F_C20_7_;

			this._F_C50_7_ = e._F_C50_7_;

			this._F_C100_7_ = e._F_C100_7_;

			this._F_C200_7_ = e._F_C200_7_;

			this._F_C500_7_ = e._F_C500_7_;

			this._F_B_8_ = e._F_B_8_;

			this._F_I_8_ = e._F_I_8_;

			this._F_L_8_ = e._F_L_8_;

			this._F_DT_8_ = e._F_DT_8_;

			this._F_N_8_ = e._F_N_8_;

			this._F_C5_8_ = e._F_C5_8_;

			this._F_C10_8_ = e._F_C10_8_;

			this._F_C20_8_ = e._F_C20_8_;

			this._F_C50_8_ = e._F_C50_8_;

			this._F_C100_8_ = e._F_C100_8_;

			this._F_C200_8_ = e._F_C200_8_;

			this._F_C500_8_ = e._F_C500_8_;

			this._F_B_9_ = e._F_B_9_;

			this._F_I_9_ = e._F_I_9_;

			this._F_L_9_ = e._F_L_9_;

			this._F_DT_9_ = e._F_DT_9_;

			this._F_N_9_ = e._F_N_9_;

			this._F_C5_9_ = e._F_C5_9_;

			this._F_C10_9_ = e._F_C10_9_;

			this._F_C20_9_ = e._F_C20_9_;

			this._F_C50_9_ = e._F_C50_9_;

			this._F_C100_9_ = e._F_C100_9_;

			this._F_C200_9_ = e._F_C200_9_;

			this._F_C500_9_ = e._F_C500_9_;

			this._F_B_10_ = e._F_B_10_;

			this._F_I_10_ = e._F_I_10_;

			this._F_L_10_ = e._F_L_10_;

			this._F_DT_10_ = e._F_DT_10_;

			this._F_N_10_ = e._F_N_10_;

			this._F_C5_10_ = e._F_C5_10_;

			this._F_C10_10_ = e._F_C10_10_;

			this._F_C20_10_ = e._F_C20_10_;

			this._F_C50_10_ = e._F_C50_10_;

			this._F_C100_10_ = e._F_C100_10_;

			this._F_C200_10_ = e._F_C200_10_;

			this._F_B_11_ = e._F_B_11_;

			this._F_I_11_ = e._F_I_11_;

			this._F_L_11_ = e._F_L_11_;

			this._F_DT_11_ = e._F_DT_11_;

			this._F_N_11_ = e._F_N_11_;

			this._F_C5_11_ = e._F_C5_11_;

			this._F_C10_11_ = e._F_C10_11_;

			this._F_C20_11_ = e._F_C20_11_;

			this._F_C50_11_ = e._F_C50_11_;

			this._F_C100_11_ = e._F_C100_11_;

			this._F_C200_11_ = e._F_C200_11_;

			this._F_B_12_ = e._F_B_12_;

			this._F_I_12_ = e._F_I_12_;

			this._F_L_12_ = e._F_L_12_;

			this._F_DT_12_ = e._F_DT_12_;

			this._F_N_12_ = e._F_N_12_;

			this._F_C5_12_ = e._F_C5_12_;

			this._F_C10_12_ = e._F_C10_12_;

			this._F_C20_12_ = e._F_C20_12_;

			this._F_C50_12_ = e._F_C50_12_;

			this._F_C100_12_ = e._F_C100_12_;

			this._F_C200_12_ = e._F_C200_12_;

			this._F_B_13_ = e._F_B_13_;

			this._F_I_13_ = e._F_I_13_;

			this._F_L_13_ = e._F_L_13_;

			this._F_DT_13_ = e._F_DT_13_;

			this._F_N_13_ = e._F_N_13_;

			this._F_C5_13_ = e._F_C5_13_;

			this._F_C10_13_ = e._F_C10_13_;

			this._F_C20_13_ = e._F_C20_13_;

			this._F_C50_13_ = e._F_C50_13_;

			this._F_C100_13_ = e._F_C100_13_;

			this._F_C200_13_ = e._F_C200_13_;

			this._F_B_14_ = e._F_B_14_;

			this._F_I_14_ = e._F_I_14_;

			this._F_L_14_ = e._F_L_14_;

			this._F_DT_14_ = e._F_DT_14_;

			this._F_N_14_ = e._F_N_14_;

			this._F_C5_14_ = e._F_C5_14_;

			this._F_C10_14_ = e._F_C10_14_;

			this._F_C20_14_ = e._F_C20_14_;

			this._F_C50_14_ = e._F_C50_14_;

			this._F_C100_14_ = e._F_C100_14_;

			this._F_C200_14_ = e._F_C200_14_;

			this._F_B_15_ = e._F_B_15_;

			this._F_I_15_ = e._F_I_15_;

			this._F_L_15_ = e._F_L_15_;

			this._F_DT_15_ = e._F_DT_15_;

			this._F_N_15_ = e._F_N_15_;

			this._F_C5_15_ = e._F_C5_15_;

			this._F_C10_15_ = e._F_C10_15_;

			this._F_C20_15_ = e._F_C20_15_;

			this._F_C50_15_ = e._F_C50_15_;

			this._F_C100_15_ = e._F_C100_15_;

			this._F_C200_15_ = e._F_C200_15_;

			this._F_B_16_ = e._F_B_16_;

			this._F_I_16_ = e._F_I_16_;

			this._F_L_16_ = e._F_L_16_;

			this._F_DT_16_ = e._F_DT_16_;

			this._F_N_16_ = e._F_N_16_;

			this._F_C5_16_ = e._F_C5_16_;

			this._F_C10_16_ = e._F_C10_16_;

			this._F_C20_16_ = e._F_C20_16_;

			this._F_C50_16_ = e._F_C50_16_;

			this._F_C100_16_ = e._F_C100_16_;

			this._F_C200_16_ = e._F_C200_16_;

			this._F_B_17_ = e._F_B_17_;

			this._F_I_17_ = e._F_I_17_;

			this._F_L_17_ = e._F_L_17_;

			this._F_DT_17_ = e._F_DT_17_;

			this._F_N_17_ = e._F_N_17_;

			this._F_C5_17_ = e._F_C5_17_;

			this._F_C10_17_ = e._F_C10_17_;

			this._F_C20_17_ = e._F_C20_17_;

			this._F_C50_17_ = e._F_C50_17_;

			this._F_C100_17_ = e._F_C100_17_;

			this._F_C200_17_ = e._F_C200_17_;

			this._F_B_18_ = e._F_B_18_;

			this._F_I_18_ = e._F_I_18_;

			this._F_L_18_ = e._F_L_18_;

			this._F_DT_18_ = e._F_DT_18_;

			this._F_N_18_ = e._F_N_18_;

			this._F_C5_18_ = e._F_C5_18_;

			this._F_C10_18_ = e._F_C10_18_;

			this._F_C20_18_ = e._F_C20_18_;

			this._F_C50_18_ = e._F_C50_18_;

			this._F_C100_18_ = e._F_C100_18_;

			this._F_C200_18_ = e._F_C200_18_;

			this._F_B_19_ = e._F_B_19_;

			this._F_I_19_ = e._F_I_19_;

			this._F_L_19_ = e._F_L_19_;

			this._F_DT_19_ = e._F_DT_19_;

			this._F_N_19_ = e._F_N_19_;

			this._F_C5_19_ = e._F_C5_19_;

			this._F_C10_19_ = e._F_C10_19_;

			this._F_C20_19_ = e._F_C20_19_;

			this._F_C50_19_ = e._F_C50_19_;

			this._F_C100_19_ = e._F_C100_19_;

			this._F_C200_19_ = e._F_C200_19_;

			this._F_B_20_ = e._F_B_20_;

			this._F_I_20_ = e._F_I_20_;

			this._F_L_20_ = e._F_L_20_;

			this._F_N_20_ = e._F_N_20_;

			this._F_C5_20_ = e._F_C5_20_;

			this._F_C10_20_ = e._F_C10_20_;

			this._F_C20_20_ = e._F_C20_20_;

			this._F_C50_20_ = e._F_C50_20_;

			this._F_B_21_ = e._F_B_21_;

			this._F_I_21_ = e._F_I_21_;

			this._F_L_21_ = e._F_L_21_;

			this._F_N_21_ = e._F_N_21_;

			this._F_C5_21_ = e._F_C5_21_;

			this._F_C10_21_ = e._F_C10_21_;

			this._F_C20_21_ = e._F_C20_21_;

			this._F_C50_21_ = e._F_C50_21_;

			this._F_B_22_ = e._F_B_22_;

			this._F_I_22_ = e._F_I_22_;

			this._F_L_22_ = e._F_L_22_;

			this._F_N_22_ = e._F_N_22_;

			this._F_C5_22_ = e._F_C5_22_;

			this._F_C10_22_ = e._F_C10_22_;

			this._F_C20_22_ = e._F_C20_22_;

			this._F_C50_22_ = e._F_C50_22_;

			this._F_B_23_ = e._F_B_23_;

			this._F_I_23_ = e._F_I_23_;

			this._F_L_23_ = e._F_L_23_;

			this._F_N_23_ = e._F_N_23_;

			this._F_C5_23_ = e._F_C5_23_;

			this._F_C10_23_ = e._F_C10_23_;

			this._F_C20_23_ = e._F_C20_23_;

			this._F_C50_23_ = e._F_C50_23_;

			this._F_B_24_ = e._F_B_24_;

			this._F_I_24_ = e._F_I_24_;

			this._F_L_24_ = e._F_L_24_;

			this._F_N_24_ = e._F_N_24_;

			this._F_C5_24_ = e._F_C5_24_;

			this._F_C10_24_ = e._F_C10_24_;

			this._F_C20_24_ = e._F_C20_24_;

			this._F_C50_24_ = e._F_C50_24_;

			this._F_B_25_ = e._F_B_25_;

			this._F_I_25_ = e._F_I_25_;

			this._F_L_25_ = e._F_L_25_;

			this._F_N_25_ = e._F_N_25_;

			this._F_C5_25_ = e._F_C5_25_;

			this._F_C10_25_ = e._F_C10_25_;

			this._F_C20_25_ = e._F_C20_25_;

			this._F_C50_25_ = e._F_C50_25_;

			this._F_B_26_ = e._F_B_26_;

			this._F_I_26_ = e._F_I_26_;

			this._F_L_26_ = e._F_L_26_;

			this._F_N_26_ = e._F_N_26_;

			this._F_C5_26_ = e._F_C5_26_;

			this._F_C10_26_ = e._F_C10_26_;

			this._F_C20_26_ = e._F_C20_26_;

			this._F_C50_26_ = e._F_C50_26_;

			this._F_B_27_ = e._F_B_27_;

			this._F_I_27_ = e._F_I_27_;

			this._F_L_27_ = e._F_L_27_;

			this._F_N_27_ = e._F_N_27_;

			this._F_C5_27_ = e._F_C5_27_;

			this._F_C10_27_ = e._F_C10_27_;

			this._F_C20_27_ = e._F_C20_27_;

			this._F_C50_27_ = e._F_C50_27_;

			this._F_B_28_ = e._F_B_28_;

			this._F_I_28_ = e._F_I_28_;

			this._F_L_28_ = e._F_L_28_;

			this._F_N_28_ = e._F_N_28_;

			this._F_C5_28_ = e._F_C5_28_;

			this._F_C10_28_ = e._F_C10_28_;

			this._F_C20_28_ = e._F_C20_28_;

			this._F_C50_28_ = e._F_C50_28_;

			this._F_B_29_ = e._F_B_29_;

			this._F_I_29_ = e._F_I_29_;

			this._F_L_29_ = e._F_L_29_;

			this._F_N_29_ = e._F_N_29_;

			this._F_C5_29_ = e._F_C5_29_;

			this._F_C10_29_ = e._F_C10_29_;

			this._F_C20_29_ = e._F_C20_29_;

			this._F_C50_29_ = e._F_C50_29_;

			this._F_B_30_ = e._F_B_30_;

			this._F_I_30_ = e._F_I_30_;

			this._F_N_30_ = e._F_N_30_;

			this._F_C5_30_ = e._F_C5_30_;

			this._F_C10_30_ = e._F_C10_30_;

			this._F_C20_30_ = e._F_C20_30_;

			this._F_C50_30_ = e._F_C50_30_;

			this._F_B_31_ = e._F_B_31_;

			this._F_I_31_ = e._F_I_31_;

			this._F_N_31_ = e._F_N_31_;

			this._F_C5_31_ = e._F_C5_31_;

			this._F_C10_31_ = e._F_C10_31_;

			this._F_C20_31_ = e._F_C20_31_;

			this._F_C50_31_ = e._F_C50_31_;

			this._F_B_32_ = e._F_B_32_;

			this._F_I_32_ = e._F_I_32_;

			this._F_N_32_ = e._F_N_32_;

			this._F_C5_32_ = e._F_C5_32_;

			this._F_C10_32_ = e._F_C10_32_;

			this._F_C20_32_ = e._F_C20_32_;

			this._F_C50_32_ = e._F_C50_32_;

			this._F_B_33_ = e._F_B_33_;

			this._F_I_33_ = e._F_I_33_;

			this._F_N_33_ = e._F_N_33_;

			this._F_C5_33_ = e._F_C5_33_;

			this._F_C10_33_ = e._F_C10_33_;

			this._F_C20_33_ = e._F_C20_33_;

			this._F_C50_33_ = e._F_C50_33_;

			this._F_B_34_ = e._F_B_34_;

			this._F_I_34_ = e._F_I_34_;

			this._F_N_34_ = e._F_N_34_;

			this._F_C5_34_ = e._F_C5_34_;

			this._F_C10_34_ = e._F_C10_34_;

			this._F_C20_34_ = e._F_C20_34_;

			this._F_C50_34_ = e._F_C50_34_;

			this._F_B_35_ = e._F_B_35_;

			this._F_I_35_ = e._F_I_35_;

			this._F_N_35_ = e._F_N_35_;

			this._F_C5_35_ = e._F_C5_35_;

			this._F_C10_35_ = e._F_C10_35_;

			this._F_C20_35_ = e._F_C20_35_;

			this._F_C50_35_ = e._F_C50_35_;

			this._F_B_36_ = e._F_B_36_;

			this._F_I_36_ = e._F_I_36_;

			this._F_N_36_ = e._F_N_36_;

			this._F_C5_36_ = e._F_C5_36_;

			this._F_C10_36_ = e._F_C10_36_;

			this._F_C20_36_ = e._F_C20_36_;

			this._F_C50_36_ = e._F_C50_36_;

			this._F_B_37_ = e._F_B_37_;

			this._F_I_37_ = e._F_I_37_;

			this._F_N_37_ = e._F_N_37_;

			this._F_C5_37_ = e._F_C5_37_;

			this._F_C10_37_ = e._F_C10_37_;

			this._F_C20_37_ = e._F_C20_37_;

			this._F_C50_37_ = e._F_C50_37_;

			this._F_B_38_ = e._F_B_38_;

			this._F_I_38_ = e._F_I_38_;

			this._F_N_38_ = e._F_N_38_;

			this._F_C5_38_ = e._F_C5_38_;

			this._F_C10_38_ = e._F_C10_38_;

			this._F_C20_38_ = e._F_C20_38_;

			this._F_C50_38_ = e._F_C50_38_;

			this._F_B_39_ = e._F_B_39_;

			this._F_I_39_ = e._F_I_39_;

			this._F_N_39_ = e._F_N_39_;

			this._F_C5_39_ = e._F_C5_39_;

			this._F_C10_39_ = e._F_C10_39_;

			this._F_C20_39_ = e._F_C20_39_;

			this._F_C50_39_ = e._F_C50_39_;

			this._F_B_40_ = e._F_B_40_;

			this._F_I_40_ = e._F_I_40_;

			this._F_N_40_ = e._F_N_40_;

			this._F_C5_40_ = e._F_C5_40_;

			this._F_C10_40_ = e._F_C10_40_;

			this._F_C20_40_ = e._F_C20_40_;

			this._F_C50_40_ = e._F_C50_40_;

			this._F_B_41_ = e._F_B_41_;

			this._F_I_41_ = e._F_I_41_;

			this._F_N_41_ = e._F_N_41_;

			this._F_C5_41_ = e._F_C5_41_;

			this._F_C10_41_ = e._F_C10_41_;

			this._F_C20_41_ = e._F_C20_41_;

			this._F_C50_41_ = e._F_C50_41_;

			this._F_B_42_ = e._F_B_42_;

			this._F_I_42_ = e._F_I_42_;

			this._F_N_42_ = e._F_N_42_;

			this._F_C5_42_ = e._F_C5_42_;

			this._F_C10_42_ = e._F_C10_42_;

			this._F_C20_42_ = e._F_C20_42_;

			this._F_C50_42_ = e._F_C50_42_;

			this._F_B_43_ = e._F_B_43_;

			this._F_I_43_ = e._F_I_43_;

			this._F_N_43_ = e._F_N_43_;

			this._F_C5_43_ = e._F_C5_43_;

			this._F_C10_43_ = e._F_C10_43_;

			this._F_C20_43_ = e._F_C20_43_;

			this._F_C50_43_ = e._F_C50_43_;

			this._F_B_44_ = e._F_B_44_;

			this._F_I_44_ = e._F_I_44_;

			this._F_N_44_ = e._F_N_44_;

			this._F_C5_44_ = e._F_C5_44_;

			this._F_C10_44_ = e._F_C10_44_;

			this._F_C20_44_ = e._F_C20_44_;

			this._F_C50_44_ = e._F_C50_44_;

			this._F_B_45_ = e._F_B_45_;

			this._F_I_45_ = e._F_I_45_;

			this._F_N_45_ = e._F_N_45_;

			this._F_C5_45_ = e._F_C5_45_;

			this._F_C10_45_ = e._F_C10_45_;

			this._F_C20_45_ = e._F_C20_45_;

			this._F_C50_45_ = e._F_C50_45_;

			this._F_B_46_ = e._F_B_46_;

			this._F_I_46_ = e._F_I_46_;

			this._F_N_46_ = e._F_N_46_;

			this._F_C5_46_ = e._F_C5_46_;

			this._F_C10_46_ = e._F_C10_46_;

			this._F_C20_46_ = e._F_C20_46_;

			this._F_C50_46_ = e._F_C50_46_;

			this._F_B_47_ = e._F_B_47_;

			this._F_I_47_ = e._F_I_47_;

			this._F_N_47_ = e._F_N_47_;

			this._F_C5_47_ = e._F_C5_47_;

			this._F_C10_47_ = e._F_C10_47_;

			this._F_C20_47_ = e._F_C20_47_;

			this._F_C50_47_ = e._F_C50_47_;

			this._F_B_48_ = e._F_B_48_;

			this._F_I_48_ = e._F_I_48_;

			this._F_N_48_ = e._F_N_48_;

			this._F_C5_48_ = e._F_C5_48_;

			this._F_C10_48_ = e._F_C10_48_;

			this._F_C20_48_ = e._F_C20_48_;

			this._F_C50_48_ = e._F_C50_48_;

			this._F_B_49_ = e._F_B_49_;

			this._F_I_49_ = e._F_I_49_;

			this._F_N_49_ = e._F_N_49_;

			this._F_C5_49_ = e._F_C5_49_;

			this._F_C10_49_ = e._F_C10_49_;

			this._F_C20_49_ = e._F_C20_49_;

			this._F_C50_49_ = e._F_C50_49_;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}



		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IAttributeSetInstanceStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("AttributeSetInstance|");

            var stateEntityId = this.AttributeSetInstanceId; // Aggregate Id
            var eventEntityId = stateEvent.StateEventId.AttributeSetInstanceId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.Version;
            var eventVersion = stateEvent.StateEventId.Version;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

