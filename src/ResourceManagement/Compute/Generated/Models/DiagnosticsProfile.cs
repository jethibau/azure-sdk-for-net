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
    /// Specifies the boot diagnostic settings state.
    /// &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15.
    /// </summary>
    public partial class DiagnosticsProfile
    {
        /// <summary>
        /// Initializes a new instance of the DiagnosticsProfile class.
        /// </summary>
        public DiagnosticsProfile()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiagnosticsProfile class.
        /// </summary>
        /// <param name="bootDiagnostics">Boot Diagnostics is a debugging
        /// feature which allows you to view Console Output and Screenshot to
        /// diagnose VM status. &lt;br&gt;&lt;br&gt; For Linux Virtual
        /// Machines, you can easily view the output of your console log.
        /// &lt;br&gt;&lt;br&gt; For both Windows and Linux virtual machines,
        /// Azure also enables you to see a screenshot of the VM from the
        /// hypervisor.</param>
        public DiagnosticsProfile(BootDiagnostics bootDiagnostics = default(BootDiagnostics))
        {
            BootDiagnostics = bootDiagnostics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets boot Diagnostics is a debugging feature which allows
        /// you to view Console Output and Screenshot to diagnose VM status.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For Linux Virtual Machines,
        /// you can easily view the output of your console log.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For both Windows and Linux
        /// virtual machines, Azure also enables you to see a screenshot of the
        /// VM from the hypervisor.
        /// </summary>
        [JsonProperty(PropertyName = "bootDiagnostics")]
        public BootDiagnostics BootDiagnostics { get; set; }

    }
}