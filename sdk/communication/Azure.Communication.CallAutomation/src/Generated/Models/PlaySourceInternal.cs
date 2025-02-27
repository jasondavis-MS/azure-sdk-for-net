// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The PlaySource. </summary>
    internal partial class PlaySourceInternal
    {
        /// <summary> Initializes a new instance of PlaySourceInternal. </summary>
        /// <param name="sourceType"> Defines the type of the play source. </param>
        public PlaySourceInternal(PlaySourceTypeInternal sourceType)
        {
            SourceType = sourceType;
        }

        /// <summary> Defines the type of the play source. </summary>
        public PlaySourceTypeInternal SourceType { get; }
        /// <summary> Defines the identifier to be used for caching related media. </summary>
        public string PlaySourceId { get; set; }
        /// <summary> Defines the file source info to be used for play. </summary>
        public FileSourceInternal FileSource { get; set; }
        /// <summary> Defines the text source info to be used for play. </summary>
        public TextSourceInternal TextSource { get; set; }
        /// <summary> Defines the ssml(Speech Synthesis Markup Language) source info to be used for play. </summary>
        public SsmlSourceInternal SsmlSource { get; set; }
    }
}
