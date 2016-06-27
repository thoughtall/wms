﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.NHibernate
{

	public class NHibernateUserRoleStateDao : IUserRoleStateDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

		public NHibernateUserRoleStateDao()
		{
		}
 

        [Transaction(ReadOnly = true)]
        public IUserRoleState Get(UserRoleId id)
        {
            IUserRoleState state = CurrentSession.Get<UserRoleState>(id);
            if (state == null)
            {
                state = new UserRoleState();
                (state as UserRoleState).UserRoleId = id;
            }
            return state;
        }

       
        public void Save(IUserRoleState state)
        {
            CurrentSession.SaveOrUpdate(state);
            var saveable = state as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }


        public void Delete(IUserRoleState state)
        {
            var saveable = state as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
            CurrentSession.Delete(state);
        }


        [Transaction(ReadOnly = true)]
        public IEnumerable<IUserRoleState> FindByUserId(string userId)
        {
            var criteria = CurrentSession.CreateCriteria<UserRoleState>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("UserRoleId.UserId", userId))
                ;

            return criteria.Add(partIdCondition).List<UserRoleState>();
        }

    }

	
}
