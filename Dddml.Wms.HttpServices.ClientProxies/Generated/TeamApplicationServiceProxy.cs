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

    public partial class TeamApplicationServiceProxy : ITeamApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public TeamApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public TeamApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public TeamApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateTeamDto c)
        {
            var idObj = (c as ICreateTeam).TeamName;
            var uriParameters = new TeamUriParameters();
            uriParameters.Id = idObj;

            var req = new TeamPutRequest(uriParameters, (CreateTeamDto)c);
                
            var resp = await _ramlClient.Team.Put(req);
            TeamProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateTeamDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchTeamDto c)
        {
            var idObj = (c as IMergePatchTeam).TeamName;
            var uriParameters = new TeamUriParameters();
            uriParameters.Id = idObj;

            var req = new TeamPatchRequest(uriParameters, (MergePatchTeamDto)c);
            var resp = await _ramlClient.Team.Patch(req);
            TeamProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchTeamDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteTeamDto c)
        {
            var idObj = (c as IDeleteTeam).TeamName;
            var uriParameters = new TeamUriParameters();
            uriParameters.Id = idObj;

            var q = new TeamDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new TeamDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.Team.Delete(req);
            TeamProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteTeamDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void ITeamApplicationService.When(ICreateTeam c)
        {
            this.When((CreateTeamDto)c);
        }

        void ITeamApplicationService.When(IMergePatchTeam c)
        {
            this.When((MergePatchTeamDto)c);
        }

        void ITeamApplicationService.When(IDeleteTeam c)
        {
            this.When((DeleteTeamDto)c);
        }

        public async Task<ITeamState> GetAsync(string teamName)
        {
            ITeamState state = null;
            var idObj = teamName;
            var uriParameters = new TeamUriParameters();
            uriParameters.Id = idObj;

            var req = new TeamGetRequest(uriParameters);

            var resp = await _ramlClient.Team.Get(req);
            TeamProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public ITeamState Get(string teamName)
        {
            return GetAsync(teamName).GetAwaiter().GetResult();
        }


        public IEnumerable<ITeamState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<ITeamState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<ITeamState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<ITeamState> states = null;
			var q = new TeamsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = TeamProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = TeamProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = TeamProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new TeamsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Teams.Get(req);
            TeamProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<ITeamState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<ITeamState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<ITeamState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<ITeamState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<ITeamState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<ITeamState> states = null;
			var q = new TeamsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = TeamProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = TeamProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = TeamProxyUtils.GetFilterQueryValueString(filter);
            var req = new TeamsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Teams.Get(req);
            TeamProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<ITeamState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new TeamsCountGetQuery();
            q.FilterTag = TeamProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new TeamsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.TeamsCount.Get(req);
            TeamProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async virtual Task<long> GetCountAsync(ICriterion filter)
		{
			var q = new TeamsCountGetQuery();
            q.Filter = TeamProxyUtils.GetFilterQueryValueString(filter);
            var req = new TeamsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.TeamsCount.Get(req);
            TeamProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<ITeamStateEvent> GetStateEventAsync(string teamName, long version)
        {
            var idObj = teamName;
            var uriParameters = new TeamStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new TeamStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.TeamStateEvent.Get(req);
            TeamProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public ITeamStateEvent GetStateEvent(string teamName, long version)
        {
            return GetStateEventAsync(teamName, version).GetAwaiter().GetResult();
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


    public partial class TeamApplicationServiceProxyFactory : ProxyFactoryBase, ITeamApplicationServiceFactory
    {

        public TeamApplicationServiceProxyFactory() : base()
        {}

        public TeamApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public ITeamApplicationService TeamApplicationService
        {
            get
            {
                return new TeamApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateTeam NewCreateTeam()
        {
            return new CreateTeamDto();
        }

        public IMergePatchTeam NewMergePatchTeam()
        {
            return new MergePatchTeamDto();
        }

        public IDeleteTeam NewDeleteTeam()
        {
            return new DeleteTeamDto();
        }
    }

    public static class TeamProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<ITeamState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.TeamName);
            }
            return ids;
        }

    }

}
