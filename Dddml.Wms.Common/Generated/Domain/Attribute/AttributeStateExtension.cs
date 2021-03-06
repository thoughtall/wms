﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{

	public static partial class AttributeStateExtension
	{

        public static IAttributeCommand ToCreateOrMergePatchAttribute(this AttributeState state)
        {
            return state.ToCreateOrMergePatchAttribute<CreateAttribute, MergePatchAttribute, CreateAttributeValue, MergePatchAttributeValue>();
        }

        public static DeleteAttribute ToDeleteAttribute(this AttributeState state)
        {
            return state.ToDeleteAttribute<DeleteAttribute>();
        }

        public static MergePatchAttribute ToMergePatchAttribute(this AttributeState state)
        {
            return state.ToMergePatchAttribute<MergePatchAttribute, CreateAttributeValue, MergePatchAttributeValue>();
        }

        public static CreateAttribute ToCreateAttribute(this AttributeState state)
        {
            return state.ToCreateAttribute<CreateAttribute, CreateAttributeValue>();
        }
		

	}

}

