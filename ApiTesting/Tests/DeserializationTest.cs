using ApiTesting.DataTypes;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Deserializers;
using System.Net;
using System.Linq;

namespace ApiTesting.Tests
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

            // Deserialiseer het JSON-antwoord van de API
            // naar een POCO van het type LocationResponse

            // Schrijf een assertion die checkt of de waarde van het
            // veld CountryAbbreviation gelijk is aan 'US'
        }

        [Test]
        public void StateSerializationTest()
        {
            // arrange
            var client = new RestClient("http://api.zippopotam.us");
            var request = new RestRequest("us/12345", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            // Deserialiseer het JSON-antwoord van de API
            // naar een POCO van het type LocationResponse

            // Schrijf een assertion die checkt of de waarde van het
            // veld State van de eerste Place in de lijst
            // gelijk is aan 'New York'
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
                locationResponse.Places.ElementAt<Place>(0).PlaceName,
                Is.EqualTo("Beverly Hills")
            );
        }
    }
}
