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

    public partial class UserRoleMvoApplicationServiceProxy : IUserRoleMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public UserRoleMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public UserRoleMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public UserRoleMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateUserRoleMvoDto c)
        {
            var idObj = UserRoleMvoProxyUtils.ToIdString((c as ICreateUserRoleMvo).UserRoleId);
            var uriParameters = new UserRoleMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new UserRoleMvoPutRequest(uriParameters, (CreateUserRoleMvoDto)c);
                
            var resp = await _ramlClient.UserRoleMvo.Put(req);
            UserRoleMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateUserRoleMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchUserRoleMvoDto c)
        {
            var idObj = UserRoleMvoProxyUtils.ToIdString((c as IMergePatchUserRoleMvo).UserRoleId);
            var uriParameters = new UserRoleMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new UserRoleMvoPatchRequest(uriParameters, (MergePatchUserRoleMvoDto)c);
            var resp = await _ramlClient.UserRoleMvo.Patch(req);
            UserRoleMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchUserRoleMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteUserRoleMvoDto c)
        {
            var idObj = UserRoleMvoProxyUtils.ToIdString((c as IDeleteUserRoleMvo).UserRoleId);
            var uriParameters = new UserRoleMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new UserRoleMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.UserVersion);
                
            var req = new UserRoleMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.UserRoleMvo.Delete(req);
            UserRoleMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteUserRoleMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IUserRoleMvoApplicationService.When(ICreateUserRoleMvo c)
        {
            this.When((CreateUserRoleMvoDto)c);
        }

        void IUserRoleMvoApplicationService.When(IMergePatchUserRoleMvo c)
        {
            this.When((MergePatchUserRoleMvoDto)c);
        }

        void IUserRoleMvoApplicationService.When(IDeleteUserRoleMvo c)
        {
            this.When((DeleteUserRoleMvoDto)c);
        }

        public async Task<IUserRoleMvoState> GetAsync(UserRoleId userRoleId)
        {
            IUserRoleMvoState state = null;
            var idObj = UserRoleMvoProxyUtils.ToIdString(userRoleId);
            var uriParameters = new UserRoleMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new UserRoleMvoGetRequest(uriParameters);

            var resp = await _ramlClient.UserRoleMvo.Get(req);
            UserRoleMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IUserRoleMvoState Get(UserRoleId userRoleId)
        {
            return GetAsync(userRoleId).GetAwaiter().GetResult();
        }


        public IEnumerable<IUserRoleMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IUserRoleMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IUserRoleMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IUserRoleMvoState> states = null;
			var q = new UserRoleMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = UserRoleMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = UserRoleMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = UserRoleMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new UserRoleMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UserRoleMvos.Get(req);
            UserRoleMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IUserRoleMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IUserRoleMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IUserRoleMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IUserRoleMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IUserRoleMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IUserRoleMvoState> states = null;
			var q = new UserRoleMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = UserRoleMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = UserRoleMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = UserRoleMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new UserRoleMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UserRoleMvos.Get(req);
            UserRoleMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IUserRoleMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new UserRoleMvosCountGetQuery();
            q.FilterTag = UserRoleMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new UserRoleMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UserRoleMvosCount.Get(req);
            UserRoleMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async virtual Task<long> GetCountAsync(ICriterion filter)
		{
			var q = new UserRoleMvosCountGetQuery();
            q.Filter = UserRoleMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new UserRoleMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UserRoleMvosCount.Get(req);
            UserRoleMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IUserRoleMvoStateEvent> GetStateEventAsync(UserRoleId userRoleId, long version)
        {
            var idObj = UserRoleMvoProxyUtils.ToIdString(userRoleId);
            var uriParameters = new UserRoleMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new UserRoleMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.UserRoleMvoStateEvent.Get(req);
            UserRoleMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IUserRoleMvoStateEvent GetStateEvent(UserRoleId userRoleId, long version)
        {
            return GetStateEventAsync(userRoleId, version).GetAwaiter().GetResult();
        }


        public async Task<IUserRoleMvoState> GetHistoryStateAsync(UserRoleId userRoleId, long version)
        {
            var idObj = UserRoleMvoProxyUtils.ToIdString(userRoleId);
            var uriParameters = new UserRoleMvoHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new UserRoleMvoHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.UserRoleMvoHistoryState.Get(req);
            UserRoleMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public virtual IUserRoleMvoState GetHistoryState(UserRoleId userRoleId, long version)
        {
            return GetHistoryStateAsync(userRoleId, version).GetAwaiter().GetResult();
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


    public partial class UserRoleMvoApplicationServiceProxyFactory : ProxyFactoryBase, IUserRoleMvoApplicationServiceFactory
    {

        public UserRoleMvoApplicationServiceProxyFactory() : base()
        {}

        public UserRoleMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IUserRoleMvoApplicationService UserRoleMvoApplicationService
        {
            get
            {
                return new UserRoleMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateUserRoleMvo NewCreateUserRoleMvo()
        {
            return new CreateUserRoleMvoDto();
        }

        public IMergePatchUserRoleMvo NewMergePatchUserRoleMvo()
        {
            return new MergePatchUserRoleMvoDto();
        }

        public IDeleteUserRoleMvo NewDeleteUserRoleMvo()
        {
            return new DeleteUserRoleMvoDto();
        }
    }

    public static class UserRoleMvoProxyUtils
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

        public static string ToIdString(UserRoleId id)
        {
            var formatter = new UserRoleIdFlattenedDtoFormatter();
            var idDto = new UserRoleIdFlattenedDto(id);
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

        public static IEnumerable<UserRoleId> ToIdCollection(IEnumerable<IUserRoleMvoState> states)
        {
            var ids = new List<UserRoleId>();
            foreach (var s in states)
            {
                ids.Add(s.UserRoleId);
            }
            return ids;
        }

    }

}

