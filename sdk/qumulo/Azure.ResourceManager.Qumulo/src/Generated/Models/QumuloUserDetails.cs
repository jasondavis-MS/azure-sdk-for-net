// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Qumulo.Models
{
    /// <summary> User Details of Qumulo FileSystem resource. </summary>
    public partial class QumuloUserDetails
    {
        /// <summary> Initializes a new instance of QumuloUserDetails. </summary>
        /// <param name="email"> User Email. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="email"/> is null. </exception>
        public QumuloUserDetails(string email)
        {
            Argument.AssertNotNull(email, nameof(email));

            Email = email;
        }

        /// <summary> User Email. </summary>
        public string Email { get; set; }
    }
}
