// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The ContinuousDtmfRecognitionRequest. </summary>
    internal partial class ContinuousDtmfRecognitionRequestInternal
    {
        /// <summary> Initializes a new instance of ContinuousDtmfRecognitionRequestInternal. </summary>
        /// <param name="targetParticipant"> Defines options for recognition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetParticipant"/> is null. </exception>
        public ContinuousDtmfRecognitionRequestInternal(CommunicationIdentifierModel targetParticipant)
        {
            Argument.AssertNotNull(targetParticipant, nameof(targetParticipant));

            TargetParticipant = targetParticipant;
        }

        /// <summary> Defines options for recognition. </summary>
        public CommunicationIdentifierModel TargetParticipant { get; }
        /// <summary> The value to identify context of the operation. </summary>
        public string OperationContext { get; set; }
    }
}
