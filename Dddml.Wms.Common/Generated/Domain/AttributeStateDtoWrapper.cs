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

	public partial class AttributeStateDtoWrapper : StateDtoWrapperBase, IAttributeStateDto, IAttributeState
	{

        internal static IList<string> _collectionFieldNames = new string[] { "AttributeValues" };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IAttributeState _state;

        public AttributeStateDtoWrapper()
        {
            this._state = new AttributeState();
        }

		public AttributeStateDtoWrapper(IAttributeState state)
		{
            this._state = state;
		}

		public IAttributeState ToAttributeState()
		{
			return this._state;
		}

		public virtual string AttributeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeId"))
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

        string IAttributeStateProperties.AttributeId
        {
            get 
            {
                return (this._state as IAttributeStateProperties).AttributeId;
            }
            set 
            {
                (this._state as IAttributeStateProperties).AttributeId = value;
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

        string IAttributeStateProperties.Name
        {
            get 
            {
                return (this._state as IAttributeStateProperties).Name;
            }
            set 
            {
                (this._state as IAttributeStateProperties).Name = value;
            }
        }

		public virtual string OrganizationId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrganizationId"))
                {
                    return _state.OrganizationId;
                }
                return null;
            }
            set
            {
                _state.OrganizationId = value;
            }
        }

        string IAttributeStateProperties.OrganizationId
        {
            get 
            {
                return (this._state as IAttributeStateProperties).OrganizationId;
            }
            set 
            {
                (this._state as IAttributeStateProperties).OrganizationId = value;
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

        string IAttributeStateProperties.Description
        {
            get 
            {
                return (this._state as IAttributeStateProperties).Description;
            }
            set 
            {
                (this._state as IAttributeStateProperties).Description = value;
            }
        }

		public virtual bool? IsMandatory
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsMandatory"))
                {
                    return _state.IsMandatory;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsMandatory = value.Value;
                }
            }
        }

        bool IAttributeStateProperties.IsMandatory
        {
            get 
            {
                return (this._state as IAttributeStateProperties).IsMandatory;
            }
            set 
            {
                (this._state as IAttributeStateProperties).IsMandatory = value;
            }
        }

		public virtual bool? IsInstanceAttribute
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsInstanceAttribute"))
                {
                    return _state.IsInstanceAttribute;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsInstanceAttribute = value.Value;
                }
            }
        }

        bool IAttributeStateProperties.IsInstanceAttribute
        {
            get 
            {
                return (this._state as IAttributeStateProperties).IsInstanceAttribute;
            }
            set 
            {
                (this._state as IAttributeStateProperties).IsInstanceAttribute = value;
            }
        }

		public virtual string AttributeValueType
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeValueType"))
                {
                    return _state.AttributeValueType;
                }
                return null;
            }
            set
            {
                _state.AttributeValueType = value;
            }
        }

        string IAttributeStateProperties.AttributeValueType
        {
            get 
            {
                return (this._state as IAttributeStateProperties).AttributeValueType;
            }
            set 
            {
                (this._state as IAttributeStateProperties).AttributeValueType = value;
            }
        }

		public virtual int? AttributeValueLength
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeValueLength"))
                {
                    return _state.AttributeValueLength;
                }
                return null;
            }
            set
            {
                _state.AttributeValueLength = value;
            }
        }

        int? IAttributeStateProperties.AttributeValueLength
        {
            get 
            {
                return (this._state as IAttributeStateProperties).AttributeValueLength;
            }
            set 
            {
                (this._state as IAttributeStateProperties).AttributeValueLength = value;
            }
        }

		public virtual bool? IsList
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsList"))
                {
                    return _state.IsList;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsList = value.Value;
                }
            }
        }

        bool IAttributeStateProperties.IsList
        {
            get 
            {
                return (this._state as IAttributeStateProperties).IsList;
            }
            set 
            {
                (this._state as IAttributeStateProperties).IsList = value;
            }
        }

		public virtual string FieldName
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("FieldName"))
                {
                    return _state.FieldName;
                }
                return null;
            }
            set
            {
                _state.FieldName = value;
            }
        }

        string IAttributeStateProperties.FieldName
        {
            get 
            {
                return (this._state as IAttributeStateProperties).FieldName;
            }
            set 
            {
                (this._state as IAttributeStateProperties).FieldName = value;
            }
        }

		public virtual string ReferenceId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ReferenceId"))
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

        string IAttributeStateProperties.ReferenceId
        {
            get 
            {
                return (this._state as IAttributeStateProperties).ReferenceId;
            }
            set 
            {
                (this._state as IAttributeStateProperties).ReferenceId = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IAttributeStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IAttributeStateProperties).Active = value.Value;
                }
            }
        }

        bool IAttributeStateProperties.Active
        {
            get 
            {
                return (this._state as IAttributeStateProperties).Active;
            }
            set 
            {
                (this._state as IAttributeStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IAttributeStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IAttributeStateProperties).Version = value.Value;
                }
            }
        }

        long IAttributeStateProperties.Version
        {
            get 
            {
                return (this._state as IAttributeStateProperties).Version;
            }
            set 
            {
                (this._state as IAttributeStateProperties).Version = value;
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
			get { return (_state as IAttributeState).GlobalId; }
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
            return (_state as IActive).IsActive();
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
            get { return (_state as IAttributeState).CreatedBy; }
            set { (_state as IAttributeState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IAttributeState).CreatedAt; }
            set { (_state as IAttributeState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IAttributeState).UpdatedBy; }
            set { (_state as IAttributeState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IAttributeState).UpdatedAt; }
            set { (_state as IAttributeState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IAttributeStateProperties).Version; }
		}

		#endregion

        bool IAttributeState.IsUnsaved
        {
            get { return this.Version == AttributeState.VersionZero; }
        }

        public virtual IAttributeValueStateDto[] AttributeValues
        {
            get 
            {
                if (!(this as IStateDtoWrapper).ReturnedFieldsContains("AttributeValues"))
                {
                    return null;
                }
                var dtos = new List<IAttributeValueStateDto>();
                if (this._state.AttributeValues != null)
                {
                    foreach (var s in this._state.AttributeValues)
                    {
                        var dto = new AttributeValueStateDtoWrapper((AttributeValueState)s);
                        var returnFS = CollectionUtils.DictionaryGetValueIgnoringCase(ReturnedFields, "AttributeValues");
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
                if (value == null) { value = new AttributeValueStateDtoWrapper[0]; }
                var states = new List<IAttributeValueState>();
                foreach (var s in value)
                {
                    states.Add(s.ToAttributeValueState());
                }
                this._state.AttributeValues = new DtoAttributeValueStates(this._state, states);
            }
        }

        IAttributeValueStates IAttributeState.AttributeValues
        {
            get { return _state.AttributeValues; }
            set { _state.AttributeValues = value; }
        }


		void IAttributeState.When(IAttributeStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IAttributeState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IAttributeState.When(IAttributeStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IAttributeState.When(IAttributeStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IAttributeState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


        public class DtoAttributeValueStates : IAttributeValueStates
        {

            private IAttributeState _outerState;

            private IEnumerable<IAttributeValueState> _innerStates;

            public DtoAttributeValueStates(IAttributeState outerState, IEnumerable<IAttributeValueState> innerStates)
            {
                this._outerState = outerState;
                if (innerStates == null)
                {
                    this._innerStates = new IAttributeValueState[] { };
                }
                else
                {
                    this._innerStates = innerStates;
                }
            }

            public IEnumerator<IAttributeValueState> GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            public IAttributeValueState Get(string value)
            {
                throw new NotSupportedException();
            }

            public IAttributeValueState Get(string value, bool forCreation)
            {
                throw new NotSupportedException();
            }

            public IAttributeValueState Get(string value, bool forCreation, bool nullAllowed)
            {
                throw new NotSupportedException();
            }

            public void Remove(IAttributeValueState state)
            {
                throw new NotSupportedException();
            }

            public void AddToSave(IAttributeValueState state)
            {
                throw new NotSupportedException();
            }

            public void Save()
            {
                throw new NotSupportedException();
            }
        }

	}

    partial class AttributeStateDtoWrapperCollection : StateDtoWrapperCollectionBase<AttributeStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(AttributeStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

