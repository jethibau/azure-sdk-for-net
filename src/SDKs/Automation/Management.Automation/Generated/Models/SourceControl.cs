// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of the source control.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SourceControl : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SourceControl class.
        /// </summary>
        public SourceControl()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SourceControl class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="repoUrl">Gets or sets the repo url of the source
        /// control.</param>
        /// <param name="branch">Gets or sets the repo branch of the source
        /// control. Include branch as empty string for VsoTfvc.</param>
        /// <param name="folderPath">Gets or sets the folder path of the source
        /// control.</param>
        /// <param name="autoSync">Gets or sets auto async of the source
        /// control. Default is false.</param>
        /// <param name="publishRunbook">Gets or sets the auto publish of the
        /// source control. Default is true.</param>
        /// <param name="sourceType">The source type. Must be one of VsoGit,
        /// VsoTfvc, GitHub. Possible values include: 'VsoGit', 'VsoTfvc',
        /// 'GitHub'</param>
        /// <param name="description">Gets or sets the description.</param>
        /// <param name="creationTime">Gets or sets the creation time.</param>
        /// <param name="lastModifiedTime">Gets or sets the last modified
        /// time.</param>
        public SourceControl(string id = default(string), string name = default(string), string type = default(string), string repoUrl = default(string), string branch = default(string), string folderPath = default(string), bool? autoSync = default(bool?), bool? publishRunbook = default(bool?), string sourceType = default(string), string description = default(string), System.DateTimeOffset creationTime = default(System.DateTimeOffset), System.DateTimeOffset lastModifiedTime = default(System.DateTimeOffset))
            : base(id, name, type)
        {
            RepoUrl = repoUrl;
            Branch = branch;
            FolderPath = folderPath;
            AutoSync = autoSync;
            PublishRunbook = publishRunbook;
            SourceType = sourceType;
            Description = description;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the repo url of the source control.
        /// </summary>
        [JsonProperty(PropertyName = "properties.repoUrl")]
        public string RepoUrl { get; set; }

        /// <summary>
        /// Gets or sets the repo branch of the source control. Include branch
        /// as empty string for VsoTfvc.
        /// </summary>
        [JsonProperty(PropertyName = "properties.branch")]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or sets the folder path of the source control.
        /// </summary>
        [JsonProperty(PropertyName = "properties.folderPath")]
        public string FolderPath { get; set; }

        /// <summary>
        /// Gets or sets auto async of the source control. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoSync")]
        public bool? AutoSync { get; set; }

        /// <summary>
        /// Gets or sets the auto publish of the source control. Default is
        /// true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishRunbook")]
        public bool? PublishRunbook { get; set; }

        /// <summary>
        /// Gets or sets the source type. Must be one of VsoGit, VsoTfvc,
        /// GitHub. Possible values include: 'VsoGit', 'VsoTfvc', 'GitHub'
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceType")]
        public string SourceType { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTimeOffset CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTimeOffset LastModifiedTime { get; set; }

    }
}