using ConsoleApp1;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITask
{
    public static class MethodPUT
    {
        public static InfoDTO MethodPut()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("posts/20", Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("userId", "51");
            request.AddParameter("id", "322");
            request.AddParameter("title", "Latine");
            request.AddParameter("body", "Omnia transeunt");
            IRestResponse restResponse = client.Execute(request);
            string content = restResponse.Content;
            Console.WriteLine(content);
            InfoDTO Parsed = JsonConvert.DeserializeObject<InfoDTO>(content);
            return Parsed;
        }
    }
}
