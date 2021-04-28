using RestSharp;
using Newtonsoft.Json;
using ConsoleApp1;

namespace APITask
{
    public static class MethodGET
    {
        public static InfoDTO MethodGet()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("posts/20", Method.GET);
            var queryResult = client.Execute<string>(request).Data;
            InfoDTO Parsed = JsonConvert.DeserializeObject<InfoDTO>(queryResult);
            return Parsed;
        }
    }
}
