
#nullable enable

namespace Descript
{
    /// <summary>
    /// Timecode options. When provided, timecodes are included in<br/>
    /// the output.
    /// </summary>
    public sealed partial class ExportTranscriptRequestTimecodes
    {
        /// <summary>
        /// Interval in seconds for timecode insertion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_seconds")]
        public double? FrequencySeconds { get; set; }

        /// <summary>
        /// Show timecodes at paragraph breaks.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_paragraphs")]
        public bool? OnParagraphs { get; set; }

        /// <summary>
        /// Show timecodes at speaker changes.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_speakers")]
        public bool? OnSpeakers { get; set; }

        /// <summary>
        /// Show timecodes at markers.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_markers")]
        public bool? OnMarkers { get; set; }

        /// <summary>
        /// Offset in seconds applied to all timecodes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_seconds")]
        public double? OffsetSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportTranscriptRequestTimecodes" /> class.
        /// </summary>
        /// <param name="frequencySeconds">
        /// Interval in seconds for timecode insertion.
        /// </param>
        /// <param name="onParagraphs">
        /// Show timecodes at paragraph breaks.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="onSpeakers">
        /// Show timecodes at speaker changes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="onMarkers">
        /// Show timecodes at markers.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="offsetSeconds">
        /// Offset in seconds applied to all timecodes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportTranscriptRequestTimecodes(
            double? frequencySeconds,
            bool? onParagraphs,
            bool? onSpeakers,
            bool? onMarkers,
            double? offsetSeconds)
        {
            this.FrequencySeconds = frequencySeconds;
            this.OnParagraphs = onParagraphs;
            this.OnSpeakers = onSpeakers;
            this.OnMarkers = onMarkers;
            this.OffsetSeconds = offsetSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportTranscriptRequestTimecodes" /> class.
        /// </summary>
        public ExportTranscriptRequestTimecodes()
        {
        }

    }
}