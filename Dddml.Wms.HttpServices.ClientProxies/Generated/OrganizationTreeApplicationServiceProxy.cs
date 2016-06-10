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

    public partial class OrganizationTreeApplicationServiceProxy : IOrganizationTreeApplicationService
    {


        private DddmlWmsRamlClient _ramlClient;

        public OrganizationTreeApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public OrganizationTreeApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public IEnumerable<IOrganizationState> GetRoots(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetRoots(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IOrganizationState> GetRoots(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationState> states = null;
			var q = new OrganizationTreesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = OrganizationProxyUtils.GetFilterQueryValueString(filter);
            var req = new OrganizationTreesGetRequest();
            req.Query = q;
            var resp = _ramlClient.OrganizationTrees.Get(req).GetAwaiter().GetResult();
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IOrganizationState> GetChildren(string parentId, ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetChildren(parentId, filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IOrganizationState> GetChildren(string parentId, ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationState> states = null;
			var q = new OrganizationTreesGetQuery();
            var parentIdObj = (parentId);
			q.ParentId = parentIdObj;
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = OrganizationProxyUtils.GetFilterQueryValueString(filter);
            var req = new OrganizationTreesGetRequest();
            req.Query = q;
            var resp = _ramlClient.OrganizationTrees.Get(req).GetAwaiter().GetResult();
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IOrganizationState> GetRoots(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetRoots(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IOrganizationState> GetRoots(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationState> states = null;
			var q = new OrganizationTreesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = OrganizationProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new OrganizationTreesGetRequest();
            req.Query = q;
            var resp = _ramlClient.OrganizationTrees.Get(req).GetAwaiter().GetResult();
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IOrganizationState> GetChildren(string parentId, IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetChildren(parentId, filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IOrganizationState> GetChildren(string parentId, IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationState> states = null;
			var q = new OrganizationTreesGetQuery();
            var parentIdObj = (parentId);
			q.ParentId = parentIdObj;
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = OrganizationProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new OrganizationTreesGetRequest();
            req.Query = q;
            var resp = _ramlClient.OrganizationTrees.Get(req).GetAwaiter().GetResult();
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<string> GetRootIds(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetRootIds(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<string> GetRootIds(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationState> states = null;
			var q = new OrganizationTreesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = OrganizationProxyUtils.GetFilterQueryValueString(filter);
            var req = new OrganizationTreesGetRequest();
            req.Query = q;
            var resp = _ramlClient.OrganizationTrees.Get(req).GetAwaiter().GetResult();
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return OrganizationProxyUtils.ToIdCollection(states);
        }

        public IEnumerable<string> GetChildIds(string parentId, ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetChildIds(parentId, filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<string> GetChildIds(string parentId, ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationState> states = null;
			var q = new OrganizationTreesGetQuery();
            var parentIdObj = (parentId);
			q.ParentId = parentIdObj;
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = OrganizationProxyUtils.GetFilterQueryValueString(filter);
            var req = new OrganizationTreesGetRequest();
            req.Query = q;
            var resp = _ramlClient.OrganizationTrees.Get(req).GetAwaiter().GetResult();
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return OrganizationProxyUtils.ToIdCollection(states);
        }

        public IEnumerable<string> GetRootIds(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetRootIds(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<string> GetRootIds(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationState> states = null;
			var q = new OrganizationTreesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = OrganizationProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new OrganizationTreesGetRequest();
            req.Query = q;
            var resp = _ramlClient.OrganizationTrees.Get(req).GetAwaiter().GetResult();
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return OrganizationProxyUtils.ToIdCollection(states);
        }

        public IEnumerable<string> GetChildIds(string parentId, IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetChildIds(parentId, filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<string> GetChildIds(string parentId, IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationState> states = null;
			var q = new OrganizationTreesGetQuery();
            var parentIdObj = (parentId);
			q.ParentId = parentIdObj;
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = OrganizationProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new OrganizationTreesGetRequest();
            req.Query = q;
            var resp = _ramlClient.OrganizationTrees.Get(req).GetAwaiter().GetResult();
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return OrganizationProxyUtils.ToIdCollection(states);
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

    public partial class OrganizationTreeApplicationServiceProxyFactory : IOrganizationTreeApplicationServiceFactory
    {

        private string _endpointUrl;

        public OrganizationTreeApplicationServiceProxyFactory(string endpointUrl)
        {
            this._endpointUrl = endpointUrl;
        }

        public IOrganizationTreeApplicationService OrganizationTreeApplicationService
        {
            get
            {
                return new OrganizationTreeApplicationServiceProxy(_endpointUrl);
            }
        }
    }

}

