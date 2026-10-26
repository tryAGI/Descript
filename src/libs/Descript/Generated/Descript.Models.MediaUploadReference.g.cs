
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MediaUploadReference
    {
        /// <summary>
        /// MIME type of the file to upload (e.g. "video/mp4").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// File size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FileSize { get; set; }

        /// <summary>
        /// ISO 639-1 language code for transcription (e.g., "en", "es").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaUploadReference" /> class.
        /// </summary>
        /// <param name="contentType">
        /// MIME type of the file to upload (e.g. "video/mp4").
        /// </param>
        /// <param name="fileSize">
        /// File size in bytes.
        /// </param>
        /// <param name="language">
        /// ISO 639-1 language code for transcription (e.g., "en", "es").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaUploadReference(
            string contentType,
            long fileSize,
            string? language)
        {
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.FileSize = fileSize;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaUploadReference" /> class.
        /// </summary>
        public MediaUploadReference()
        {
        }

    }
}