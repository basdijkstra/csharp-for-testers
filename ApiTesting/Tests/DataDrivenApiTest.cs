using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace ApiTesting.Tests
{
    [TestFixture]
    public class DataDrivenApiTest
    {
        // Refactor de onderstaande drie tests naar een data driven test
        // Gebruik ter inspiratie het voorbeeld onderaan
        // Kijk goed naar wat je kunt hergebruiken

        [Test]
        public void BodyTest()
        {
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("nl/7411", Method.GET);

            IRestResponse response = client.Execute(request);

            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);

            Assert.That((string)jsonResponse.country, Is.EqualTo("Netherlands"));
        }

        [Test]
        public void AnotherBodyTest()
        {
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("us/90210", Method.GET);

            IRestResponse response = client.Execute(request);

            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);

            Assert.That((string)jsonResponse.country, Is.EqualTo("United States"));
        }

        [Test]
        public void YetAnotherBodyTest()
        {
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("it/50123", Method.GET);

            IRestResponse response = client.Execute(request);

            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);

            Assert.That((string)jsonResponse.country, Is.EqualTo("Italy"));
        }

        [TestCase("nl", "7411", HttpStatusCode.OK, TestName = "Check status code for NL zip code 7411")]
        [TestCase("lv", "1050", HttpStatusCode.NotFound, TestName = "Check status code for LV zip code 1050")]
        public void StatusCodeTest(string countryCode, string zipCode, HttpStatusCode expectedHttpStatusCode)
        {
            // arrange
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("{countryCode}/{zipCode}", Method.GET);
            request.AddUrlSegment("countryCode", countryCode);
            request.AddUrlSegment("zipCode", zipCode);

            // act
            IRestResponse response = client.Execute(request);

            // assert
            Assert.That(response.StatusCode, Is.EqualTo(expectedHttpStatusCode));
        }
    }
}
