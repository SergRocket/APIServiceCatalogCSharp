using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIServiceCatalogCSharp.BaseSettings
{
    public class Settings
    {
        //public Url BaseUrl { get; set; }
        public RestSharp.IRestResponse<ResponseObjects.ProductsSpecs>Response{ get; set;}
        public RestSharp.IRestRequest Request { get; set; }
        public RestSharp.RestClient RestClient { get; set; } = new RestSharp.RestClient();    


    }
}
