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

	public partial class OrganizationStructureTypeStateDtoWrapper : StateDtoWrapperBase, IOrganizationStructureTypeStateDto, IOrganizationStructureTypeState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private OrganizationStructureTypeState _state;

        public OrganizationStructureTypeStateDtoWrapper()
        {
            this._state = new OrganizationStructureTypeState();
        }

		public OrganizationStructureTypeStateDtoWrapper(OrganizationStructureTypeState state)
		{
            this._state = state;
		}

		public IOrganizationStructureTypeState ToOrganizationStructureTypeState()
		{
			return this._state;
		}

		public virtual string Id
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Id"))
                {
                    return _state.Id;
                }
                return null;
            }
            set
            {
                _state.Id = value;
            }
        }

        string IOrganizationStructureTypeStateProperties.Id
        {
            get 
            {
                return (this._state as IOrganizationStructureTypeStateProperties).Id;
            }
            set 
            {
                this._state.Id = value;
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

        bool IOrganizationStructureTypeStateProperties.Active
        {
            get 
            {
                return (this._state as IOrganizationStructureTypeStateProperties).Active;
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

        long IOrganizationStructureTypeStateProperties.Version
        {
            get 
            {
                return (this._state as IOrganizationStructureTypeStateProperties).Version;
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
			get { return (_state as IOrganizationStructureTypeState).GlobalId; }
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
            get { return (_state as IOrganizationStructureTypeState).CreatedBy; }
            set { (_state as IOrganizationStructureTypeState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IOrganizationStructureTypeState).CreatedAt; }
            set { (_state as IOrganizationStructureTypeState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IOrganizationStructureTypeState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IOrganizationStructureTypeState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.Version; }
		}

		#endregion

        bool IOrganizationStructureTypeState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == OrganizationStructureTypeState.VersionZero; }
        }


		void IOrganizationStructureTypeState.When(IOrganizationStructureTypeStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IOrganizationStructureTypeState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IOrganizationStructureTypeState.When(IOrganizationStructureTypeStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IOrganizationStructureTypeState.When(IOrganizationStructureTypeStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IOrganizationStructureTypeState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class OrganizationStructureTypeStateDtoWrapperCollection : StateDtoWrapperCollectionBase<OrganizationStructureTypeStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(OrganizationStructureTypeStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

