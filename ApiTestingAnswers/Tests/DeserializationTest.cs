using ApiTestingAnswers.DataTypes;
using NUnit.Framework;
using RestSharp;
using RestSharp.Deserializers;

namespace ApiTestingAnswers.Tests
{
    [TestFixture]
    public class DeserializationTest
    {
        [Test]
        public void CountryAbbreviationSerializationTest()
        {
            // arrange
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("us/90210", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            LocationResponse locationResponse =
                new JsonDeserializer().
                Deserialize<LocationResponse>(response);

            // assert
            Assert.That(locationResponse.CountryAbbreviation, Is.EqualTo("US"));
        }

        [Test]
        public void StateSerializationTest()
        {
            // arrange
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("us/12345", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            LocationResponse locationResponse =
                new JsonDeserializer().
                Deserialize<LocationResponse>(response);

            // assert
            Assert.That(
                locationResponse.Places[0].State,
                Is.EqualTo("New York")
            );
        }

        [Test]
        public void PlaceNameSerializationTest()
        {
            // arrange
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("us/90210", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            LocationResponse locationResponse =
                new JsonDeserializer().
                Deserialize<LocationResponse>(response);

            // assert
            Assert.That(
                locationResponse.Places[0].PlaceName,
                Is.EqualTo("Beverly Hills")
            );
        }

        [Test]
        public void ExampleDeserializationTest()
        {
            // arrange
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("nl/7411", Method.GET);

            // act
            IRestResponse response = client.Execute(request);
            
            LocationResponse locationResponse = 
                new JsonDeserializer().
                Deserialize<LocationResponse>(response);

            // assert
            Assert.That(locationResponse.Country, Is.EqualTo("Netherlands"));
        }
    }
}
