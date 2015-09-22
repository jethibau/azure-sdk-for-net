// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    /// <summary>
    /// Description of a NotificationHub GcmCredential.
    /// </summary>
    public partial class GcmCredentialProperties
    {
        private string _gcmEndpoint;
        
        /// <summary>
        /// Optional. Gets or sets the GCM endpoint.
        /// </summary>
        public string GcmEndpoint
        {
            get { return this._gcmEndpoint; }
            set { this._gcmEndpoint = value; }
        }
        
        private string _googleApiKey;
        
        /// <summary>
        /// Optional. Gets or sets the Google API key.
        /// </summary>
        public string GoogleApiKey
        {
            get { return this._googleApiKey; }
            set { this._googleApiKey = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GcmCredentialProperties class.
        /// </summary>
        public GcmCredentialProperties()
        {
        }
    }
}