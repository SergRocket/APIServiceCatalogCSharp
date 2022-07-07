using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;
using TechTalk.SpecFlow;
using APIServiceCatalogCSharp.BaseSettings;

namespace APIServiceCatalogCSharp.Steps
{ 
    [Binding]
    public class CollectPostsSteps
    {
        private Settings _settings;
        public CollectPostsSteps(Settings settings)
        {
            _settings = settings; 
        }

        public RestSharp.RestClient client = new RestSharp.RestClient("https://api2.beta.shutterfly.com");
        public JsonDeserializer deserialize = new JsonDeserializer();

        [Given(@"Perform POST operation for given endpoint")]
        public void GivenPerformPOSTOperationForGivenEndpoint(string basePath)
        {
            _settings.RestClient.BaseUrl = new Uri("https://api2.beta.shutterfly.com");
            _settings.Request = new RestSharp.RestRequest(basePath, RestSharp.Method.POST);
        }

        [When(@"The resourceList is existed and we add params to url")]
        public void WhenTheResourceListIsExisted(string param1, string param2, string param3)
        {
            _settings.Request.AddUrlSegment("q", param1);
            _settings.Request.AddUrlSegment("sid", param2);
            _settings.Request.AddHeader("SFLY-apikey", param3);
            _settings.Request.AddBody(new {fl = "url,title",
                url = "https://www.shutterfly.com/sitesearch/enjoy+cotton+tote",
                refurl = "enjoy%20cotton%20tote%26"});
            var response = _settings.RestClient.Execute(_settings.Request);           

        }

        [Then(@"The values in resourceList is valid")]
        public void ThenTheValuesInResourceListIsValid()
        {
            var results = deserialize.Deserialize<Dictionary<string, string>>(response);
            var resourceList = results["resourceList"];
            NUnit.Framework.Assert.That(resourceList, NUnit.Framework.Is.EqualTo("Wreathed in Joy Holiday Card"), "Data are invalid");
        }

    }
}
