using Newtonsoft.Json;
using RestSharp;
using System.IO;

namespace RestBDDAutomationPack.Helper
{
    public class Helper
    {
        private RestClient client;
        private RestRequest request;
        private const string baseUrl = "";

        public RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(baseUrl,endpoint);
            var client = new RestClient(url);
            return client;
        }

        public RestRequest CreateGetRequest()
        {
            request = new RestRequest("",Method.Get);
            request.AddHeader("Accept", "application/json");
            return request;
        }

        public RestResponse GetResponse(RestClient restClient, RestRequest restRequest)
        {
            return restClient.Execute(restRequest);
        }

        public RestRequest CreatePostRequest(string payload)
        {
            request = new RestRequest("", Method.Post);
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json",payload,ParameterType.RequestBody);
            return request;
        }

        public RestRequest CreatePutRequest(string payload)
        {
            request = new RestRequest("", Method.Put);
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", payload, ParameterType.RequestBody);
            return request;
        }

        public RestRequest CreateDeleteRequest()
        {
            request = new RestRequest("", Method.Delete);
            request.AddHeader("Accept", "application/json");
           
            return request;
        }

    }
}
