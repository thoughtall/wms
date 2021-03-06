﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeValueMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeValueMvo;
using Dddml.Wms.Domain.Attribute;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.AttributeValueMvo
{
	public partial interface IAttributeValueMvoStateQueryRepository
	{
        IAttributeValueMvoState Get(AttributeValueId id);

        IEnumerable<IAttributeValueMvoState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<IAttributeValueMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeValueMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IAttributeValueMvoState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IAttributeValueMvoState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<IAttributeValueMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

	}

}

