﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// Configurations that allow callers to specify details about how to execute
    /// an Analyze Healthcare Entities action in a set of documents.
    /// For example, set model version and disable service logging.
    /// </summary>
    public class AnalyzeHealthcareEntitiesAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeHealthcareEntitiesAction"/>
        /// class which allows callers to specify details about how to execute
        /// an Analyze Healthcare Entities action in a set of documents.
        /// For example, set model version and disable service logging.
        /// </summary>
        public AnalyzeHealthcareEntitiesAction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeHealthcareEntitiesAction"/>
        /// class based on the values of a <see cref="AnalyzeHealthcareEntitiesOptions"/>.
        /// It sets the <see cref="ModelVersion"/>, <see cref="DisableServiceLogs"/>,
        /// <see cref="FhirVersion"/>, and <see cref="DocumentType"/> properties.
        /// </summary>
        public AnalyzeHealthcareEntitiesAction(AnalyzeHealthcareEntitiesOptions options)
        {
            ModelVersion = options.ModelVersion;
            DisableServiceLogs = options.DisableServiceLogs;
            FhirVersion = options.FhirVersion;
            DocumentType = options.DocumentType;
        }

        /// <summary>
        /// Gets or sets a value that, if set, indicates the version of the text
        /// analytics model that will be used to generate the result.  For supported
        /// model versions, see operation-specific documentation, for example:
        /// <see href="https://docs.microsoft.com/azure/cognitive-services/language-service/concepts/model-lifecycle#available-versions"/>.
        /// </summary>
        public string ModelVersion { get; set; }

        /// <summary>
        /// The default value of this property is 'false'. This means, the Language service logs your input text for 48 hours,
        /// solely to allow for troubleshooting issues.
        /// Setting this property to true, disables input logging and may limit our ability to investigate issues that occur.
        /// <para>
        /// Please see Cognitive Services Compliance and Privacy notes at <see href="https://aka.ms/cs-compliance"/> for additional details,
        /// and Microsoft Responsible AI principles at <see href="https://www.microsoft.com/ai/responsible-ai"/>.
        /// </para>
        /// </summary>
        public bool? DisableServiceLogs { get; set; }

        /// <summary>
        /// Gets or sets a name for this action. If not provided, the service will generate one.
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// The version of the FHIR specification that will be used to format the <see cref="AnalyzeHealthcareEntitiesResult.FhirBundle"/>
        /// in the result. If not set, the <see cref="AnalyzeHealthcareEntitiesResult.FhirBundle"/> will not be produced. For additional information, see
        /// <see href="https://www.hl7.org/fhir/overview.html"/>.
        /// </summary>
        public FhirVersion? FhirVersion { get; set; }

        /// <summary>
        /// The document type, which can be provided as a hint to improve the production of the <see cref="AnalyzeHealthcareEntitiesResult.FhirBundle"/> when
        /// the <see cref="AnalyzeHealthcareEntitiesOptions.FhirVersion"/> property is specified. The default behavior is equivalent to using
        /// <see cref="HealthcareDocumentType.None"/>.
        /// </summary>
        public HealthcareDocumentType? DocumentType { get; set; }
    }
}
