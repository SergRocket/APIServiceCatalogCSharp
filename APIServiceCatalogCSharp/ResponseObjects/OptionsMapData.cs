using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIServiceCatalogCSharp.ResponseObjects
{
    public class OptionsMapData
    {
        public class AgeGroupName
        {
            public int count { get; set; }
            public string name { get; set; }
        }

        public class Category
        {
            public int count { get; set; }
            public string crumb { get; set; }
            public string cat_name { get; set; }
            public string parent { get; set; }
            public string cat_id { get; set; }
            public string tree_path { get; set; }
        }

        public class ColorShadeHexValue
        {
            public int count { get; set; }
            public string name { get; set; }
        }

        public class DefaultNumberOfPhoto
        {
            public int count { get; set; }
            public string name { get; set; }
        }

        public class DesignerCode
        {
            public int count { get; set; }
            public string name { get; set; }
        }

        public class DesignOccasion
        {
            public int count { get; set; }
            public string name { get; set; }
        }

        public class Dimension
        {
            public int count { get; set; }
            public string name { get; set; }
        }

        public class EpRecipient
        {
            public int count { get; set; }
            public string name { get; set; }
        }

        public class FacetFields
        {
            public List<Category> category { get; set; }

            public List<SalePrice> SalePrice { get; set; }
            public List<MinPrice> minPrice { get; set; }
            public List<Dimension> dimensions { get; set; }
            public List<ColorShadeHexValue> colorShadeHexValue { get; set; }
            public List<DesignOccasion> designOccasion { get; set; }
            public List<EpRecipient> epRecipient { get; set; }
            public List<AgeGroupName> ageGroupName { get; set; }
            public List<DesignerCode> designerCode { get; set; }
            public List<ProductType> productType { get; set; }
            public List<DefaultNumberOfPhoto> defaultNumberOfPhotos { get; set; }
        }

        public class Facets
        {
            public FacetFields facet_fields { get; set; }
        }

        public class MinPrice
        {
            public int count { get; set; }
            public string name { get; set; }
        }

        public class Page
        {
            public int totalElements { get; set; }
            public int number { get; set; }
            public int size { get; set; }
            public int totalPages { get; set; }
        }

        public class ProductType
        {
            public int count { get; set; }
            public string name { get; set; }
        }

        public class ResourceList
        {
            public string url { get; set; }
            public string pid { get; set; }
            public string title { get; set; }
        }

        public class Root
        {
            public List<ResourceList> resourceList { get; set; }
            public Facets facets { get; set; }
            public Page page { get; set; }
        }

        public class SalePrice
        {
            public int count { get; set; }
            public string name { get; set; }
        }


    }
}
