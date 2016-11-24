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
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.HttpServices.ClientProxies.Raml;
using Dddml.Wms.HttpServices.ClientProxies.Raml.Models;
using System.Text;
using System.ComponentModel;
using RAML.Api.Core;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;
using Dddml.Wms.Specialization.HttpServices.ClientProxies;


namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class UserLoginMvoApplicationServiceProxy : IUserLoginMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public UserLoginMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public UserLoginMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public UserLoginMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateUserLoginMvoDto c)
        {
            var idObj = UserLoginMvoProxyUtils.ToIdString((c as ICreateUserLoginMvo).UserLoginId);
            var uriParameters = new UserLoginMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new UserLoginMvoPutRequest(uriParameters, (CreateUserLoginMvoDto)c);
                
            var resp = await _ramlClient.UserLoginMvo.Put(req);
            UserLoginMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateUserLoginMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchUserLoginMvoDto c)
        {
            var idObj = UserLoginMvoProxyUtils.ToIdString((c as IMergePatchUserLoginMvo).UserLoginId);
            var uriParameters = new UserLoginMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new UserLoginMvoPatchRequest(uriParameters, (MergePatchUserLoginMvoDto)c);
            var resp = await _ramlClient.UserLoginMvo.Patch(req);
            UserLoginMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchUserLoginMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteUserLoginMvoDto c)
        {
            var idObj = UserLoginMvoProxyUtils.ToIdString((c as IDeleteUserLoginMvo).UserLoginId);
            var uriParameters = new UserLoginMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new UserLoginMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.UserVersion);
                
            var req = new UserLoginMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.UserLoginMvo.Delete(req);
            UserLoginMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteUserLoginMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IUserLoginMvoApplicationService.When(ICreateUserLoginMvo c)
        {
            this.When((CreateUserLoginMvoDto)c);
        }

        void IUserLoginMvoApplicationService.When(IMergePatchUserLoginMvo c)
        {
            this.When((MergePatchUserLoginMvoDto)c);
        }

        void IUserLoginMvoApplicationService.When(IDeleteUserLoginMvo c)
        {
            this.When((DeleteUserLoginMvoDto)c);
        }

        public async Task<IUserLoginMvoState> GetAsync(UserLoginId userLoginId)
        {
            IUserLoginMvoState state = null;
            var idObj = UserLoginMvoProxyUtils.ToIdString(userLoginId);
            var uriParameters = new UserLoginMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new UserLoginMvoGetRequest(uriParameters);

            var resp = await _ramlClient.UserLoginMvo.Get(req);
            UserLoginMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IUserLoginMvoState Get(UserLoginId userLoginId)
        {
            return GetAsync(userLoginId).GetAwaiter().GetResult();
        }


        public IEnumerable<IUserLoginMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IUserLoginMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IUserLoginMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IUserLoginMvoState> states = null;
			var q = new UserLoginMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = UserLoginMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = UserLoginMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = UserLoginMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new UserLoginMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UserLoginMvos.Get(req);
            UserLoginMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IUserLoginMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IUserLoginMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IUserLoginMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IUserLoginMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IUserLoginMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IUserLoginMvoState> states = null;
			var q = new UserLoginMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = UserLoginMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = UserLoginMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = UserLoginMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new UserLoginMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UserLoginMvos.Get(req);
            UserLoginMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IUserLoginMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new UserLoginMvosCountGetQuery();
            q.FilterTag = UserLoginMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new UserLoginMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UserLoginMvosCount.Get(req);
            UserLoginMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async virtual Task<long> GetCountAsync(ICriterion filter)
		{
			var q = new UserLoginMvosCountGetQuery();
            q.Filter = UserLoginMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new UserLoginMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UserLoginMvosCount.Get(req);
            UserLoginMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IUserLoginMvoStateEvent> GetStateEventAsync(UserLoginId userLoginId, long version)
        {
            var idObj = UserLoginMvoProxyUtils.ToIdString(userLoginId);
            var uriParameters = new UserLoginMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new UserLoginMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.UserLoginMvoStateEvent.Get(req);
            UserLoginMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IUserLoginMvoStateEvent GetStateEvent(UserLoginId userLoginId, long version)
        {
            return GetStateEventAsync(userLoginId, version).GetAwaiter().GetResult();
        }


        public async Task<IUserLoginMvoState> GetHistoryStateAsync(UserLoginId userLoginId, long version)
        {
            var idObj = UserLoginMvoProxyUtils.ToIdString(userLoginId);
            var uriParameters = new UserLoginMvoHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new UserLoginMvoHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.UserLoginMvoHistoryState.Get(req);
            UserLoginMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public virtual IUserLoginMvoState GetHistoryState(UserLoginId userLoginId, long version)
        {
            return GetHistoryStateAsync(userLoginId, version).GetAwaiter().GetResult();
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


    public partial class UserLoginMvoApplicationServiceProxyFactory : ProxyFactoryBase, IUserLoginMvoApplicationServiceFactory
    {

        public UserLoginMvoApplicationServiceProxyFactory() : base()
        {}

        public UserLoginMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IUserLoginMvoApplicationService UserLoginMvoApplicationService
        {
            get
            {
                return new UserLoginMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateUserLoginMvo NewCreateUserLoginMvo()
        {
            return new CreateUserLoginMvoDto();
        }

        public IMergePatchUserLoginMvo NewMergePatchUserLoginMvo()
        {
            return new MergePatchUserLoginMvoDto();
        }

        public IDeleteUserLoginMvo NewDeleteUserLoginMvo()
        {
            return new DeleteUserLoginMvoDto();
        }
    }

    public static class UserLoginMvoProxyUtils
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
                var list = new List<string>();
                foreach (var o in values)
                {
                    list.Add(ConvertToString(o));
                }
                return list.ToArray();
            }
        }

        public static string ToIdString(UserLoginId id)
        {
            var formatter = new UserLoginIdFlattenedDtoFormatter();
            var idDto = new UserLoginIdFlattenedDto(id);
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

        public static IEnumerable<UserLoginId> ToIdCollection(IEnumerable<IUserLoginMvoState> states)
        {
            var ids = new List<UserLoginId>();
            foreach (var s in states)
            {
                ids.Add(s.UserLoginId);
            }
            return ids;
        }

    }

}

