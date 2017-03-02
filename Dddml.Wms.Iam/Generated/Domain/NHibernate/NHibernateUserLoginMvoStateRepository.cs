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
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.NHibernate
{

	public partial class NHibernateUserLoginMvoStateRepository : IUserLoginMvoStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "UserLoginId", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "UserUserName", "UserAccessFailedCount", "UserEmail", "UserEmailConfirmed", "UserLockoutEnabled", "UserLockoutEndDateUtc", "UserPasswordHash", "UserPhoneNumber", "UserPhoneNumberConfirmed", "UserTwoFactorEnabled", "UserSecurityStamp", "UserUserRoles", "UserUserClaims", "UserUserPermissions", "UserUserLogins", "UserVersion", "UserCreatedBy", "UserCreatedAt", "UserUpdatedBy", "UserUpdatedAt", "UserActive", "UserDeleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateUserLoginMvoStateRepository()
		{
		}

		[Transaction (ReadOnly = true)]
		public IUserLoginMvoState Get(UserLoginId id, bool nullAllowed)
		{
			IUserLoginMvoState state = CurrentSession.Get<UserLoginMvoState> (id);
			if (!nullAllowed && state == null) {
				state = new UserLoginMvoState ();
				(state as UserLoginMvoState).UserLoginId = id;
			}
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IUserLoginMvoState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
			return state;
		}

		[Transaction]
		public void Save(IUserLoginMvoState state)
		{
            IUserLoginMvoState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IUserLoginMvoState>(state);
            }
			CurrentSession.SaveOrUpdate (s);

			var saveable = s as ISaveable;
			if (saveable != null) {
				saveable.Save ();
			}
		}

        //protected static void AddNotDeletedRestriction(ICriteria criteria)
        //{
        //    criteria.Add(NHibernateRestrictions.Eq("Deleted", false));
        //}

	}
}
