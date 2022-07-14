using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;
using TechTalk.SpecFlow;

namespace APIServiceCatalogCSharp.Steps
{
    [Binding]
    class PostingProfileSteps
    {
        private BaseSettings.Settings _settings;
        public PostingProfileSteps(BaseSettings.Settings settings)
        {
            _settings = settings;
        }

        public RestSharp.RestClient client = new RestSharp.RestClient("https://api2.beta.shutterfly.com");
        public JsonDeserializer deserialize = new JsonDeserializer();

        [Given(@"performming post operation on search endpoint")]
        public void GivenPerformPOSTOperationForGivenEndpoint(string basePath)
        {
            _settings.Request = new RestSharp.RestRequest(basePath, RestSharp.Method.POST);
        }

        [When(@"having invalid search query")]
        public void WhenTheResourceListIsExisted(string param1, string param2, string param3)
        {
            _settings.Request.AddUrlSegment("q", "muggs");
            _settings.Request.AddUrlSegment("sid", "upd_2");
            _settings.Request.AddUrlSegment("fl", "muggs");
            _settings.Request.AddUrlSegment("sid", "price%26fq=price:[* TO 100]");
            _settings.Request.AddHeader("SFLY-apikey", "vHAx0uG8Ndr");
            var response = _settings.RestClient.Execute(_settings.Request);
        }

        [Then(@"in json I got 'did you mean' message")]
        public void ThenTheValuesInResourceListIsValid()
        {
            var results = deserialize.Deserialize<Dictionary<string, string>>(response);
            var suggestionList = results["resourceList"];
            NUnit.Framework.Assert.That(suggestionList, NUnit.Framework.Is.EqualTo("didYouMean this values"), "Data are invalid");
        }
    }
}
