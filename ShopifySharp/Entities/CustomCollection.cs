using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp
{
    /// <summary>
    /// An entity representing a Shopify Custom Collection Object.
    /// </summary>
    public class CustomCollection : CollectionBase<CustomCollectionImage>
    {
        /// <summary>
        /// Whether the collection is published or not.
        /// </summary>
        [JsonProperty("published")]
        public bool? Published { get; set; }

        /// <summary>
        /// The collection of collects associated to this custom collection
        /// </summary>
        [JsonProperty("collects")]
        public IEnumerable<Collect> Collects { get; set; }
    }
}
