﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Metadata;
using Dddml.Wms.HttpServices.Filters;
using System.Linq;
using System.Net;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;

namespace Dddml.Wms.HttpServices.ApiControllers
{

    [RoutePrefix("api/OrganizationStructureTypes")][Authorize]
    public partial class OrganizationStructureTypesController : ApiController
    {

        IOrganizationStructureTypeApplicationService _organizationStructureTypeApplicationService = ApplicationContext.Current["OrganizationStructureTypeApplicationService"] as IOrganizationStructureTypeApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IOrganizationStructureTypeStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IOrganizationStructureTypeState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _organizationStructureTypeApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver())
                    , OrganizationStructureTypesControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _organizationStructureTypeApplicationService.Get(OrganizationStructureTypesControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , OrganizationStructureTypesControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IOrganizationStructureTypeStateDto>();
            foreach (var s in states)
            {
                var dto = s is OrganizationStructureTypeStateDtoWrapper ? (OrganizationStructureTypeStateDtoWrapper)s : new OrganizationStructureTypeStateDtoWrapper((OrganizationStructureTypeState)s);
                if (String.IsNullOrWhiteSpace(fields))
                {
                    dto.AllFieldsReturned = true;
                }
                else
                {
                    dto.ReturnedFieldsString = fields;
                }
                stateDtos.Add(dto);
            }
            return stateDtos;
          } catch (Exception ex) { var response = OrganizationStructureTypesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IOrganizationStructureTypeStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = id;
            var state = (OrganizationStructureTypeState)_organizationStructureTypeApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new OrganizationStructureTypeStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = OrganizationStructureTypesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }


