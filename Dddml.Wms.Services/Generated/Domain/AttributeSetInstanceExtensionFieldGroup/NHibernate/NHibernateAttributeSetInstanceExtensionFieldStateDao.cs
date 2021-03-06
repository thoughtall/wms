﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldGroupDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup.NHibernate
{

	public class NHibernateAttributeSetInstanceExtensionFieldStateDao : IAttributeSetInstanceExtensionFieldStateDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "Index", "Name", "Type", "Length", "Alias", "Description", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "GroupId" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateAttributeSetInstanceExtensionFieldStateDao()
		{
		}

        [Transaction(ReadOnly = true)]
        public IAttributeSetInstanceExtensionFieldState Get(AttributeSetInstanceExtensionFieldId id, bool nullAllowed)
        {
            IAttributeSetInstanceExtensionFieldState state = CurrentSession.Get<AttributeSetInstanceExtensionFieldState>(id);
            if (!nullAllowed && state == null)
            {
                state = new AttributeSetInstanceExtensionFieldState();
                (state as AttributeSetInstanceExtensionFieldState).AttributeSetInstanceExtensionFieldId = id;
            }
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IAttributeSetInstanceExtensionFieldState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
            return state;
        }

       
        public void Save(IAttributeSetInstanceExtensionFieldState state)
        {
            IAttributeSetInstanceExtensionFieldState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IAttributeSetInstanceExtensionFieldState>(state);
            }
            CurrentSession.SaveOrUpdate(s);
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }


        public void Delete(IAttributeSetInstanceExtensionFieldState state)
        {
            IAttributeSetInstanceExtensionFieldState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IAttributeSetInstanceExtensionFieldState>(state);
            }
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
            CurrentSession.Delete(s);
        }


        [Transaction(ReadOnly = true)]
        public IEnumerable<IAttributeSetInstanceExtensionFieldState> FindByGroupId(string groupId)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceExtensionFieldState>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("AttributeSetInstanceExtensionFieldId.GroupId", groupId))
                ;

            return criteria.Add(partIdCondition).List<AttributeSetInstanceExtensionFieldState>();
        }

    }

	
}

