using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace APIServiceCatalogCSharp
{
    [TestClass]
    public class UnitTest1
    {
        private object response;

        [TestMethod]
        public void TestMethod1()
        {
            var client = new RestClient("https://api2.beta.shutterfly.com");
            var request = new RestRequest("/pipdata/v1/product/{productId}", Method.Get);
            request.AddUrlSegment("productId", 1431302);
            var content = client.Execute(request).Content;
         }
    }
}
