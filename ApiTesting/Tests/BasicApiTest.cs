using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace ApiTesting.Tests
{
    [TestFixture]
    public class BasicApiTest
    {
        [Test]
        public void StatusCodeTest()
        {
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("nl/7411", Method.GET);
            
            IRestResponse response = client.Execute(request);

            // Voeg een constraint model assertion toe om de statuscode (OK) te checken
            
        }

        [Test]
        public void AnotherStatusCodeTest()
        {
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("lv/1050", Method.GET);

            IRestResponse response = client.Execute(request);

            // Voeg een constraint model assertion toe om de statuscode (NotFound) te checken

        }

        [Test]
        public void ContentTypeTest()
        {
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("nl/7411", Method.GET);

            IRestResponse response = client.Execute(request);

            // Voeg een constraint model assertion toe om de ContentType ("application/json") te checken
        }

        [Test]
        public void BodyTest()
        {
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("nl/7411", Method.GET);

            IRestResponse response = client.Execute(request);

            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);

            // Voeg een constraint model assertion toe om de waarde van het veld
            // country te checken ("Netherlands")
        }
    }
}
