
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MediaUrlReference
    {
        /// <summary>
        /// URL to download the media file from. Recommended signed for 12+ hours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

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
        /// Initializes a new instance of the <see cref="MediaUrlReference" /> class.
        /// </summary>
        /// <param name="url">
        /// URL to download the media file from. Recommended signed for 12+ hours.
        /// </param>
        /// <param name="language">
        /// ISO 639-1 language code for transcription (e.g., "en", "es").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaUrlReference(
            string url,
            string? language)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaUrlReference" /> class.
        /// </summary>
        public MediaUrlReference()
        {
        }

    }
}