
#nullable enable

namespace Descript
{
    /// <summary>
    /// Progress information for the workflow (only present when job_state is running)
    /// </summary>
    public sealed partial class PublishJobStatusProgress
    {
        /// <summary>
        /// Human-readable label describing the current action<br/>
        /// Example: Exporting composition...
        /// </summary>
        /// <example>Exporting composition...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Percentage of the workflow that has been completed<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent")]
        public int? Percent { get; set; }

        /// <summary>
        /// When the progress was last updated<br/>
        /// Example: 2025-11-18T10:32:00Z
        /// </summary>
        /// <example>2025-11-18T10:32:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_update_at")]
        public global::System.DateTime? LastUpdateAt { get; set; }

        /// <summary>
        /// Composition being published (present when known)<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </summary>
        /// <example>39677a40-1c43-4c36-8449-46cfbc4de2b5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_id")]
        public string? CompositionId { get; set; }

        /// <summary>
        /// Share URL when available before the job completes<br/>
        /// Example: https://share.descript.com/view/abc123
        /// </summary>
        /// <example>https://share.descript.com/view/abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_url")]
        public string? ShareUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishJobStatusProgress" /> class.
        /// </summary>
        /// <param name="label">
        /// Human-readable label describing the current action<br/>
        /// Example: Exporting composition...
        /// </param>
        /// <param name="percent">
        /// Percentage of the workflow that has been completed<br/>
        /// Example: 50
        /// </param>
        /// <param name="lastUpdateAt">
        /// When the progress was last updated<br/>
        /// Example: 2025-11-18T10:32:00Z
        /// </param>
        /// <param name="compositionId">
        /// Composition being published (present when known)<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </param>
        /// <param name="shareUrl">
        /// Share URL when available before the job completes<br/>
        /// Example: https://share.descript.com/view/abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishJobStatusProgress(
            string label,
            int? percent,
            global::System.DateTime? lastUpdateAt,
            string? compositionId,
            string? shareUrl)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Percent = percent;
            this.LastUpdateAt = lastUpdateAt;
            this.CompositionId = compositionId;
            this.ShareUrl = shareUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishJobStatusProgress" /> class.
        /// </summary>
        public PublishJobStatusProgress()
        {
        }
    }
}