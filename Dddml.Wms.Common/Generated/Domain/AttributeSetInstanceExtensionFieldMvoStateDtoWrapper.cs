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

	public partial class AttributeSetInstanceExtensionFieldMvoStateDtoWrapper : StateDtoWrapperBase, IAttributeSetInstanceExtensionFieldMvoStateDto, IAttributeSetInstanceExtensionFieldMvoState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private AttributeSetInstanceExtensionFieldMvoState _state;

        public AttributeSetInstanceExtensionFieldMvoStateDtoWrapper()
        {
            this._state = new AttributeSetInstanceExtensionFieldMvoState();
        }

		public AttributeSetInstanceExtensionFieldMvoStateDtoWrapper(AttributeSetInstanceExtensionFieldMvoState state)
		{
            this._state = state;
		}

		public IAttributeSetInstanceExtensionFieldMvoState ToAttributeSetInstanceExtensionFieldMvoState()
		{
			return this._state;
		}


        public AttributeSetInstanceExtensionFieldIdDto AttributeSetInstanceExtensionFieldId
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeSetInstanceExtensionFieldId"))
                {
					return (_state.AttributeSetInstanceExtensionFieldId == null) ? null : new AttributeSetInstanceExtensionFieldIdDtoWrapper(_state.AttributeSetInstanceExtensionFieldId);
                }
                return null;
            }
            set
            {
                _state.AttributeSetInstanceExtensionFieldId = (value == null) ? null : value.ToAttributeSetInstanceExtensionFieldId();
            }
        }


        AttributeSetInstanceExtensionFieldId IAttributeSetInstanceExtensionFieldMvoStateProperties.AttributeSetInstanceExtensionFieldId
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).AttributeSetInstanceExtensionFieldId;
            }
            set 
            {
                this._state.AttributeSetInstanceExtensionFieldId = value;
            }
        }

		public virtual string Name
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Name"))
                {
                    return _state.Name;
                }
                return null;
            }
            set
            {
                _state.Name = value;
            }
        }

        string IAttributeSetInstanceExtensionFieldMvoStateProperties.Name
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).Name;
            }
            set 
            {
                this._state.Name = value;
            }
        }

		public virtual string Type
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Type"))
                {
                    return _state.Type;
                }
                return null;
            }
            set
            {
                _state.Type = value;
            }
        }

        string IAttributeSetInstanceExtensionFieldMvoStateProperties.Type
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).Type;
            }
            set 
            {
                this._state.Type = value;
            }
        }

		public virtual int? Length
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Length"))
                {
                    return _state.Length;
                }
                return null;
            }
            set
            {
                _state.Length = value;
            }
        }

        int? IAttributeSetInstanceExtensionFieldMvoStateProperties.Length
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).Length;
            }
            set 
            {
                this._state.Length = value;
            }
        }

		public virtual string Alias
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Alias"))
                {
                    return _state.Alias;
                }
                return null;
            }
            set
            {
                _state.Alias = value;
            }
        }

        string IAttributeSetInstanceExtensionFieldMvoStateProperties.Alias
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).Alias;
            }
            set 
            {
                this._state.Alias = value;
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

        string IAttributeSetInstanceExtensionFieldMvoStateProperties.Description
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).Description;
            }
            set 
            {
                this._state.Description = value;
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

        long IAttributeSetInstanceExtensionFieldMvoStateProperties.Version
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).Version;
            }
            set 
            {
                this._state.Version = value;
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

        bool IAttributeSetInstanceExtensionFieldMvoStateProperties.Active
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).Active;
            }
            set 
            {
                this._state.Active = value;
            }
        }

		public virtual string AttrSetInstEFGroupFieldType
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttrSetInstEFGroupFieldType"))
                {
                    return _state.AttrSetInstEFGroupFieldType;
                }
                return null;
            }
            set
            {
                _state.AttrSetInstEFGroupFieldType = value;
            }
        }

        string IAttributeSetInstanceExtensionFieldMvoStateProperties.AttrSetInstEFGroupFieldType
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).AttrSetInstEFGroupFieldType;
            }
            set 
            {
                this._state.AttrSetInstEFGroupFieldType = value;
            }
        }

		public virtual int? AttrSetInstEFGroupFieldLength
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttrSetInstEFGroupFieldLength"))
                {
                    return _state.AttrSetInstEFGroupFieldLength;
                }
                return null;
            }
            set
            {
                _state.AttrSetInstEFGroupFieldLength = value;
            }
        }

        int? IAttributeSetInstanceExtensionFieldMvoStateProperties.AttrSetInstEFGroupFieldLength
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).AttrSetInstEFGroupFieldLength;
            }
            set 
            {
                this._state.AttrSetInstEFGroupFieldLength = value;
            }
        }

		public virtual int? AttrSetInstEFGroupFieldCount
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttrSetInstEFGroupFieldCount"))
                {
                    return _state.AttrSetInstEFGroupFieldCount;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttrSetInstEFGroupFieldCount = value.Value;
                }
            }
        }

        int IAttributeSetInstanceExtensionFieldMvoStateProperties.AttrSetInstEFGroupFieldCount
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).AttrSetInstEFGroupFieldCount;
            }
            set 
            {
                this._state.AttrSetInstEFGroupFieldCount = value;
            }
        }

		public virtual string AttrSetInstEFGroupNameFormat
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttrSetInstEFGroupNameFormat"))
                {
                    return _state.AttrSetInstEFGroupNameFormat;
                }
                return null;
            }
            set
            {
                _state.AttrSetInstEFGroupNameFormat = value;
            }
        }

        string IAttributeSetInstanceExtensionFieldMvoStateProperties.AttrSetInstEFGroupNameFormat
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).AttrSetInstEFGroupNameFormat;
            }
            set 
            {
                this._state.AttrSetInstEFGroupNameFormat = value;
            }
        }

		public virtual string AttrSetInstEFGroupDescription
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttrSetInstEFGroupDescription"))
                {
                    return _state.AttrSetInstEFGroupDescription;
                }
                return null;
            }
            set
            {
                _state.AttrSetInstEFGroupDescription = value;
            }
        }

        string IAttributeSetInstanceExtensionFieldMvoStateProperties.AttrSetInstEFGroupDescription
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).AttrSetInstEFGroupDescription;
            }
            set 
            {
                this._state.AttrSetInstEFGroupDescription = value;
            }
        }

		public virtual string AttrSetInstEFGroupCreatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttrSetInstEFGroupCreatedBy"))
                {
                    return _state.AttrSetInstEFGroupCreatedBy;
                }
                return null;
            }
            set
            {
                _state.AttrSetInstEFGroupCreatedBy = value;
            }
        }

        string IAttributeSetInstanceExtensionFieldMvoStateProperties.AttrSetInstEFGroupCreatedBy
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).AttrSetInstEFGroupCreatedBy;
            }
            set 
            {
                this._state.AttrSetInstEFGroupCreatedBy = value;
            }
        }

		public virtual DateTime? AttrSetInstEFGroupCreatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttrSetInstEFGroupCreatedAt"))
                {
                    return _state.AttrSetInstEFGroupCreatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.AttrSetInstEFGroupCreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttrSetInstEFGroupCreatedAt = value.Value;
                }
            }
        }

        DateTime IAttributeSetInstanceExtensionFieldMvoStateProperties.AttrSetInstEFGroupCreatedAt
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).AttrSetInstEFGroupCreatedAt;
            }
            set 
            {
                this._state.AttrSetInstEFGroupCreatedAt = value;
            }
        }

		public virtual string AttrSetInstEFGroupUpdatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttrSetInstEFGroupUpdatedBy"))
                {
                    return _state.AttrSetInstEFGroupUpdatedBy;
                }
                return null;
            }
            set
            {
                _state.AttrSetInstEFGroupUpdatedBy = value;
            }
        }

        string IAttributeSetInstanceExtensionFieldMvoStateProperties.AttrSetInstEFGroupUpdatedBy
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).AttrSetInstEFGroupUpdatedBy;
            }
            set 
            {
                this._state.AttrSetInstEFGroupUpdatedBy = value;
            }
        }

		public virtual DateTime? AttrSetInstEFGroupUpdatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttrSetInstEFGroupUpdatedAt"))
                {
                    return _state.AttrSetInstEFGroupUpdatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.AttrSetInstEFGroupUpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttrSetInstEFGroupUpdatedAt = value.Value;
                }
            }
        }

        DateTime IAttributeSetInstanceExtensionFieldMvoStateProperties.AttrSetInstEFGroupUpdatedAt
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).AttrSetInstEFGroupUpdatedAt;
            }
            set 
            {
                this._state.AttrSetInstEFGroupUpdatedAt = value;
            }
        }

		public virtual bool? AttrSetInstEFGroupActive
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttrSetInstEFGroupActive"))
                {
                    return _state.AttrSetInstEFGroupActive;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttrSetInstEFGroupActive = value.Value;
                }
            }
        }

        bool IAttributeSetInstanceExtensionFieldMvoStateProperties.AttrSetInstEFGroupActive
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).AttrSetInstEFGroupActive;
            }
            set 
            {
                this._state.AttrSetInstEFGroupActive = value;
            }
        }

		public virtual bool? AttrSetInstEFGroupDeleted
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttrSetInstEFGroupDeleted"))
                {
                    return _state.AttrSetInstEFGroupDeleted;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttrSetInstEFGroupDeleted = value.Value;
                }
            }
        }

        bool IAttributeSetInstanceExtensionFieldMvoStateProperties.AttrSetInstEFGroupDeleted
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).AttrSetInstEFGroupDeleted;
            }
            set 
            {
                this._state.AttrSetInstEFGroupDeleted = value;
            }
        }

		public virtual long? AttrSetInstEFGroupVersion
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttrSetInstEFGroupVersion"))
                {
                    return _state.AttrSetInstEFGroupVersion;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttrSetInstEFGroupVersion = value.Value;
                }
            }
        }

        long IAttributeSetInstanceExtensionFieldMvoStateProperties.AttrSetInstEFGroupVersion
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldMvoStateProperties).AttrSetInstEFGroupVersion;
            }
            set 
            {
                this._state.AttrSetInstEFGroupVersion = value;
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

		AttributeSetInstanceExtensionFieldId IGlobalIdentity<AttributeSetInstanceExtensionFieldId>.GlobalId
		{
			get { return (_state as IAttributeSetInstanceExtensionFieldMvoState).GlobalId; }
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
            get { return (_state as IAttributeSetInstanceExtensionFieldMvoState).CreatedBy; }
            set { (_state as IAttributeSetInstanceExtensionFieldMvoState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IAttributeSetInstanceExtensionFieldMvoState).CreatedAt; }
            set { (_state as IAttributeSetInstanceExtensionFieldMvoState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IAttributeSetInstanceExtensionFieldMvoState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IAttributeSetInstanceExtensionFieldMvoState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.AttrSetInstEFGroupVersion; }
		}

		#endregion

        bool IAttributeSetInstanceExtensionFieldMvoState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == AttributeSetInstanceExtensionFieldMvoState.VersionZero; }
        }


		void IAttributeSetInstanceExtensionFieldMvoState.When(IAttributeSetInstanceExtensionFieldMvoStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IAttributeSetInstanceExtensionFieldMvoState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IAttributeSetInstanceExtensionFieldMvoState.When(IAttributeSetInstanceExtensionFieldMvoStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IAttributeSetInstanceExtensionFieldMvoState.When(IAttributeSetInstanceExtensionFieldMvoStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IAttributeSetInstanceExtensionFieldMvoState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class AttributeSetInstanceExtensionFieldMvoStateDtoWrapperCollection : StateDtoWrapperCollectionBase<AttributeSetInstanceExtensionFieldMvoStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(AttributeSetInstanceExtensionFieldMvoStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}
