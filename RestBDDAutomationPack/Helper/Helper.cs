using Newtonsoft.Json.Linq;
using RestSharp;
using System;
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
        public  string GetProjectRootDirectory()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
           
            return currentDirectory.Split("bin")[0];
        }
        private  JObject GetTestDataJsonObject()
        {
            string path = Path.Combine(GetProjectRootDirectory().Replace("\\TestExecution", ""), "RestBDDAutomationPack\\TestData", "ExpextedData.json");
            JObject jObject = JObject.Parse(File.ReadAllText(path));
            return jObject;
        }
        public  int GetTestDataInt(string label)
        {
            var jObject = GetTestDataJsonObject();
            return Int32.Parse(jObject[label].ToString());
        }

        public string GetTestDataString(string label)
        {
            var jObject = GetTestDataJsonObject();
            return jObject[label].ToString();
        }
    }
}
