﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateTreeControllers.tt.
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

    [RoutePrefix("api/LocatorTrees")][Authorize]
    public partial class LocatorTreesController : ApiController
    {

        ILocatorTreeApplicationService _locatorTreeApplicationService = ApplicationContext.Current["LocatorTreeApplicationService"] as ILocatorTreeApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<ILocatorStateDto> Get(string parentId = null, string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            var parentIdObj = parentId == null ? null : parentId;
            IEnumerable<ILocatorState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                if (parentIdObj == null)
                {
                    if (IsOnlyIdReturned(fields))
                    {
                        var ids = _locatorTreeApplicationService.GetRootIds(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver())
                            , LocatorsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
                        states = LocatorsControllerUtils.ToLocatorStateCollection(ids);
                    }
                    else
                    {
                        states = _locatorTreeApplicationService.GetRoots(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver())
                            , LocatorsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
                    }
                }
                else
                {
                    if (IsOnlyIdReturned(fields))
                    {
                        var ids = _locatorTreeApplicationService.GetChildIds(parentIdObj, CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver())
                            , LocatorsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
                        states = LocatorsControllerUtils.ToLocatorStateCollection(ids);
                    }
                    else
                    {
                        states = _locatorTreeApplicationService.GetChildren(parentIdObj, CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver())
                            , LocatorsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
                    }
                }
            }
            else
            {
                if (parentIdObj == null)
                {
                    if (IsOnlyIdReturned(fields))
                    {
                        var ids = _locatorTreeApplicationService.GetRootIds(LocatorsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                            , LocatorsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
                        states = LocatorsControllerUtils.ToLocatorStateCollection(ids);
                    }
                    else
                    {
                        states = _locatorTreeApplicationService.GetRoots(LocatorsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                            , LocatorsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
                    }
                }
                else
                {
                    if (IsOnlyIdReturned(fields))
                    {
                        var ids = _locatorTreeApplicationService.GetChildIds(parentIdObj, LocatorsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                            , LocatorsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
                        states = LocatorsControllerUtils.ToLocatorStateCollection(ids);
                    }
                    else
                    {
                        states = _locatorTreeApplicationService.GetChildren(parentIdObj, LocatorsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                            , LocatorsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
                    }
                }
            }
            var stateDtos = new List<ILocatorStateDto>();
            foreach (var s in states)
            {
                var dto = s is LocatorStateDtoWrapper ? (LocatorStateDtoWrapper)s : new LocatorStateDtoWrapper((LocatorState)s);
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
          } catch (Exception ex) { var response = LocatorsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadata> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadata>();
            foreach (var p in LocatorMetadata.Instance.Properties)
            {
                if (p.IsFilteringProperty)
                {
                    filtering.Add(p);
                }
            }
            return filtering;
          } catch (Exception ex) { var response = LocatorsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

		// /////////////////////////////////////////////////

        protected bool IsOnlyIdReturned(string fields)
        {
            if (String.Equals(fields, "LocatorId", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }


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
                return LocatorsControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }

}

