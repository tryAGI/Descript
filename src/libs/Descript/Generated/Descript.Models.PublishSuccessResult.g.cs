
#nullable enable

namespace Descript
{
    /// <summary>
    /// Result when publish completed successfully
    /// </summary>
    public sealed partial class PublishSuccessResult
    {
        /// <summary>
        /// Indicates successful completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.PublishSuccessResultStatusJsonConverter))]
        public global::Descript.PublishSuccessResultStatus Status { get; set; }

        /// <summary>
        /// Identifier of the published composition<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </summary>
        /// <example>39677a40-1c43-4c36-8449-46cfbc4de2b5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompositionId { get; set; }

        /// <summary>
        /// Public URL to view the published content<br/>
        /// Example: https://share.descript.com/view/abc123
        /// </summary>
        /// <example>https://share.descript.com/view/abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShareUrl { get; set; }

        /// <summary>
        /// The media type the composition was actually published as. For an audio-only composition published with the default Video request, this is Audio.<br/>
        /// Example: Audio
        /// </summary>
        /// <example>Audio</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.PublishSuccessResultMediaTypeJsonConverter))]
        public global::Descript.PublishSuccessResultMediaType? MediaType { get; set; }

        /// <summary>
        /// Time-limited signed URL to download the original published media file. Present when the job completed successfully and signing succeeded.<br/>
        /// Example: https://storage.googleapis.com/bucket/object?X-Goog-Signature=...
        /// </summary>
        /// <example>https://storage.googleapis.com/bucket/object?X-Goog-Signature=...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// ISO 8601 time when download_url expires (if download_url is set)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url_expires_at")]
        public global::System.DateTime? DownloadUrlExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishSuccessResult" /> class.
        /// </summary>
        /// <param name="compositionId">
        /// Identifier of the published composition<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </param>
        /// <param name="shareUrl">
        /// Public URL to view the published content<br/>
        /// Example: https://share.descript.com/view/abc123
        /// </param>
        /// <param name="status">
        /// Indicates successful completion
        /// </param>
        /// <param name="mediaType">
        /// The media type the composition was actually published as. For an audio-only composition published with the default Video request, this is Audio.<br/>
        /// Example: Audio
        /// </param>
        /// <param name="downloadUrl">
        /// Time-limited signed URL to download the original published media file. Present when the job completed successfully and signing succeeded.<br/>
        /// Example: https://storage.googleapis.com/bucket/object?X-Goog-Signature=...
        /// </param>
        /// <param name="downloadUrlExpiresAt">
        /// ISO 8601 time when download_url expires (if download_url is set)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishSuccessResult(
            string compositionId,
            string shareUrl,
            global::Descript.PublishSuccessResultStatus status,
            global::Descript.PublishSuccessResultMediaType? mediaType,
            string? downloadUrl,
            global::System.DateTime? downloadUrlExpiresAt)
        {
            this.Status = status;
            this.CompositionId = compositionId ?? throw new global::System.ArgumentNullException(nameof(compositionId));
            this.ShareUrl = shareUrl ?? throw new global::System.ArgumentNullException(nameof(shareUrl));
            this.MediaType = mediaType;
            this.DownloadUrl = downloadUrl;
            this.DownloadUrlExpiresAt = downloadUrlExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishSuccessResult" /> class.
        /// </summary>
        public PublishSuccessResult()
        {
        }

    }
}