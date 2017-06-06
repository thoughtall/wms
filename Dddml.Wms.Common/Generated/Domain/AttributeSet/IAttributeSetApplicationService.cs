﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.AttributeSet
{

	public partial interface IAttributeSetApplicationService : IApplicationService
	{
		void When(ICreateAttributeSet c);

		void When(IMergePatchAttributeSet c);

		void When(IDeleteAttributeSet c);

 		IAttributeSetState Get(string attributeSetId);

        IEnumerable<IAttributeSetState> GetAll(int firstResult, int maxResults);

        IEnumerable<IAttributeSetState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeSetState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeSetState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IAttributeSetStateEvent GetStateEvent(string attributeSetId, long version);

        IAttributeSetState GetHistoryState(string attributeSetId, long version);

        IAttributeUseState GetAttributeUse(string attributeSetId, string attributeId);


	}

}
