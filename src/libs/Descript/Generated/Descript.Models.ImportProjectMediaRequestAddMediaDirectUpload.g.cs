
#nullable enable

namespace Descript
{
    /// <summary>
    /// Upload a file directly to Descript. The API returns a signed upload URL<br/>
    /// in the response. PUT your file to that URL, then the import job will<br/>
    /// process it automatically.
    /// </summary>
    public sealed partial class ImportProjectMediaRequestAddMediaDirectUpload
    {
        /// <summary>
        /// MIME type of the file (e.g., "video/mp4", "audio/wav")<br/>
        /// Example: video/mp4
        /// </summary>
        /// <example>video/mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// File size in bytes<br/>
        /// Example: 52428800
        /// </summary>
        /// <example>52428800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FileSize { get; set; }

        /// <summary>
        /// ISO 639-1 language code for transcription (e.g., "en", "es", "fr").<br/>
        /// If not specified, language is auto-detected from the audio.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddMediaDirectUpload" /> class.
        /// </summary>
        /// <param name="contentType">
        /// MIME type of the file (e.g., "video/mp4", "audio/wav")<br/>
        /// Example: video/mp4
        /// </param>
        /// <param name="fileSize">
        /// File size in bytes<br/>
        /// Example: 52428800
        /// </param>
        /// <param name="language">
        /// ISO 639-1 language code for transcription (e.g., "en", "es", "fr").<br/>
        /// If not specified, language is auto-detected from the audio.<br/>
        /// Example: en
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportProjectMediaRequestAddMediaDirectUpload(
            string contentType,
            int fileSize,
            string? language)
        {
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.FileSize = fileSize;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddMediaDirectUpload" /> class.
        /// </summary>
        public ImportProjectMediaRequestAddMediaDirectUpload()
        {
        }

    }
}