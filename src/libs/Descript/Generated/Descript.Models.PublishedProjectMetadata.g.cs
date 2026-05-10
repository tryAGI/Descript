
#nullable enable

namespace Descript
{
    /// <summary>
    /// Metadata for a successfully published Descript project
    /// </summary>
    public sealed partial class PublishedProjectMetadata
    {
        /// <summary>
        /// A time-limited signed URL for downloading the original published media file. See download_url_expires_at for expiration date.<br/>
        /// Example: https://storage.googleapis.com/bucket/file.mp4?X-Goog-Signature=...
        /// </summary>
        /// <example>https://storage.googleapis.com/bucket/file.mp4?X-Goog-Signature=...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// ISO 8601 timestamp indicating when the download_url expires. Present when download_url is present.<br/>
        /// Example: 2025-01-16T10:30:00.000Z
        /// </summary>
        /// <example>2025-01-16T10:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url_expires_at")]
        public global::System.DateTime? DownloadUrlExpiresAt { get; set; }

        /// <summary>
        /// The unique identifier of the source Descript project<br/>
        /// Example: 12345678-1234-5678-1234-567812345678
        /// </summary>
        /// <example>12345678-1234-5678-1234-567812345678</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// The type of published project<br/>
        /// Example: video
        /// </summary>
        /// <example>video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("publish_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.PublishedProjectMetadataPublishTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Descript.PublishedProjectMetadataPublishType PublishType { get; set; }

        /// <summary>
        /// The access permission level for this published project<br/>
        /// Example: unlisted
        /// </summary>
        /// <example>unlisted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.PublishedProjectMetadataPrivacyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Descript.PublishedProjectMetadataPrivacy Privacy { get; set; }

        /// <summary>
        /// Detailed metadata about the published project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Descript.PublishedProjectMetadataMetadata Metadata { get; set; }

        /// <summary>
        /// Full VTT-formatted subtitle/caption content for the published project<br/>
        /// Example: WEBVTT\n\n00:00:00.000 --&gt; 00:00:02.000\nWelcome to my video
        /// </summary>
        /// <example>WEBVTT\n\n00:00:00.000 --&gt; 00:00:02.000\nWelcome to my video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subtitles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectMetadata" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The unique identifier of the source Descript project<br/>
        /// Example: 12345678-1234-5678-1234-567812345678
        /// </param>
        /// <param name="publishType">
        /// The type of published project<br/>
        /// Example: video
        /// </param>
        /// <param name="privacy">
        /// The access permission level for this published project<br/>
        /// Example: unlisted
        /// </param>
        /// <param name="metadata">
        /// Detailed metadata about the published project
        /// </param>
        /// <param name="subtitles">
        /// Full VTT-formatted subtitle/caption content for the published project<br/>
        /// Example: WEBVTT\n\n00:00:00.000 --&gt; 00:00:02.000\nWelcome to my video
        /// </param>
        /// <param name="downloadUrl">
        /// A time-limited signed URL for downloading the original published media file. See download_url_expires_at for expiration date.<br/>
        /// Example: https://storage.googleapis.com/bucket/file.mp4?X-Goog-Signature=...
        /// </param>
        /// <param name="downloadUrlExpiresAt">
        /// ISO 8601 timestamp indicating when the download_url expires. Present when download_url is present.<br/>
        /// Example: 2025-01-16T10:30:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishedProjectMetadata(
            global::System.Guid projectId,
            global::Descript.PublishedProjectMetadataPublishType publishType,
            global::Descript.PublishedProjectMetadataPrivacy privacy,
            global::Descript.PublishedProjectMetadataMetadata metadata,
            string subtitles,
            string? downloadUrl,
            global::System.DateTime? downloadUrlExpiresAt)
        {
            this.DownloadUrl = downloadUrl;
            this.DownloadUrlExpiresAt = downloadUrlExpiresAt;
            this.ProjectId = projectId;
            this.PublishType = publishType;
            this.Privacy = privacy;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Subtitles = subtitles ?? throw new global::System.ArgumentNullException(nameof(subtitles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectMetadata" /> class.
        /// </summary>
        public PublishedProjectMetadata()
        {
        }

    }
}