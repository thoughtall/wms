﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.HttpServices.ApiControllers
{

    public partial class AttributesController : ApiController
    {

        IAttributeApplicationService _attributeApplicationService = ApplicationContext.Current["AttributeApplicationService"] as IAttributeApplicationService;

        [HttpGet]
        public IEnumerable<AttributeStateDto> GetAll(int firstResult = 0, int maxResults = int.MaxValue)
        {
            var states = _attributeApplicationService.GetAll(firstResult, maxResults);
            var stateDtos = new List<AttributeStateDto>();
            foreach (var s in states)
            {
                stateDtos.Add(new AttributeStateDto((AttributeState)s));
            }
            return stateDtos;
        }

        [HttpGet]
        public AttributeStateDto Get(string id)
        {
            var idObj = id;
            var state = (AttributeState)_attributeApplicationService.Get(idObj);
            var stateDto = new AttributeStateDto(state);
            stateDto.AllFieldsReturned = true;
            return stateDto;
        }

        [HttpPut]
        public void Put(string id, [FromBody]CreateAttributeDto value)
        {
            SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeApplicationService.When(value.ToCommand() as ICreateAttribute);
        }

        [HttpPatch]
        public void Patch(string id, [FromBody]MergePatchAttributeDto value)
        {
            SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeApplicationService.When(value.ToCommand() as IMergePatchAttribute);
        }

       [HttpDelete]
        public void Delete(string id, string commandId, string requesterId = default(string))
        {
            var value = new DeleteAttributeDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeApplicationService.When(value.ToCommand() as IDeleteAttribute);
        }

		// /////////////////////////////////////////////////

        protected static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteAttributeDto value)
        {
            var idObj = id;
            
            if (value.AttributeId == null)
            {
                value.AttributeId = idObj;
            }
            else if ((value as IAttributeStateProperties).AttributeId != idObj)
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.AttributeId);
            }
        }


    }


}

