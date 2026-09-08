
#nullable enable

namespace Descript
{
    /// <summary>
    /// Request to export the transcript from a project composition.
    /// </summary>
    public sealed partial class ExportTranscriptRequest
    {
        /// <summary>
        /// The ID of the project to export from.<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Composition to export. If omitted, the first composition in the project is used.<br/>
        /// Accepts any of the following formats:<br/>
        /// - A full composition UUID (e.g. `39677a40-1c43-4c36-8449-46cfbc4de2b5`)<br/>
        /// - A 5-character short ID from a Descript URL (e.g. `39677`)<br/>
        /// - A full Descript project URL (e.g. `https://web.descript.com/{project_id}/39677`)<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </summary>
        /// <example>39677a40-1c43-4c36-8449-46cfbc4de2b5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_id")]
        public string? CompositionId { get; set; }

        /// <summary>
        /// Transcript file format. The response body is the raw transcript file<br/>
        /// in the requested format (binary for `docx`, plain text otherwise).<br/>
        /// The `srt` format exports a SubRip subtitle file with timed captions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.ExportTranscriptRequestFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Descript.ExportTranscriptRequestFormat Format { get; set; }

        /// <summary>
        /// Speaker label mode.<br/>
        /// - `off`: No speaker labels<br/>
        /// - `changes`: Show speaker label when the speaker changes<br/>
        /// - `every_paragraph`: Show speaker label on every paragraph<br/>
        /// Default Value: changes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_speaker_labels")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.ExportTranscriptRequestIncludeSpeakerLabelsJsonConverter))]
        public global::Descript.ExportTranscriptRequestIncludeSpeakerLabels? IncludeSpeakerLabels { get; set; }

        /// <summary>
        /// Include markers in the transcript.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_markers")]
        public bool? IncludeMarkers { get; set; }

        /// <summary>
        /// Timecode options. When provided, timecodes are included in<br/>
        /// the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timecodes")]
        public global::Descript.ExportTranscriptRequestTimecodes? Timecodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportTranscriptRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project to export from.<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="format">
        /// Transcript file format. The response body is the raw transcript file<br/>
        /// in the requested format (binary for `docx`, plain text otherwise).<br/>
        /// The `srt` format exports a SubRip subtitle file with timed captions.
        /// </param>
        /// <param name="compositionId">
        /// Composition to export. If omitted, the first composition in the project is used.<br/>
        /// Accepts any of the following formats:<br/>
        /// - A full composition UUID (e.g. `39677a40-1c43-4c36-8449-46cfbc4de2b5`)<br/>
        /// - A 5-character short ID from a Descript URL (e.g. `39677`)<br/>
        /// - A full Descript project URL (e.g. `https://web.descript.com/{project_id}/39677`)<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </param>
        /// <param name="includeSpeakerLabels">
        /// Speaker label mode.<br/>
        /// - `off`: No speaker labels<br/>
        /// - `changes`: Show speaker label when the speaker changes<br/>
        /// - `every_paragraph`: Show speaker label on every paragraph<br/>
        /// Default Value: changes
        /// </param>
        /// <param name="includeMarkers">
        /// Include markers in the transcript.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="timecodes">
        /// Timecode options. When provided, timecodes are included in<br/>
        /// the output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportTranscriptRequest(
            global::System.Guid projectId,
            global::Descript.ExportTranscriptRequestFormat format,
            string? compositionId,
            global::Descript.ExportTranscriptRequestIncludeSpeakerLabels? includeSpeakerLabels,
            bool? includeMarkers,
            global::Descript.ExportTranscriptRequestTimecodes? timecodes)
        {
            this.ProjectId = projectId;
            this.CompositionId = compositionId;
            this.Format = format;
            this.IncludeSpeakerLabels = includeSpeakerLabels;
            this.IncludeMarkers = includeMarkers;
            this.Timecodes = timecodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportTranscriptRequest" /> class.
        /// </summary>
        public ExportTranscriptRequest()
        {
        }

    }
}