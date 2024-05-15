namespace MyTestFramework;
using RestSharp;
using NUnit.Framework;

    [TestFixture]
    public class APITests
    {
        public RestClient client;

        [SetUp]
        public void SetUp()
        {

            string URI = "https://swapi.dev/";
            // Initialize the RestClient with your API base URL
            client = new RestClient(URI);
        }

        [Test]
        public void StatusCodeTest()
        {
            // Arrange
            var request = new RestRequest("", Method.Get);

            // Act
            RestResponse response = client.Execute(request);

            // Assert
            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
        }

        [Test]
        public void ContentTypeTest()
        {
            // Arrange
            var request = new RestRequest("/people", Method.Get);

            // Act
            RestResponse response = client.Execute(request);

            // Assert
            Assert.That(response.ContentType, Is.EqualTo("text/html"));
        }
        
    }
