using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace ApiTestingAnswers.Tests
{
    [TestFixture]
    public class DataDrivenApiTest
    {
        [TestCase("nl", "7411", HttpStatusCode.OK)]
        [TestCase("lv", "1050", HttpStatusCode.NotFound)]
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

        [TestCase("nl", "7411", "Netherlands")]
        [TestCase("us", "90210", "United States")]
        [TestCase("it", "50123", "Italy")]
        public void CountryTest(string countryCode, string zipCode, string expectedCountry)
        {
            // arrange
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("{countryCode}/{zipCode}", Method.GET);
            request.AddUrlSegment("countryCode", countryCode);
            request.AddUrlSegment("zipCode", zipCode);

            // act
            IRestResponse response = client.Execute(request);

            // assert
            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);

            Assert.That((string)jsonResponse.country, Is.EqualTo(expectedCountry));
        }
    }
}
