using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIServiceCatalogCSharp.ResponseObjects
{
    public class OptionsMap
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class _6X8FLATCARD06
        {
            public List<int> quantities { get; set; }
            public int defaultQuantity { get; set; }
        }

        public class AltView
        {
            public string label { get; set; }
            public string imageUrl { get; set; }
        }

        public class BlueprintOption
        {
            public OptionsMap optionsMap { get; set; }
            public string skuCode { get; set; }
            public string sizeId { get; set; }
            public string styleId { get; set; }
            public string occasionId { get; set; }
            public object bundleId { get; set; }
            public string pricingSku { get; set; }
            public string premiumSku { get; set; }
            public string premiumSizeId { get; set; }
            public List<Option> options { get; set; }
        }

        public class ChildOption
        {
            public string key { get; set; }
            public string defaultValue { get; set; }
            public List<Value> values { get; set; }
            public string displayName { get; set; }
        }

        public class CreationPath
        {
            public string baseUrl { get; set; }
            public Params @params { get; set; }
        }

        public class Data
        {
            public string label { get; set; }
            public string url { get; set; }
        }

        public class DESIGNERCARD06
        {
            public List<int> quantities { get; set; }
            public int defaultQuantity { get; set; }
        }

        public class DesignerDetails
        {
            public int statusCode { get; set; }
            public Data data { get; set; }
        }

        public class FormatOptions
        {
        }

        public class ImageUrl
        {
            public string label { get; set; }
            public string imageUrl { get; set; }
        }

        public class Metadata
        {
            public string title { get; set; }
            public string categoryCode { get; set; }
            public string productCategory { get; set; }
            public string brand { get; set; }
            public MoreDetails moreDetails { get; set; }
            public bool isGalleonProduct { get; set; }
            public string productTypeName { get; set; }
            public string occasionName { get; set; }
            public object marketplaceDesignerName { get; set; }
            public object marketPlaceDesignerId { get; set; }
            public object marketplaceDesignName { get; set; }
            public object marketplaceProvider { get; set; }
            public bool isPersonalizable { get; set; }
            public DesignerDetails designerDetails { get; set; }
            public bool pdtSupported { get; set; }
        }

        public class MoreDetails
        {
            public List<string> MailOptions { get; set; }
            public string styleName { get; set; }
            public string abnTheme { get; set; }
            public string abnFeatured { get; set; }
            public string Type { get; set; }
            public string Orientation { get; set; }
            public string Photos { get; set; }
            public string size { get; set; }
        }

        public class Option
        {
            public string key { get; set; }
            public string defaultValue { get; set; }
            public List<Value> values { get; set; }
            public string displayName { get; set; }
        }

        public class OptionResourceMap
        {
            public OptionsMap optionsMap { get; set; }
            public string skuCode { get; set; }
            public string creationPathUrl { get; set; }
            public CreationPath creationPath { get; set; }
            public string optionResourceUID { get; set; }
            public string shortDescription { get; set; }
            public List<ImageUrl> imageUrls { get; set; }
            public List<AltView> altViews { get; set; }
            public bool isEPDefault { get; set; }
            public List<string> details { get; set; }
            public MoreDetails moreDetails { get; set; }
            public object bookAdditionalPageSku { get; set; }
            public string formFactorId { get; set; }
            public object marketplaceBackgroundName { get; set; }
            public string availability { get; set; }
        }

        public class OptionsMaps
        {
            public string color { get; set; }
            public string CARD_SIZE_ID { get; set; }
            public string GREETING { get; set; }
            public string PAPER_TYPE { get; set; }
            public string TRIM { get; set; }
            public string PAPER_FINISH { get; set; }
        }

        public class Params
        {
            public string brand { get; set; }
            public string skuCode { get; set; }
            public string productCode { get; set; }
            public string categoryCode { get; set; }
            public string bundleId { get; set; }
            public string sizeIds { get; set; }
            public string occasionIds { get; set; }
            public string styleIds { get; set; }
        }

        public class ProductOption
        {
            public string key { get; set; }
            public string displayName { get; set; }
            public List<Value> values { get; set; }
        }

        public class QuantityOptions
        {
            public DESIGNERCARD06 DESIGNERCARD06 { get; set; }
            public _6X8FLATCARD06 _6X8FLATCARD06 { get; set; }
        }

        public class Root
        {
            public string productCode { get; set; }
            public Metadata metadata { get; set; }
            public List<ProductOption> productOptions { get; set; }
            public List<BlueprintOption> blueprintOptions { get; set; }
            public FormatOptions formatOptions { get; set; }
            public QuantityOptions quantityOptions { get; set; }
            public List<OptionResourceMap> optionResourceMap { get; set; }
        }

        public class Value
        {
            public string value { get; set; }
            public int displayOrder { get; set; }
            public string displayName { get; set; }
            public string uniqueKey { get; set; }
            public string availability { get; set; }
            public string iconClass { get; set; }
            public string sizeId { get; set; }
            public bool isBaseSku { get; set; }
            public List<ChildOption> childOptions { get; set; }
            public string detailedDescription { get; set; }
            public string description { get; set; }
            public bool isPromoted { get; set; }
            public string pricingSku { get; set; }
        }
    }
}
