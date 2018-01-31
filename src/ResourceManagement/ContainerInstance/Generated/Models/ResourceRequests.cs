// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The resource requests.
    /// </summary>
    public partial class ResourceRequests
    {
        /// <summary>
        /// Initializes a new instance of the ResourceRequests class.
        /// </summary>
        public ResourceRequests()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceRequests class.
        /// </summary>
        /// <param name="memoryInGB">The memory request in GB of this container
        /// instance.</param>
        /// <param name="cpu">The CPU request of this container
        /// instance.</param>
        public ResourceRequests(double memoryInGB, double cpu)
        {
            MemoryInGB = memoryInGB;
            Cpu = cpu;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the memory request in GB of this container instance.
        /// </summary>
        [JsonProperty(PropertyName = "memoryInGB")]
        public double MemoryInGB { get; set; }

        /// <summary>
        /// Gets or sets the CPU request of this container instance.
        /// </summary>
        [JsonProperty(PropertyName = "cpu")]
        public double Cpu { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}