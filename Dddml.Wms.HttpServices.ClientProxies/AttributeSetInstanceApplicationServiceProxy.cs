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


namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class AttributeSetInstanceApplicationServiceProxy : IAttributeSetInstanceApplicationService
    {


        private DddmlWmsRamlClient _ramlClient;

        public AttributeSetInstanceApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public AttributeSetInstanceApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public void When(CreateAttributeSetInstanceDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as ICreateAttributeSetInstance).AttributeSetInstanceId);
            var uriParameters = new AttributeSetInstanceUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstancePutRequest(uriParameters, (CreateAttributeSetInstanceDto)c);
                
            var resp = _ramlClient.AttributeSetInstance.Put(req).GetAwaiter().GetResult();;
            //};
            //act();
        }

        public void When(MergePatchAttributeSetInstanceDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as IMergePatchAttributeSetInstance).AttributeSetInstanceId);
            var uriParameters = new AttributeSetInstanceUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstancePatchRequest(uriParameters, (MergePatchAttributeSetInstanceDto)c);
            var resp = _ramlClient.AttributeSetInstance.Patch(req).GetAwaiter().GetResult();;
            //};
            //act();
        }

        public void When(DeleteAttributeSetInstanceDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as IDeleteAttributeSetInstance).AttributeSetInstanceId);
            var uriParameters = new AttributeSetInstanceUriParameters();
            uriParameters.Id = idObj;

            var q = new AttributeSetInstanceDeleteQuery();
            q.CommandId = c.CommandId;
                
            var req = new AttributeSetInstanceDeleteRequest(uriParameters);
            req.Query = q;

            var resp = _ramlClient.AttributeSetInstance.Delete(req).GetAwaiter().GetResult();;
            //};
            //act();
        }
		
        void IAttributeSetInstanceApplicationService.When(ICreateAttributeSetInstance c)
        {
            this.When((CreateAttributeSetInstanceDto)c);
        }

        void IAttributeSetInstanceApplicationService.When(IMergePatchAttributeSetInstance c)
        {
            this.When((MergePatchAttributeSetInstanceDto)c);
        }

        void IAttributeSetInstanceApplicationService.When(IDeleteAttributeSetInstance c)
        {
            this.When((DeleteAttributeSetInstanceDto)c);
        }

        public IAttributeSetInstanceState Get(string attributeSetInstanceId)
        {
            IAttributeSetInstanceState state = null;
            //Action act = async () =>
            //{
            var idObj = (attributeSetInstanceId);
            var uriParameters = new AttributeSetInstanceUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstanceGetRequest(uriParameters);

            var resp = _ramlClient.AttributeSetInstance.Get(req).GetAwaiter().GetResult();
            state = resp.Content;
            //};
            //act();
            return state;
        }

        public IEnumerable<IAttributeSetInstanceState> GetAll(int firstResult, int maxResults)
        {
            return Get(null, null, firstResult, maxResults);
        }

        public IEnumerable<IAttributeSetInstanceState> Get(IDictionary<string, object> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IAttributeSetInstanceState> Get(IDictionary<string, object> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeSetInstanceState> states = null;
            //Action act = async () =>
            //{
			var q = new AttributeSetInstancesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = GetOrdersQueryValueString(orders);
            q.Fields = GetReturnedFieldsQueryValueString(fields);
            q.FilterTag = GetFilterTagQueryValueString(filter);
            var req = new AttributeSetInstancesGetRequest();
            req.Query = q;
            var resp = _ramlClient.AttributeSetInstances.Get(req).GetAwaiter().GetResult();;
            states = resp.Content;
            //};
            //act();
            return states;
        }


        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
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

    }


    public partial class AttributeSetInstanceApplicationServiceProxyFactory : IAttributeSetInstanceApplicationServiceFactory
    {

        private string _endpointUrl;

        public AttributeSetInstanceApplicationServiceProxyFactory(string endpointUrl)
        {
            this._endpointUrl = endpointUrl;
        }

        public IAttributeSetInstanceApplicationService AttributeSetInstanceApplicationService
        {
            get
            {
                return new AttributeSetInstanceApplicationServiceProxy(_endpointUrl);
            }
        }

        public ICreateAttributeSetInstance NewCreateAttributeSetInstance()
        {
            return new CreateAttributeSetInstanceDto();
        }

        public IMergePatchAttributeSetInstance NewMergePatchAttributeSetInstance()
        {
            return new MergePatchAttributeSetInstanceDto();
        }

        public IDeleteAttributeSetInstance NewDeleteAttributeSetInstance()
        {
            return new DeleteAttributeSetInstanceDto();
        }
    }


}

