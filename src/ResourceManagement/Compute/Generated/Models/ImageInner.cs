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
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The source user image virtual hard disk. The virtual hard disk will be
    /// copied before being attached to the virtual machine. If SourceImage is
    /// provided, the destination virtual hard drive must not exist.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ImageInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ImageInner class.
        /// </summary>
        public ImageInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageInner class.
        /// </summary>
        /// <param name="sourceVirtualMachine">The source virtual machine from
        /// which Image is created.</param>
        /// <param name="storageProfile">Specifies the storage settings for the
        /// virtual machine disks.</param>
        /// <param name="provisioningState">The provisioning state.</param>
        public ImageInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Microsoft.Azure.Management.ResourceManager.Fluent.SubResource sourceVirtualMachine = default(Microsoft.Azure.Management.ResourceManager.Fluent.SubResource), ImageStorageProfile storageProfile = default(ImageStorageProfile), string provisioningState = default(string))
            : base(location, id, name, type, tags)
        {
            SourceVirtualMachine = sourceVirtualMachine;
            StorageProfile = storageProfile;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source virtual machine from which Image is
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceVirtualMachine")]
        public Microsoft.Azure.Management.ResourceManager.Fluent.SubResource SourceVirtualMachine { get; set; }

        /// <summary>
        /// Gets or sets specifies the storage settings for the virtual machine
        /// disks.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageProfile")]
        public ImageStorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets the provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageProfile != null)
            {
                StorageProfile.Validate();
            }
        }
    }
}