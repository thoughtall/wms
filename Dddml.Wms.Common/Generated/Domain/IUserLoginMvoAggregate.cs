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

	public partial interface IUserLoginMvoAggregate : IGlobalIdentity<UserLoginId>
	{
		IUserLoginMvoState State { get; }

		IList<IEvent> Changes { get; }

		void ThrowOnInvalidStateTransition (ICommand c);

		void Create (ICreateUserLoginMvo c);

		void MergePatch (IMergePatchUserLoginMvo c);

		void Delete (IDeleteUserLoginMvo c);


	}

}