        [Route("_count")]
        [HttpGet]
        public long GetCount(string filter = null)
        {
          try
          {
            long count = 0;
            if (!String.IsNullOrWhiteSpace(filter))
            {
                count = _organizationStructureTypeApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver()));
            }
            else 
            {
                count = _organizationStructureTypeApplicationService.GetCount(OrganizationStructureTypesControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = OrganizationStructureTypesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateOrganizationStructureTypeDto value)
        {
          try {
            OrganizationStructureTypesControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _organizationStructureTypeApplicationService.When(value as ICreateOrganizationStructureType);
          } catch (Exception ex) { var response = OrganizationStructureTypesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchOrganizationStructureTypeDto value)
        {
          try {
            OrganizationStructureTypesControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _organizationStructureTypeApplicationService.When(value as IMergePatchOrganizationStructureType);
          } catch (Exception ex) { var response = OrganizationStructureTypesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeleteOrganizationStructureTypeDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.Version = (long)Convert.ChangeType(version, typeof(long));
            OrganizationStructureTypesControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _organizationStructureTypeApplicationService.When(value as IDeleteOrganizationStructureType);
          } catch (Exception ex) { var response = OrganizationStructureTypesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadata> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadata>();
            foreach (var p in OrganizationStructureTypeMetadata.Instance.Properties)
            {
                if (p.IsFilteringProperty)
                {
                    filtering.Add(p);
                }
            }
            return filtering;
          } catch (Exception ex) { var response = OrganizationStructureTypesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public OrganizationStructureTypeStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = id;
            var conv = new OrganizationStructureTypeStateEventDtoConverter();
            var se = _organizationStructureTypeApplicationService.GetStateEvent(idObj, version);
            return se == null ? null : conv.ToOrganizationStructureTypeStateEventDto(se);
          } catch (Exception ex) { var response = OrganizationStructureTypesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IOrganizationStructureTypeStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = id;
            var state = (OrganizationStructureTypeState)_organizationStructureTypeApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new OrganizationStructureTypeStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = OrganizationStructureTypesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }


		// /////////////////////////////////////////////////

        protected virtual string QueryOrderSeparator
        {
            get { return ","; }
        }

        // ////////////////////////////////

        private class ApiControllerTypeConverter : Dddml.Support.Criterion.ITypeConverter
        {
            public T ConvertFromString<T>(string text)
            {
                return (T)ApplicationContext.Current.TypeConverter.ConvertFromString(typeof(T), text);
            }

            public object ConvertFromString(Type type, string text)
            {
                return ApplicationContext.Current.TypeConverter.ConvertFromString(type, text);
            }

            public string ConvertToString<T>(T value)
            {
                return ApplicationContext.Current.TypeConverter.ConvertToString(typeof(T), value);
            }

            public string ConvertToString(object value)
            {
                return ApplicationContext.Current.TypeConverter.ConvertToString(value.GetType(), value);
            }

            public string[] ConvertToStringArray(object[] values)
            {
                throw new NotSupportedException();
            }
        }

        private class PropertyTypeResolver : IPropertyTypeResolver
        {

            public Type ResolveTypeByPropertyName(string propertyName)
            {
                return OrganizationStructureTypesControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class OrganizationStructureTypesControllerUtils
    {

        public static HttpResponseMessage GetErrorHttpResponseMessage(Exception ex)
        {
            var errorName = ex.GetType().Name;
            var errorMessage = ex.Message;
            if (ex is DomainError)
            {
                DomainError de = ex as DomainError;
                errorName = de.Name;
                errorMessage = de.Message;
            }
            else
            {
                //改进??
                errorMessage = String.IsNullOrWhiteSpace(ex.Message) ? String.Empty : ex.Message.Substring(0, (ex.Message.Length > 140) ? 140 : ex.Message.Length);
            }
            dynamic content = new JObject();
            content.ErrorName = errorName;
            content.ErrorMessage = errorMessage;
            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new ObjectContent<JObject>(content as JObject, new JsonMediaTypeFormatter()),
                ReasonPhrase = "Server Error"
            };
            return response;
        }

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteOrganizationStructureTypeDto value)
        {
            var idObj = id;
            if (value.Id == null)
            {
                value.Id = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteOrganizationStructureType)value).Id.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.Id);
            }
        }


        public static string GetFilterPropertyName(string fieldName)
        {
            if (String.Equals(fieldName, "sort", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "firstResult", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "maxResults", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "fields", StringComparison.InvariantCultureIgnoreCase))
            {
                return null;
            }
            if (OrganizationStructureTypeMetadata.Instance.PropertyMetadataDictionary.ContainsKey(fieldName))
            {
                var p = OrganizationStructureTypeMetadata.Instance.PropertyMetadataDictionary[fieldName];
                if (p.IsFilteringProperty)
                {
                    var propertyName = fieldName;
                    if (p.IsDerived)
                    {
                        propertyName = p.DerivedFrom;
                    }
                    return propertyName;
                }
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (OrganizationStructureTypeMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return OrganizationStructureTypeMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
            }
            return typeof(string);
        }

        public static IDictionary<string, object> GetQueryFilterDictionary(IEnumerable<KeyValuePair<string, string>> queryNameValuePairs)
        {
            var filter = new Dictionary<string, object>();
            foreach (var p in queryNameValuePairs)
            {
                var pName = GetFilterPropertyName(p.Key);
                if (!String.IsNullOrWhiteSpace(pName))
                {
                    Type type = GetFilterPropertyType(pName);
                    var pValue = ApplicationContext.Current.TypeConverter.ConvertFromString(type, p.Value);
                    filter.Add(pName, pValue);
                }
            }
            return filter;
        }

        public static IList<string> GetQueryOrders(string str, string separator)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                return new string[0];
            }
            var arr = str.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
            var orders = new List<string>();
            foreach (var a in arr)
            {
                orders.Add(a.Trim());
            }
            return orders;
        }

        public static IEnumerable<IOrganizationStructureTypeStateDto> ToOrganizationStructureTypeStateDtoCollection(IEnumerable<string> ids)
        {
            var states = new List<IOrganizationStructureTypeStateDto>();
            foreach (var id in ids)
            {
                var dto = new OrganizationStructureTypeStateDtoWrapper();
                dto.Id = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IOrganizationStructureTypeState> ToOrganizationStructureTypeStateCollection(IEnumerable<string> ids)
        {
            var states = new List<OrganizationStructureTypeState>();
            foreach (var id in ids)
            {
                var s = new OrganizationStructureTypeState();
                s.Id = id;
                states.Add(s);
            }
            return states;
        }

    }

}

