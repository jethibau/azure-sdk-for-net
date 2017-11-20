// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Microsoft.Azure.Management.Compute.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies information about the marketplace image used to create the
    /// virtual machine. This element is only used for marketplace images.
    /// Before you can use a marketplace image from an API, you must enable the
    /// image for programmatic use.  In the Azure portal, find the marketplace
    /// image that you want to use and then click **Want to deploy
    /// programmatically, Get Started -&gt;**. Enter any required information
    /// and then click **Save**.
    /// </summary>
    public partial class Plan
    {
        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        public Plan()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        /// <param name="name">The plan ID.</param>
        /// <param name="publisher">The publisher ID.</param>
        /// <param name="product">Specifies the product of the image from the
        /// marketplace. This is the same value as Offer under the
        /// imageReference element.</param>
        /// <param name="promotionCode">The promotion code.</param>
        public Plan(string name = default(string), string publisher = default(string), string product = default(string), string promotionCode = default(string))
        {
            Name = name;
            Publisher = publisher;
            Product = product;
            PromotionCode = promotionCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the plan ID.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the publisher ID.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets specifies the product of the image from the
        /// marketplace. This is the same value as Offer under the
        /// imageReference element.
        /// </summary>
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets the promotion code.
        /// </summary>
        [JsonProperty(PropertyName = "promotionCode")]
        public string PromotionCode { get; set; }

    }
}