
#nullable enable

namespace Descript
{
    /// <summary>
    /// Request to publish a project composition.
    /// </summary>
    public sealed partial class PublishJobRequest
    {
        /// <summary>
        /// The ID of the project to publish.<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Composition to publish. If omitted, the first composition in the project is used.<br/>
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
        /// Media type of the published output. Defaults to `Video` when omitted.<br/>
        /// If the target composition has no video content:<br/>
        /// - omitting `media_type` publishes it as `Audio`<br/>
        ///   (the completed job result reports `media_type: Audio`),<br/>
        /// - explicitly requesting `Video` is rejected with a 422.<br/>
        /// Default Value: Video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.PublishJobRequestMediaTypeJsonConverter))]
        public global::Descript.PublishJobRequestMediaType? MediaType { get; set; }

        /// <summary>
        /// Resolution for the published output. Only applicable when media_type is Video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.PublishJobRequestResolutionJsonConverter))]
        public global::Descript.PublishJobRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Optional webhook URL to call when the job completes or fails.<br/>
        /// Descript will POST the job status (same format as [GET /jobs/{job_id}](#operation/getJob)) to this URL.<br/>
        /// Example: https://example.com/webhooks/descript/job_callback
        /// </summary>
        /// <example>https://example.com/webhooks/descript/job_callback</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Desired access level for the published share page.<br/>
        /// If omitted, the drive's configured default is used.<br/>
        /// Returns 403 if the requested level is not permitted by the drive's publish settings<br/>
        /// (e.g. requesting `public` when search engine indexing is disabled).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.PublishJobRequestAccessLevelJsonConverter))]
        public global::Descript.PublishJobRequestAccessLevel? AccessLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishJobRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project to publish.<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="compositionId">
        /// Composition to publish. If omitted, the first composition in the project is used.<br/>
        /// Accepts any of the following formats:<br/>
        /// - A full composition UUID (e.g. `39677a40-1c43-4c36-8449-46cfbc4de2b5`)<br/>
        /// - A 5-character short ID from a Descript URL (e.g. `39677`)<br/>
        /// - A full Descript project URL (e.g. `https://web.descript.com/{project_id}/39677`)<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </param>
        /// <param name="mediaType">
        /// Media type of the published output. Defaults to `Video` when omitted.<br/>
        /// If the target composition has no video content:<br/>
        /// - omitting `media_type` publishes it as `Audio`<br/>
        ///   (the completed job result reports `media_type: Audio`),<br/>
        /// - explicitly requesting `Video` is rejected with a 422.<br/>
        /// Default Value: Video
        /// </param>
        /// <param name="resolution">
        /// Resolution for the published output. Only applicable when media_type is Video.
        /// </param>
        /// <param name="callbackUrl">
        /// Optional webhook URL to call when the job completes or fails.<br/>
        /// Descript will POST the job status (same format as [GET /jobs/{job_id}](#operation/getJob)) to this URL.<br/>
        /// Example: https://example.com/webhooks/descript/job_callback
        /// </param>
        /// <param name="accessLevel">
        /// Desired access level for the published share page.<br/>
        /// If omitted, the drive's configured default is used.<br/>
        /// Returns 403 if the requested level is not permitted by the drive's publish settings<br/>
        /// (e.g. requesting `public` when search engine indexing is disabled).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishJobRequest(
            global::System.Guid projectId,
            string? compositionId,
            global::Descript.PublishJobRequestMediaType? mediaType,
            global::Descript.PublishJobRequestResolution? resolution,
            string? callbackUrl,
            global::Descript.PublishJobRequestAccessLevel? accessLevel)
        {
            this.ProjectId = projectId;
            this.CompositionId = compositionId;
            this.MediaType = mediaType;
            this.Resolution = resolution;
            this.CallbackUrl = callbackUrl;
            this.AccessLevel = accessLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishJobRequest" /> class.
        /// </summary>
        public PublishJobRequest()
        {
        }

    }
}