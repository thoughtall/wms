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

	public static partial class AttributeValueStateDtoExtensions
	{

        public static IAttributeValueCommand ToCreateOrMergePatchAttributeValue(this AttributeValueStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchAttributeValue<CreateAttributeValueDto, MergePatchAttributeValueDto>();
        }

        public static RemoveAttributeValueDto ToRemoveAttributeValue(this AttributeValueStateDtoWrapper state)
        {
            return state.ToRemoveAttributeValue<RemoveAttributeValueDto>();
        }

        public static MergePatchAttributeValueDto ToMergePatchAttributeValue(this AttributeValueStateDtoWrapper state)
        {
            return state.ToMergePatchAttributeValue<MergePatchAttributeValueDto>();
        }

        public static CreateAttributeValueDto ToCreateAttributeValue(this AttributeValueStateDtoWrapper state)
        {
            return state.ToCreateAttributeValue<CreateAttributeValueDto>();
        }
		

	}

}

