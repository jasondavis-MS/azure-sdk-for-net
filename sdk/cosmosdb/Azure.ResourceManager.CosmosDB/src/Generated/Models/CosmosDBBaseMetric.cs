// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Metric data. </summary>
    public partial class CosmosDBBaseMetric
    {
        /// <summary> Initializes a new instance of CosmosDBBaseMetric. </summary>
        internal CosmosDBBaseMetric()
        {
            MetricValues = new ChangeTrackingList<CosmosDBMetricValue>();
        }

        /// <summary> Initializes a new instance of CosmosDBBaseMetric. </summary>
        /// <param name="startOn"> The start time for the metric (ISO-8601 format). </param>
        /// <param name="endOn"> The end time for the metric (ISO-8601 format). </param>
        /// <param name="timeGrain"> The time grain to be used to summarize the metric values. </param>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="name"> The name information for the metric. </param>
        /// <param name="metricValues"> The metric values for the specified time window and timestep. </param>
        internal CosmosDBBaseMetric(DateTimeOffset? startOn, DateTimeOffset? endOn, string timeGrain, CosmosDBMetricUnitType? unit, CosmosDBMetricName name, IReadOnlyList<CosmosDBMetricValue> metricValues)
        {
            StartOn = startOn;
            EndOn = endOn;
            TimeGrain = timeGrain;
            Unit = unit;
            Name = name;
            MetricValues = metricValues;
        }

        /// <summary> The start time for the metric (ISO-8601 format). </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The end time for the metric (ISO-8601 format). </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The time grain to be used to summarize the metric values. </summary>
        public string TimeGrain { get; }
        /// <summary> The unit of the metric. </summary>
        public CosmosDBMetricUnitType? Unit { get; }
        /// <summary> The name information for the metric. </summary>
        public CosmosDBMetricName Name { get; }
        /// <summary> The metric values for the specified time window and timestep. </summary>
        public IReadOnlyList<CosmosDBMetricValue> MetricValues { get; }
    }
}
