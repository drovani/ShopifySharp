using Newtonsoft.Json;
using ShopifySharp;
using System;
using System.Collections.Generic;

namespace ShopifySharp
{
    /// <summary>
    /// An entity representing a Shopify Smart Collection Object.
    /// </summary>
    public class SmartCollection : CollectionBase<SmartCollectionImage>
    {
        /// <summary>
        /// The list of rules that define what products go into the smart collection.        
        /// </summary>
        [JsonProperty("rules")]
        public IEnumerable<SmartCollectionRules> Rules { get; set; }

        /// <summary>
        /// If false, products must match all of the rules to be included in the collection. If true, products can only match one of the rules.
        /// </summary>
        [JsonProperty("disjunctive")]
        public bool? Disjunctive { get; set; }
    }
}
