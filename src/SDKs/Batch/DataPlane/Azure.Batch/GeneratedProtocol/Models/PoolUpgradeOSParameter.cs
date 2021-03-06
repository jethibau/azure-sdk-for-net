// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Options for upgrading the operating system of compute nodes in a pool.
    /// </summary>
    public partial class PoolUpgradeOSParameter
    {
        /// <summary>
        /// Initializes a new instance of the PoolUpgradeOSParameter class.
        /// </summary>
        public PoolUpgradeOSParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PoolUpgradeOSParameter class.
        /// </summary>
        /// <param name="targetOSVersion">The Azure Guest OS version to be
        /// installed on the virtual machines in the pool.</param>
        public PoolUpgradeOSParameter(string targetOSVersion)
        {
            TargetOSVersion = targetOSVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Guest OS version to be installed on the
        /// virtual machines in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "targetOSVersion")]
        public string TargetOSVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetOSVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetOSVersion");
            }
        }
    }
}
