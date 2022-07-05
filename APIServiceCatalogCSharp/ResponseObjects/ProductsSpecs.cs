using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIServiceCatalogCSharp.ResponseObjects
{
    class ProductsSpecs
    {
        public int totalCategoryCounts { get; set; }
        public int totalProductCounts { get; set; }
        public int totalSkuCounts { get; set; }
        public int nonAvailableProductCounts { get; set; }
        public int nonAvailableSkuCounts { get; set; }
        public int linkedCategoryCounts { get; set; }
        public Boolean fetchingThumbnails { get; set; }
        public int totalLinkedCatProcessTimeSeconds { get; set; }
        public int totalTimeProcessSeconds { get; set; }
    }
}
