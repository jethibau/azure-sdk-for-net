// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An azure function receiver.
    /// </summary>
    public partial class AzureFunctionReceiver
    {
        /// <summary>
        /// Initializes a new instance of the AzureFunctionReceiver class.
        /// </summary>
        public AzureFunctionReceiver()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureFunctionReceiver class.
        /// </summary>
        /// <param name="name">The name of the azure function receiver. Names
        /// must be unique across all receivers within an action group.</param>
        /// <param name="functionAppResourceId">The azure resource id of the
        /// function app.</param>
        /// <param name="functionName">The function name in the function
        /// app.</param>
        /// <param name="httpTriggerUrl">The http trigger url where http
        /// request sent to.</param>
        public AzureFunctionReceiver(string name, string functionAppResourceId, string functionName, string httpTriggerUrl)
        {
            Name = name;
            FunctionAppResourceId = functionAppResourceId;
            FunctionName = functionName;
            HttpTriggerUrl = httpTriggerUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the azure function receiver. Names must be
        /// unique across all receivers within an action group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the azure resource id of the function app.
        /// </summary>
        [JsonProperty(PropertyName = "functionAppResourceId")]
        public string FunctionAppResourceId { get; set; }

        /// <summary>
        /// Gets or sets the function name in the function app.
        /// </summary>
        [JsonProperty(PropertyName = "functionName")]
        public string FunctionName { get; set; }

        /// <summary>
        /// Gets or sets the http trigger url where http request sent to.
        /// </summary>
        [JsonProperty(PropertyName = "httpTriggerUrl")]
        public string HttpTriggerUrl { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (FunctionAppResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FunctionAppResourceId");
            }
            if (FunctionName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FunctionName");
            }
            if (HttpTriggerUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HttpTriggerUrl");
            }
        }
    }
}