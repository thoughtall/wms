﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.HttpServices.ClientProxies.Raml;
using Dddml.Wms.HttpServices.ClientProxies.Raml.Models;
using System.Text;
using System.ComponentModel;
using RAML.Api.Core;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;


namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class InOutLineMvoApplicationServiceProxy : IInOutLineMvoApplicationService
    {


        private DddmlWmsRamlClient _ramlClient;

        public InOutLineMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public InOutLineMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public void When(CreateInOutLineMvoDto c)
        {
            var idObj = InOutLineMvoProxyUtils.ToIdString((c as ICreateInOutLineMvo).InOutLineId);
            var uriParameters = new InOutLineMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new InOutLineMvoPutRequest(uriParameters, (CreateInOutLineMvoDto)c);
                
            var resp = _ramlClient.InOutLineMvo.Put(req).GetAwaiter().GetResult();
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchInOutLineMvoDto c)
        {
            var idObj = InOutLineMvoProxyUtils.ToIdString((c as IMergePatchInOutLineMvo).InOutLineId);
            var uriParameters = new InOutLineMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new InOutLineMvoPatchRequest(uriParameters, (MergePatchInOutLineMvoDto)c);
            var resp = _ramlClient.InOutLineMvo.Patch(req).GetAwaiter().GetResult();
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteInOutLineMvoDto c)
        {
            //Action act = async () =>
            //{
            var idObj = InOutLineMvoProxyUtils.ToIdString((c as IDeleteInOutLineMvo).InOutLineId);
            var uriParameters = new InOutLineMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new InOutLineMvoDeleteQuery();
            q.CommandId = c.CommandId;
                
            var req = new InOutLineMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = _ramlClient.InOutLineMvo.Delete(req).GetAwaiter().GetResult();
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            //};
            //act();
        }
		
        void IInOutLineMvoApplicationService.When(ICreateInOutLineMvo c)
        {
            this.When((CreateInOutLineMvoDto)c);
        }

        void IInOutLineMvoApplicationService.When(IMergePatchInOutLineMvo c)
        {
            this.When((MergePatchInOutLineMvoDto)c);
        }

        void IInOutLineMvoApplicationService.When(IDeleteInOutLineMvo c)
        {
            this.When((DeleteInOutLineMvoDto)c);
        }

        public IInOutLineMvoState Get(InOutLineId inOutLineId)
        {
            IInOutLineMvoState state = null;
            var idObj = InOutLineMvoProxyUtils.ToIdString(inOutLineId);
            var uriParameters = new InOutLineMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new InOutLineMvoGetRequest(uriParameters);

            var resp = _ramlClient.InOutLineMvo.Get(req).GetAwaiter().GetResult();
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IEnumerable<IInOutLineMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IInOutLineMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IInOutLineMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInOutLineMvoState> states = null;
			var q = new InOutLineMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InOutLineMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InOutLineMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = InOutLineMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InOutLineMvosGetRequest();
            req.Query = q;
            var resp = _ramlClient.InOutLineMvos.Get(req).GetAwaiter().GetResult();
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }


        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IInOutLineMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IInOutLineMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInOutLineMvoState> states = null;
			var q = new InOutLineMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InOutLineMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InOutLineMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = InOutLineMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new InOutLineMvosGetRequest();
            req.Query = q;
            var resp = _ramlClient.InOutLineMvos.Get(req).GetAwaiter().GetResult();
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new InOutLineMvosCountGetQuery();
            q.FilterTag = InOutLineMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InOutLineMvosCountGetRequest();
            req.Query = q;
            var resp = _ramlClient.InOutLineMvosCount.Get(req).GetAwaiter().GetResult();
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(resp.RawContent.ReadAsStringAsync().GetAwaiter().GetResult());
		}

        public virtual long GetCount(ICriterion filter)
		{
			var q = new InOutLineMvosCountGetQuery();
            q.Filter = InOutLineMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new InOutLineMvosCountGetRequest();
            req.Query = q;
            var resp = _ramlClient.InOutLineMvosCount.Get(req).GetAwaiter().GetResult();
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(resp.RawContent.ReadAsStringAsync().GetAwaiter().GetResult());
		}

        public IInOutLineMvoStateEvent GetStateEvent(InOutLineId inOutLineId, long version)
        {
            var idObj = InOutLineMvoProxyUtils.ToIdString(inOutLineId);
            var uriParameters = new InOutLineMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InOutLineMvoStateEventGetRequest(uriParameters);
            var resp = _ramlClient.InOutLineMvoStateEvent.Get(req).GetAwaiter().GetResult();
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }


        protected virtual string QueryFieldValueSeparator
        {
            get { return ","; }
        }

        protected virtual string QueryOrderSeparator
        {
            get { return ","; }
        }

    }


    public partial class InOutLineMvoApplicationServiceProxyFactory : IInOutLineMvoApplicationServiceFactory
    {

        private string _endpointUrl;

        public InOutLineMvoApplicationServiceProxyFactory(string endpointUrl)
        {
            this._endpointUrl = endpointUrl;
        }

        public IInOutLineMvoApplicationService InOutLineMvoApplicationService
        {
            get
            {
                return new InOutLineMvoApplicationServiceProxy(_endpointUrl);
            }
        }

        public ICreateInOutLineMvo NewCreateInOutLineMvo()
        {
            return new CreateInOutLineMvoDto();
        }

        public IMergePatchInOutLineMvo NewMergePatchInOutLineMvo()
        {
            return new MergePatchInOutLineMvoDto();
        }

        public IDeleteInOutLineMvo NewDeleteInOutLineMvo()
        {
            return new DeleteInOutLineMvoDto();
        }
    }

    public static class InOutLineMvoProxyUtils
    {

        private class ProxyTypeConverter : Dddml.Support.Criterion.ITypeConverter
        {
            public T ConvertFromString<T>(string text)
            {
                throw new NotSupportedException();
            }

            public object ConvertFromString(Type type, string text)
            {
                throw new NotSupportedException();
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

        public static string ToIdString(InOutLineId id)
        {
            var formatter = new InOutLineIdFlattenedDtoFormatter();
            var idDto = new InOutLineIdFlattenedDto(id);
            var idStr = formatter.ToString(idDto);
            return idStr;
        }


        public static string GetFilterQueryValueString(ICriterion filter)
        {
            if (filter == null) { return null; }
            return WebUtility.UrlEncode(JObject.FromObject(new CriterionDto(filter, new ProxyTypeConverter())).ToString());
        }

        public static string GetFilterTagQueryValueString(IEnumerable<KeyValuePair<string, object>> filter)
        {
            if (filter == null) { return null; }
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.Ticks);
            foreach (var p in filter)
            {
                var k = p.Key;
                var v = p.Value;
                sb.Append("&");
                sb.Append(k);
                sb.Append("=");
                if (v != null)
                {
                    string valStr = ApplicationContext.Current.TypeConverter.ConvertToString(v.GetType(), v);
                    sb.Append(WebUtility.UrlEncode(valStr));
                }

            }
            return sb.ToString();
        }

        public static string GetReturnedFieldsQueryValueString(IList<string> fields, string separator)
        {
            if (fields == null) { return null; }
            StringBuilder sb = new StringBuilder();
            foreach (var f in fields)
            {
                sb.Append(WebUtility.UrlEncode(f));
                sb.Append(separator);
            }
            return sb.ToString();
        }

        public static string GetOrdersQueryValueString(IList<string> orders)
        {
            if (orders == null) { return null; }
            StringBuilder sb = new StringBuilder();
            foreach (var ord in orders)
            {
                sb.Append(WebUtility.UrlEncode(ord));
                sb.Append(",");
            }
            return sb.ToString();
        }

        public static void ThrowOnHttpResponseError(ApiResponse resp)
        {
            var httpResponseMessage = new HttpResponseMessage()
            {
                StatusCode = resp.StatusCode,
                Content = resp.RawContent,
                ReasonPhrase = resp.ReasonPhrase
            };
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return;
            }
            try
            {
                if (resp.StatusCode == HttpStatusCode.InternalServerError)
                {
                    IEnumerable<string> headerValues = new List<string>();
                    if (resp.RawContent != null && resp.RawContent.Headers != null)
                        resp.RawContent.Headers.TryGetValues("Content-Type", out headerValues);
                    if (headerValues.Any(hv => hv.ToLowerInvariant().Contains("json")))
                    {
                        JObject jObj = JObject.Parse(httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                        var errorName = jObj.GetValue("ErrorName").ToObject<string>();
                        var errorMessage = jObj.GetValue("ErrorMessage").ToObject<string>();
                        throw DomainError.Named(errorName, errorMessage);
                    }
                }
                throw new HttpResponseException(httpResponseMessage);
            }
            catch
            {
                throw new HttpResponseException(httpResponseMessage);
            }
        }

        public static IEnumerable<InOutLineId> ToIdCollection(IEnumerable<IInOutLineMvoState> states)
        {
            var ids = new List<InOutLineId>();
            foreach (var s in states)
            {
                ids.Add(s.InOutLineId);
            }
            return ids;
        }

    }

}

