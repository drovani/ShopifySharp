using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp
{
    public abstract class CollectionBase : ShopifyObject
    {
        /// <summary>
        /// The description of the collection, complete with HTML markup. Many templates display this on their collection page.
        /// </summary>
        [JsonProperty("body_html")]
        public string BodyHtml { get; set; }
        /// <summary>
        /// A human-friendly unique string for the collection automatically generated from its title. This is used in shop themes by the Liquid templating language to refer to the collection. Limit of 255 characters.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }
        /// <summary>
        /// This can have two different types of values, depending on whether the collection has been published (i.e., made visible to customers):
        /// If the collection is published, this value is the date and time when it was published.The API returns this value in ISO 8601 format.
        /// If the collection is hidden (i.e., not published), this value is null. Changing a collection's status from published to hidden changes its published_at property to null.
        /// </summary>
        [JsonProperty("published_at")]
        public DateTimeOffset? PublishedAt { get; set; }
        /// <summary>
        /// The sales channels in which the collection is visible.
        /// </summary>
        [JsonProperty("published_scope")]
        public string PublishedScope { get; set; }
        /// <summary>
        /// The order in which products in the collection appear. Known values are 'alpha-asc', 'alpha-desc', 'best-selling', 'created', 'created-desc', 'manual', 'price-asc', 'price-desc'.
        /// </summary>
        [JsonProperty("sort_order")]
        public string SortOrder { get; set; }
        /// <summary>
        /// The suffix of the template you are using. By default, the original template is called product.liquid, without any suffix. Any additional templates will be: product.suffix.liquid.
        /// </summary>
        [JsonProperty("template_suffix")]
        public string TemplateSuffix { get; set; }
        /// <summary>
        /// The name of the collection. Limit of 255 characters.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// The date and time when the collection was last modified. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Additional metadata about the Collection. Note: This is not naturally returned with a Collection response, as
        /// Shopify will not return Collection metafields unless specified. Instead, you need to query metafields with <see cref="MetaFieldService"/>. 
        /// Uses include: Creating, updating, & deserializing webhook bodies that include them.
        /// </summary>
        [JsonProperty("metafields")]
        public IEnumerable<MetaField> Metafields { get; set; }
    }
}

namespace ShopifySharp
{
    public abstract class CollectionBase<TCollectionImage> : CollectionBase where TCollectionImage : CollectionImageBase
    {
        /// <summary>
        /// The collection image.
        /// </summary>
        [JsonProperty("image")]
        public TCollectionImage Image { get; set; }
    }
}