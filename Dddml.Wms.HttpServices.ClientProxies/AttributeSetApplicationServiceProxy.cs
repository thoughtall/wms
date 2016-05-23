﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
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
using Dddml.Wms.HttpServices.ClientProxies.Raml;
using Dddml.Wms.HttpServices.ClientProxies.Raml.Models;
using System.Text;
using System.ComponentModel;
using RAML.Api.Core;
using Newtonsoft.Json.Linq;


namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class AttributeSetApplicationServiceProxy : IAttributeSetApplicationService
    {


        private DddmlWmsRamlClient _ramlClient;

        public AttributeSetApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public AttributeSetApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public void When(CreateAttributeSetDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as ICreateAttributeSet).AttributeSetId);
            var uriParameters = new AttributeSetUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetPutRequest(uriParameters, (CreateAttributeSetDto)c);
                
            var resp = _ramlClient.AttributeSet.Put(req).GetAwaiter().GetResult();
            ThrowOnHttpResponseError(resp);
            //};
            //act();
        }

        public void When(MergePatchAttributeSetDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as IMergePatchAttributeSet).AttributeSetId);
            var uriParameters = new AttributeSetUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetPatchRequest(uriParameters, (MergePatchAttributeSetDto)c);
            var resp = _ramlClient.AttributeSet.Patch(req).GetAwaiter().GetResult();
            ThrowOnHttpResponseError(resp);
            //};
            //act();
        }

        public void When(DeleteAttributeSetDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as IDeleteAttributeSet).AttributeSetId);
            var uriParameters = new AttributeSetUriParameters();
            uriParameters.Id = idObj;

            var q = new AttributeSetDeleteQuery();
            q.CommandId = c.CommandId;
                
            var req = new AttributeSetDeleteRequest(uriParameters);
            req.Query = q;

            var resp = _ramlClient.AttributeSet.Delete(req).GetAwaiter().GetResult();
            ThrowOnHttpResponseError(resp);
            //};
            //act();
        }
		
        void IAttributeSetApplicationService.When(ICreateAttributeSet c)
        {
            this.When((CreateAttributeSetDto)c);
        }

        void IAttributeSetApplicationService.When(IMergePatchAttributeSet c)
        {
            this.When((MergePatchAttributeSetDto)c);
        }

        void IAttributeSetApplicationService.When(IDeleteAttributeSet c)
        {
            this.When((DeleteAttributeSetDto)c);
        }

        public IAttributeSetState Get(string attributeSetId)
        {
            IAttributeSetState state = null;
            //Action act = async () =>
            //{
            var idObj = (attributeSetId);
            var uriParameters = new AttributeSetUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetGetRequest(uriParameters);

            var resp = _ramlClient.AttributeSet.Get(req).GetAwaiter().GetResult();
            ThrowOnHttpResponseError(resp);
            state = resp.Content;
            //};
            //act();
            return state;
        }

        public IEnumerable<IAttributeSetState> GetAll(int firstResult, int maxResults)
        {
            return Get(null, null, firstResult, maxResults);
        }

        public IEnumerable<IAttributeSetState> Get(IDictionary<string, object> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IAttributeSetState> Get(IDictionary<string, object> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeSetState> states = null;
            //Action act = async () =>
            //{
			var q = new AttributeSetsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = GetOrdersQueryValueString(orders);
            q.Fields = GetReturnedFieldsQueryValueString(fields);
            q.FilterTag = GetFilterTagQueryValueString(filter);
            var req = new AttributeSetsGetRequest();
            req.Query = q;
            var resp = _ramlClient.AttributeSets.Get(req).GetAwaiter().GetResult();
            ThrowOnHttpResponseError(resp);
            states = resp.Content;
            //};
            //act();
            return states;
        }


        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IAttributeSetStateEvent GetStateEvent(string aggregateId, long version)
        {
            throw new NotImplementedException(); // TODO
        }


        protected virtual string GetFilterTagQueryValueString(IDictionary<string, object> filter)
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
                    var converter = TypeDescriptor.GetConverter(v.GetType());
                    string valStr = converter.ConvertToString(v);
                    sb.Append(WebUtility.UrlEncode(valStr));
                }

            }
            return sb.ToString();
        }

        protected virtual string GetReturnedFieldsQueryValueString(IList<string> fields)
        {
            if (fields == null) { return null; }
            StringBuilder sb = new StringBuilder();
            foreach (var f in fields)
            {
                sb.Append(WebUtility.UrlEncode(f));
                sb.Append(QueryFieldValueSeparator);
            }
            return sb.ToString();
        }

        protected virtual string GetOrdersQueryValueString(IList<string> orders)
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


        protected virtual string QueryFieldValueSeparator
        {
            get { return ","; }
        }

        protected virtual string QueryOrderSeparator
        {
            get { return ","; }
        }

        protected virtual void ThrowOnHttpResponseError(ApiResponse resp)
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

    }


    public partial class AttributeSetApplicationServiceProxyFactory : IAttributeSetApplicationServiceFactory
    {

        private string _endpointUrl;

        public AttributeSetApplicationServiceProxyFactory(string endpointUrl)
        {
            this._endpointUrl = endpointUrl;
        }

        public IAttributeSetApplicationService AttributeSetApplicationService
        {
            get
            {
                return new AttributeSetApplicationServiceProxy(_endpointUrl);
            }
        }

        public ICreateAttributeSet NewCreateAttributeSet()
        {
            return new CreateAttributeSetDto();
        }

        public IMergePatchAttributeSet NewMergePatchAttributeSet()
        {
            return new MergePatchAttributeSetDto();
        }

        public IDeleteAttributeSet NewDeleteAttributeSet()
        {
            return new DeleteAttributeSetDto();
        }
    }


}

