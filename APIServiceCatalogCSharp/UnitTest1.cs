
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using APIServiceCatalogCSharp.Utils;
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
            var productCode = response.DeserializeResponse()["productCode"];
            Assert.That(productCode, Is.EqualTo("1431302"),  "Data are invalid");
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
            var resourceList = results["resourceList"];
            Assert.That(resourceList, Is.EqualTo("Wreathed in Joy Holiday Card"), "Data are invalid");
        }

        [Test]
        public void TestMethodProductPriceOptions()
        {
            var client = new RestClient("https://product-feed.beta.shutterfly.com");
            var request = new RestRequest("/debug/testRetrieveProducts", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new RequestObjects.ProductsPost() { includeThumbnails = true
            ,productCodes = new List<string> { "2037481" }, storeCode = "web", testProductCount = 0});
            var deserialize = new JsonDeserializer();
            var response = client.Execute<ResponseObjects.ProductsSpecs>(request);
            Assert.That(response.Data.fetchingThumbnails, Is.EqualTo(true), "Data are invalid");
            Assert.That(response.Data.totalSkuCounts, Is.EqualTo(1), "Data are invalid");
            }

        [Test]
        public void TestMethodProductPriceOptionsAsync()
        {
            var client = new RestClient("https://product-feed.beta.shutterfly.com");
            var request = new RestRequest("/debug/testRetrieveProducts", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new RequestObjects.ProductsPost()
            {includeThumbnails = true,productCodes = new List<string> { "2037481" },
            storeCode = "web",testProductCount = 0});
            //var response = client.Execute<ResponseObjects.ProductsSpecs>(request);
            var response = client.ExecuteAsyncRequest<ResponseObjects.ProductsSpecs>(client, request).GetAwaiter().GetResult();
            Assert.That(response.Data.linkedCategoryCounts, Is.EqualTo(200), "Data are invalid");
            Assert.That(response.Data.totalProductCounts, Is.EqualTo(1), "Data are invalid");
        }

    }


}
