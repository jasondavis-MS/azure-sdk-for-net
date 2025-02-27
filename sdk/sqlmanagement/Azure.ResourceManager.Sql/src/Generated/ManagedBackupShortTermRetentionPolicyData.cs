// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the ManagedBackupShortTermRetentionPolicy data model.
    /// A short term retention policy.
    /// </summary>
    public partial class ManagedBackupShortTermRetentionPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagedBackupShortTermRetentionPolicyData. </summary>
        public ManagedBackupShortTermRetentionPolicyData()
        {
        }

        /// <summary> Initializes a new instance of ManagedBackupShortTermRetentionPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="retentionDays"> The backup retention period in days. This is how many days Point-in-Time Restore will be supported. </param>
        internal ManagedBackupShortTermRetentionPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? retentionDays) : base(id, name, resourceType, systemData)
        {
            RetentionDays = retentionDays;
        }

        /// <summary> The backup retention period in days. This is how many days Point-in-Time Restore will be supported. </summary>
        public int? RetentionDays { get; set; }
    }
}
