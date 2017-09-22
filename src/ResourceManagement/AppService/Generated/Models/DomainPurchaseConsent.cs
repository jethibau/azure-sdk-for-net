// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Domain purchase consent object, representing acceptance of applicable
    /// legal agreements.
    /// </summary>
    public partial class DomainPurchaseConsent
    {
        /// <summary>
        /// Initializes a new instance of the DomainPurchaseConsent class.
        /// </summary>
        public DomainPurchaseConsent()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DomainPurchaseConsent class.
        /// </summary>
        /// <param name="agreementKeys">List of applicable legal agreement
        /// keys. This list can be retrieved using ListLegalAgreements API
        /// under &lt;code&gt;TopLevelDomain&lt;/code&gt; resource.</param>
        /// <param name="agreedBy">Client IP address.</param>
        /// <param name="agreedAt">Timestamp when the agreements were
        /// accepted.</param>
        public DomainPurchaseConsent(IList<string> agreementKeys = default(IList<string>), string agreedBy = default(string), System.DateTime? agreedAt = default(System.DateTime?))
        {
            AgreementKeys = agreementKeys;
            AgreedBy = agreedBy;
            AgreedAt = agreedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of applicable legal agreement keys. This list can
        /// be retrieved using ListLegalAgreements API under
        /// &amp;lt;code&amp;gt;TopLevelDomain&amp;lt;/code&amp;gt; resource.
        /// </summary>
        [JsonProperty(PropertyName = "agreementKeys")]
        public IList<string> AgreementKeys { get; set; }

        /// <summary>
        /// Gets or sets client IP address.
        /// </summary>
        [JsonProperty(PropertyName = "agreedBy")]
        public string AgreedBy { get; set; }

        /// <summary>
        /// Gets or sets timestamp when the agreements were accepted.
        /// </summary>
        [JsonProperty(PropertyName = "agreedAt")]
        public System.DateTime? AgreedAt { get; set; }

    }
}