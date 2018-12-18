using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace ApiTestingAnswers.Tests
{
    [TestFixture]
    public class BasicApiTest
    {
        [Test]
        public void StatusCodeTest()
        {
            // arrange
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("nl/7411", Method.GET);
            
            // act
            IRestResponse response = client.Execute(request);

            // assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void AnotherStatusCodeTest()
        {
            // arrange
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("lv/1050", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            // assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
        }

        [Test]
        public void ContentTypeTest()
        {
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("nl/7411", Method.GET);

            IRestResponse response = client.Execute(request);

            Assert.That(response.ContentType, Is.EqualTo("application/json"));
        }

        [Test]
        public void BodyTest()
        {
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("nl/7411", Method.GET);

            IRestResponse response = client.Execute(request);

            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            
            Assert.That((string)jsonResponse.country, Is.EqualTo("Netherlands"));
        }
    }
}
