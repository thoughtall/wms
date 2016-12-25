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

	public partial class AttributeValueState : AttributeValueStateProperties, IAttributeValueState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

        private AttributeValueId _attributeValueId = new AttributeValueId();

        public virtual AttributeValueId AttributeValueId 
        {
            get { return this._attributeValueId; }
            set { this._attributeValueId = value; }
        }

		AttributeValueId IGlobalIdentity<AttributeValueId>.GlobalId {
			get {
				return  this.AttributeValueId;
			}
		}

        string ILocalIdentity<string>.LocalId
        {
            get
            {
                return this.Value;
            }
        }


        public override string AttributeId {
			get {
				return this.AttributeValueId.AttributeId;
			}
			set {
				this.AttributeValueId.AttributeId = value;
			}
		}

        public override string Value {
			get {
				return this.AttributeValueId.Value;
			}
			set {
				this.AttributeValueId.Value = value;
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

		long IEntityVersioned<long>.EntityVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IAttributeValueState.IsUnsaved
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

        public AttributeValueState() : this(false)
        {
        }

        public AttributeValueState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IAttributeValueStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.Name = e.Name;

			this.Description = e.Description;

			this.ReferenceId = e.ReferenceId;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IAttributeValueStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.Name == null)
			{
				if (e.IsPropertyNameRemoved)
				{
					this.Name = default(string);
				}
			}
			else
			{
				this.Name = e.Name;
			}

			if (e.Description == null)
			{
				if (e.IsPropertyDescriptionRemoved)
				{
					this.Description = default(string);
				}
			}
			else
			{
				this.Description = e.Description;
			}

			if (e.ReferenceId == null)
			{
				if (e.IsPropertyReferenceIdRemoved)
				{
					this.ReferenceId = default(string);
				}
			}
			else
			{
				this.ReferenceId = e.ReferenceId;
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IAttributeValueStateRemoved e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IAttributeValueStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("AttributeValue|");

            var stateEntityIdAttributeId = (this as IGlobalIdentity<AttributeValueId>).GlobalId.AttributeId;
            var eventEntityIdAttributeId = stateEvent.StateEventId.AttributeId;
            if (stateEntityIdAttributeId != eventEntityIdAttributeId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id AttributeId {0} in state but entity id AttributeId {1} in event", stateEntityIdAttributeId, eventEntityIdAttributeId);
            }
            id.Append(stateEntityIdAttributeId).Append(",");

            var stateEntityIdValue = (this as IGlobalIdentity<AttributeValueId>).GlobalId.Value;
            var eventEntityIdValue = stateEvent.StateEventId.Value;
            if (stateEntityIdValue != eventEntityIdValue)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id Value {0} in state but entity id Value {1} in event", stateEntityIdValue, eventEntityIdValue);
            }
            id.Append(stateEntityIdValue).Append(",");

            id.Append("]");

            if (ForReapplying) { return; }
            var stateVersion = this.Version;
            var eventVersion = stateEvent.Version;
            if (AttributeValueState.VersionZero == eventVersion)
            {
                eventVersion = stateEvent.Version = stateVersion;
            }
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

