// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 agreement content. </summary>
    public partial class X12AgreementContent
    {
        /// <summary> Initializes a new instance of X12AgreementContent. </summary>
        /// <param name="receiveAgreement"> The X12 one-way receive agreement. </param>
        /// <param name="sendAgreement"> The X12 one-way send agreement. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receiveAgreement"/> or <paramref name="sendAgreement"/> is null. </exception>
        public X12AgreementContent(X12OneWayAgreement receiveAgreement, X12OneWayAgreement sendAgreement)
        {
            Argument.AssertNotNull(receiveAgreement, nameof(receiveAgreement));
            Argument.AssertNotNull(sendAgreement, nameof(sendAgreement));

            ReceiveAgreement = receiveAgreement;
            SendAgreement = sendAgreement;
        }

        /// <summary> The X12 one-way receive agreement. </summary>
        public X12OneWayAgreement ReceiveAgreement { get; set; }
        /// <summary> The X12 one-way send agreement. </summary>
        public X12OneWayAgreement SendAgreement { get; set; }
    }
}
