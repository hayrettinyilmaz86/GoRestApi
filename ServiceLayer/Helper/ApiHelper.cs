using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ServiceLayer.Helper
{
    public class ApiHelper
    {
        public HttpClient _client { get; set; }

        private readonly string _baseUri = "https://gorest.co.in/public-api/";
        private readonly string _token = "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56";

        //private readonly string baseUri = ConfigurationManager.AppSettings["apiBaseUri"];
        //private readonly string token = ConfigurationManager.AppSettings["apiToken"];

        public ApiHelper()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(_baseUri)
            };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");
        }
    }
}
