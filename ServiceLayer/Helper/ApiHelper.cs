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
        private readonly string _token = "aa494962b9daba5fbccbc8746c4b67aeb217febcc0cc3e2c46e96f30fd267432";

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
