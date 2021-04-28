using ConsoleApp1;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITask
{
    public static class MethodPOST
    {
        public static InfoDTO MethodPost()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("posts/", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("userId", "42");
            request.AddParameter("id", "101");
            request.AddParameter("title", "Latine");
            request.AddParameter("body", "Amat victoria curam");
            IRestResponse restResponse = client.Execute(request);
            string content = restResponse.Content;
            InfoDTO Parsed = JsonConvert.DeserializeObject<InfoDTO>(content);
            return Parsed;
        }
    }
}
