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

	public partial class AttributeValueMvoState : AttributeValueMvoStateProperties, IAttributeValueMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		AttributeValueId IGlobalIdentity<AttributeValueId>.GlobalId
		{
			get
			{
				return this.AttributeValueId;
			}
		}

		#endregion



		#region IActive implementation

		bool IActive.Active
		{
			get
			{
				return this.Active;
			}
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
			get
			{
				return this.UpdatedBy;
			}
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get
			{
				return this.UpdatedAt;
			}
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
			get
			{
				return this.AttributeVersion;
			}
		}


		#endregion

        bool IAttributeValueMvoState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == VersionZero; }
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

        public AttributeValueMvoState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.AttributeValueId = ((IAttributeValueMvoStateEvent)events.First()).StateEventId.AttributeValueId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.AttributeVersion += 1;
                }
            }
        }

        public AttributeValueMvoState() : this(false)
        {
        }

        public AttributeValueMvoState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IAttributeValueMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.Name = e.Name;

			this.Description = e.Description;

			this.ReferenceId = e.ReferenceId;

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.AttributeName = e.AttributeName;

			this.AttributeOrganizationId = e.AttributeOrganizationId;

			this.AttributeDescription = e.AttributeDescription;

            this.AttributeIsMandatory = (e.AttributeIsMandatory != null && e.AttributeIsMandatory.HasValue) ? e.AttributeIsMandatory.Value : default(bool);

            this.AttributeIsInstanceAttribute = (e.AttributeIsInstanceAttribute != null && e.AttributeIsInstanceAttribute.HasValue) ? e.AttributeIsInstanceAttribute.Value : default(bool);

			this.AttributeAttributeValueType = e.AttributeAttributeValueType;

			this.AttributeAttributeValueLength = e.AttributeAttributeValueLength;

            this.AttributeIsList = (e.AttributeIsList != null && e.AttributeIsList.HasValue) ? e.AttributeIsList.Value : default(bool);

			this.AttributeFieldName = e.AttributeFieldName;

			this.AttributeReferenceId = e.AttributeReferenceId;

			this.AttributeCreatedBy = e.AttributeCreatedBy;

            this.AttributeCreatedAt = (e.AttributeCreatedAt != null && e.AttributeCreatedAt.HasValue) ? e.AttributeCreatedAt.Value : default(DateTime);

			this.AttributeUpdatedBy = e.AttributeUpdatedBy;

            this.AttributeUpdatedAt = (e.AttributeUpdatedAt != null && e.AttributeUpdatedAt.HasValue) ? e.AttributeUpdatedAt.Value : default(DateTime);

            this.AttributeActive = (e.AttributeActive != null && e.AttributeActive.HasValue) ? e.AttributeActive.Value : default(bool);

            this.AttributeDeleted = (e.AttributeDeleted != null && e.AttributeDeleted.HasValue) ? e.AttributeDeleted.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IAttributeValueMvoStateMergePatched e)
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

			if (e.Version == null)
			{
				if (e.IsPropertyVersionRemoved)
				{
					this.Version = default(long);
				}
			}
			else
			{
				this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);
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

			if (e.AttributeName == null)
			{
				if (e.IsPropertyAttributeNameRemoved)
				{
					this.AttributeName = default(string);
				}
			}
			else
			{
				this.AttributeName = e.AttributeName;
			}

			if (e.AttributeOrganizationId == null)
			{
				if (e.IsPropertyAttributeOrganizationIdRemoved)
				{
					this.AttributeOrganizationId = default(string);
				}
			}
			else
			{
				this.AttributeOrganizationId = e.AttributeOrganizationId;
			}

			if (e.AttributeDescription == null)
			{
				if (e.IsPropertyAttributeDescriptionRemoved)
				{
					this.AttributeDescription = default(string);
				}
			}
			else
			{
				this.AttributeDescription = e.AttributeDescription;
			}

			if (e.AttributeIsMandatory == null)
			{
				if (e.IsPropertyAttributeIsMandatoryRemoved)
				{
					this.AttributeIsMandatory = default(bool);
				}
			}
			else
			{
				this.AttributeIsMandatory = (e.AttributeIsMandatory != null && e.AttributeIsMandatory.HasValue) ? e.AttributeIsMandatory.Value : default(bool);
			}

			if (e.AttributeIsInstanceAttribute == null)
			{
				if (e.IsPropertyAttributeIsInstanceAttributeRemoved)
				{
					this.AttributeIsInstanceAttribute = default(bool);
				}
			}
			else
			{
				this.AttributeIsInstanceAttribute = (e.AttributeIsInstanceAttribute != null && e.AttributeIsInstanceAttribute.HasValue) ? e.AttributeIsInstanceAttribute.Value : default(bool);
			}

			if (e.AttributeAttributeValueType == null)
			{
				if (e.IsPropertyAttributeAttributeValueTypeRemoved)
				{
					this.AttributeAttributeValueType = default(string);
				}
			}
			else
			{
				this.AttributeAttributeValueType = e.AttributeAttributeValueType;
			}

			if (e.AttributeAttributeValueLength == null)
			{
				if (e.IsPropertyAttributeAttributeValueLengthRemoved)
				{
					this.AttributeAttributeValueLength = default(int?);
				}
			}
			else
			{
				this.AttributeAttributeValueLength = e.AttributeAttributeValueLength;
			}

			if (e.AttributeIsList == null)
			{
				if (e.IsPropertyAttributeIsListRemoved)
				{
					this.AttributeIsList = default(bool);
				}
			}
			else
			{
				this.AttributeIsList = (e.AttributeIsList != null && e.AttributeIsList.HasValue) ? e.AttributeIsList.Value : default(bool);
			}

			if (e.AttributeFieldName == null)
			{
				if (e.IsPropertyAttributeFieldNameRemoved)
				{
					this.AttributeFieldName = default(string);
				}
			}
			else
			{
				this.AttributeFieldName = e.AttributeFieldName;
			}

			if (e.AttributeReferenceId == null)
			{
				if (e.IsPropertyAttributeReferenceIdRemoved)
				{
					this.AttributeReferenceId = default(string);
				}
			}
			else
			{
				this.AttributeReferenceId = e.AttributeReferenceId;
			}

			if (e.AttributeCreatedBy == null)
			{
				if (e.IsPropertyAttributeCreatedByRemoved)
				{
					this.AttributeCreatedBy = default(string);
				}
			}
			else
			{
				this.AttributeCreatedBy = e.AttributeCreatedBy;
			}

			if (e.AttributeCreatedAt == null)
			{
				if (e.IsPropertyAttributeCreatedAtRemoved)
				{
					this.AttributeCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.AttributeCreatedAt = (e.AttributeCreatedAt != null && e.AttributeCreatedAt.HasValue) ? e.AttributeCreatedAt.Value : default(DateTime);
			}

			if (e.AttributeUpdatedBy == null)
			{
				if (e.IsPropertyAttributeUpdatedByRemoved)
				{
					this.AttributeUpdatedBy = default(string);
				}
			}
			else
			{
				this.AttributeUpdatedBy = e.AttributeUpdatedBy;
			}

			if (e.AttributeUpdatedAt == null)
			{
				if (e.IsPropertyAttributeUpdatedAtRemoved)
				{
					this.AttributeUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.AttributeUpdatedAt = (e.AttributeUpdatedAt != null && e.AttributeUpdatedAt.HasValue) ? e.AttributeUpdatedAt.Value : default(DateTime);
			}

			if (e.AttributeActive == null)
			{
				if (e.IsPropertyAttributeActiveRemoved)
				{
					this.AttributeActive = default(bool);
				}
			}
			else
			{
				this.AttributeActive = (e.AttributeActive != null && e.AttributeActive.HasValue) ? e.AttributeActive.Value : default(bool);
			}

			if (e.AttributeDeleted == null)
			{
				if (e.IsPropertyAttributeDeletedRemoved)
				{
					this.AttributeDeleted = default(bool);
				}
			}
			else
			{
				this.AttributeDeleted = (e.AttributeDeleted != null && e.AttributeDeleted.HasValue) ? e.AttributeDeleted.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IAttributeValueMvoStateDeleted e)
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

		protected void ThrowOnWrongEvent(IAttributeValueMvoStateEvent stateEvent)
		{
			var stateEntityId = this.AttributeValueId; // Aggregate Id
			var eventEntityId = stateEvent.StateEventId.AttributeValueId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
			if (stateEntityId != eventEntityId)
			{
				throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
			}

			var stateVersion = this.AttributeVersion;
			var eventVersion = stateEvent.StateEventId.AttributeVersion;
			if (stateVersion != eventVersion)
			{
				throw DomainError.Named("concurrencyConflict", "Conflict between state version {0} and event version {1}", stateVersion, eventVersion);
			}

		}
	}

}

