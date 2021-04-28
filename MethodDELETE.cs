using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITask
{
    public static class MethodDELETE
    {
        public static string MethodDelete()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("posts/20", Method.DELETE);
            IRestResponse response = client.Execute(request);
            string content = response.Content;
            return content;
        }
    }
}
