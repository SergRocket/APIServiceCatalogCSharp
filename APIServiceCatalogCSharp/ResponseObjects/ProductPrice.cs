using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIServiceCatalogCSharp.ResponseObjects
{
    class Prices
    {
        public List<Root> sflySKUs { get; set; }
    }
    public class Root
    {
        public string productCode { get; set; }
        public string skuCode { get; set; }
        public List<string> sflySKUs { get; set; }
        public double origTotalPrice { get; set; }
        public double saleTotalPrice { get; set; }
        public string priceBucket { get; set; }
    }

}
