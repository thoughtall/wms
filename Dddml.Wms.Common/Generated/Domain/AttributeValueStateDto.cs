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

	public partial class AttributeValueStateDto : StateDtoBase, IAttributeValueStateDto, IAttributeValueState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private AttributeValueState _state;

        public AttributeValueStateDto()
        {
            this._state = new AttributeValueState();
        }

		public AttributeValueStateDto(AttributeValueState state)
		{
            this._state = state;
		}

		internal AttributeValueState ToAttributeValueState()
		{
			return this._state;
		}

		public virtual string Value
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Value"))
                {
                    return _state.Value;
                }
                return null;
            }
            set
            {
                _state.Value = value;
            }
        }

        string IAttributeValueStateProperties.Value
        {
            get 
            {
                return (this._state as IAttributeValueStateProperties).Value;
            }
            set 
            {
                this._state.Value = value;
            }
        }

		public virtual string Name
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Name"))
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

        string IAttributeValueStateProperties.Name
        {
            get 
            {
                return (this._state as IAttributeValueStateProperties).Name;
            }
            set 
            {
                this._state.Name = value;
            }
        }

		public virtual string Description
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Description"))
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

        string IAttributeValueStateProperties.Description
        {
            get 
            {
                return (this._state as IAttributeValueStateProperties).Description;
            }
            set 
            {
                this._state.Description = value;
            }
        }

		public virtual string ReferenceId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("ReferenceId"))
                {
                    return _state.ReferenceId;
                }
                return null;
            }
            set
            {
                _state.ReferenceId = value;
            }
        }

        string IAttributeValueStateProperties.ReferenceId
        {
            get 
            {
                return (this._state as IAttributeValueStateProperties).ReferenceId;
            }
            set 
            {
                this._state.ReferenceId = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Active"))
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

        bool IAttributeValueStateProperties.Active
        {
            get 
            {
                return (this._state as IAttributeValueStateProperties).Active;
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
                if ((this as IStateDto).ReturnedFieldsContains("Version"))
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

        long IAttributeValueStateProperties.Version
        {
            get 
            {
                return (this._state as IAttributeValueStateProperties).Version;
            }
            set 
            {
                this._state.Version = value;
            }
        }

		public virtual string AttributeId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeId"))
                {
                    return _state.AttributeId;
                }
                return null;
            }
            set
            {
                _state.AttributeId = value;
            }
        }

        string IAttributeValueStateProperties.AttributeId
        {
            get 
            {
                return (this._state as IAttributeValueStateProperties).AttributeId;
            }
            set 
            {
                this._state.AttributeId = value;
            }
        }

		public virtual string CreatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("CreatedBy"))
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
                if ((this as IStateDto).ReturnedFieldsContains("CreatedAt"))
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
                if ((this as IStateDto).ReturnedFieldsContains("UpdatedBy"))
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
                if ((this as IStateDto).ReturnedFieldsContains("UpdatedAt"))
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


		AttributeValueId IGlobalIdentity<AttributeValueId>.GlobalId {
			get { return (_state as IAttributeValueState).GlobalId; }
		}

        string ILocalIdentity<string>.LocalId
        {
			get { return (_state as IAttributeValueState).LocalId; }
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
            get { return (_state as IAttributeValueState).CreatedBy; }
            set { (_state as IAttributeValueState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IAttributeValueState).CreatedAt; }
            set { (_state as IAttributeValueState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IAttributeValueState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IAttributeValueState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.Version; }
		}

		#endregion

        bool IAttributeValueState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == AttributeValueState.VersionZero; }
        }


		void IAttributeValueState.When(IAttributeValueStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IAttributeValueState.When(IAttributeValueStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IAttributeValueState.When(IAttributeValueStateRemoved e)
		{
            throw new NotSupportedException();
		}


		void IAttributeValueState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class AttributeValueStateDtoCollection : StateDtoCollectionBase<AttributeValueStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(AttributeValueStateDto._collectionFieldNames, fieldName);
        }

    }

}

