using System;
using System.Collections.Generic;


namespace APIServiceCatalogCSharp.RequestObjects
{
    class ProductsPost
    {
        public Boolean includeThumbnails { get; set; }
        public string storeCode { get; set; }
        public int testProductCount { get; set; }
        public List<string> productCodes { get; set; }
    }
}
