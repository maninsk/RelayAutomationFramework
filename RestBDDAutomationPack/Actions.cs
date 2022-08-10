using RestSharp;
using RestBDDAutomationPack.Helper;
using RestBDDAutomationPack.Models;

namespace RestBDDAutomationPack
{
    public class Actions
    {
        private RestBDDAutomationPack.Helper.Helper helper;
        private string  baseurl = "https://relay-candidate.proxy.beeceptor.com/";
        private string getEndPoint = "report/v1/payouts";

        public Actions()
        {
            helper = new RestBDDAutomationPack.Helper.Helper();
        }

                   
            public Payouts GetPayouts()
            {
                var client = helper.SetUrl(baseurl+ getEndPoint);
                var request = helper.CreateGetRequest();
                request.RequestFormat = DataFormat.Json;
                var response = helper.GetResponse(client, request);
                var payouts = HandleContent.GetContent<Payouts>(response);


                return payouts;
            }

        public Payouts CreateRequest(string payload)
        {
            var client = helper.SetUrl("https://relay-candidate.proxy.beeceptor.com/");
            var request = helper.CreatePostRequest(payload);
            var response = helper.GetResponse(client, request);
            var createPayout = HandleContent.GetContent<Payouts>(response);


            return createPayout;
        }

        public Payouts CreatePutRequest(string payload)
        {
            var client = helper.SetUrl("");
            var request = helper.CreatePostRequest(payload);
            var response = helper.GetResponse(client, request);
            var createPayout = HandleContent.GetContent<Payouts>(response);


            return createPayout;
        }

        public RestResponse DeleteRequest(string payload)
        {
            var client = helper.SetUrl("");
            var request = helper.CreatePostRequest(payload);
            var response = helper.GetResponse(client, request);
            
            return response;
        }
    }
}

