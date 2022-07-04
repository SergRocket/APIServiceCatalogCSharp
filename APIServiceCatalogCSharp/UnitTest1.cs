
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharp.Deserializers;

namespace APIServiceCatalogCSharp
{
    [TestFixture]
    public class UnitTest1
    {
        

        [Test]
        public void TestMethodProductData()
        {
            var client = new RestClient("https://api2.beta.shutterfly.com");
            var request = new RestRequest("/pipdata/v1/product/{productId}", Method.GET);
            request.AddUrlSegment("productId", 1431302);
            var response = client.Execute(request);
            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            dynamic jsonObject = jsonResponse.ResponseObjects.OptionsMap;
            dynamic api = JObject.Parse(jsonObject);
            var okk = api.OptionsMap.Metadata.title;
        }

        [Test]
        public void TestMethodProductPipOptions()
        {
            var client = new RestClient("https://api2.beta.shutterfly.com");
            var request = new RestRequest("/v1/search/{q}&{sid}", Method.POST);
            request.AddUrlSegment("q", "test");
            request.AddUrlSegment("sid", "1234");
            request.AddHeader("SFLY-apikey", "vHAx0uG8Ndr6WJf2vu697D4HnPHu5WfG");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new { fl = "url,title",
            url = "https://www.shutterfly.com/sitesearch/enjoy+cotton+tote",
            refurl = "enjoy%20cotton%20tote%26"});
            var deserialize = new JsonDeserializer();
            var response = client.Execute(request);
            var results = deserialize.Deserialize<Dictionary<string, string>>(response);
            var resourceList = results["facets"];
            Assert.That(resourceList, Is.EqualTo("Win on wall"), "Data are invalid");

        }
    }
}
