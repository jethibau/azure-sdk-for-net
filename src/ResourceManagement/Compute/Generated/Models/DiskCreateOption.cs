// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DiskCreateOption.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DiskCreateOption
    {
        [EnumMember(Value = "Empty")]
        Empty,
        [EnumMember(Value = "Attach")]
        Attach,
        [EnumMember(Value = "FromImage")]
        FromImage,
        [EnumMember(Value = "Import")]
        Import,
        [EnumMember(Value = "Copy")]
        Copy
    }
    internal static class DiskCreateOptionEnumExtension
    {
        internal static string ToSerializedValue(this DiskCreateOption? value)
        {
            return value == null ? null : ((DiskCreateOption)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DiskCreateOption value)
        {
            switch( value )
            {
                case DiskCreateOption.Empty:
                    return "Empty";
                case DiskCreateOption.Attach:
                    return "Attach";
                case DiskCreateOption.FromImage:
                    return "FromImage";
                case DiskCreateOption.Import:
                    return "Import";
                case DiskCreateOption.Copy:
                    return "Copy";
            }
            return null;
        }

        internal static DiskCreateOption? ParseDiskCreateOption(this string value)
        {
            switch( value )
            {
                case "Empty":
                    return DiskCreateOption.Empty;
                case "Attach":
                    return DiskCreateOption.Attach;
                case "FromImage":
                    return DiskCreateOption.FromImage;
                case "Import":
                    return DiskCreateOption.Import;
                case "Copy":
                    return DiskCreateOption.Copy;
            }
            return null;
        }
    }
}