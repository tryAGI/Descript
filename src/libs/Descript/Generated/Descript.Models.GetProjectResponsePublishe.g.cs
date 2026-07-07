
#nullable enable

namespace Descript
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponsePublishe
    {
        /// <summary>
        /// URL of the published share page<br/>
        /// Example: https://share.descript.com/view/abc123
        /// </summary>
        /// <example>https://share.descript.com/view/abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShareUrl { get; set; }

        /// <summary>
        /// ID of the composition that was published
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CompositionId { get; set; }

        /// <summary>
        /// Access level of the published share page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.GetProjectResponsePublisheAccessLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Descript.GetProjectResponsePublisheAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Media type of the published output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.GetProjectResponsePublisheMediaTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Descript.GetProjectResponsePublisheMediaType MediaType { get; set; }

        /// <summary>
        /// When the publish was created (ISO 8601)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishedAt { get; set; }

        /// <summary>
        /// When the publish was last updated (ISO 8601)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Name of the published share page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponsePublishe" /> class.
        /// </summary>
        /// <param name="shareUrl">
        /// URL of the published share page<br/>
        /// Example: https://share.descript.com/view/abc123
        /// </param>
        /// <param name="compositionId">
        /// ID of the composition that was published
        /// </param>
        /// <param name="accessLevel">
        /// Access level of the published share page
        /// </param>
        /// <param name="mediaType">
        /// Media type of the published output
        /// </param>
        /// <param name="publishedAt">
        /// When the publish was created (ISO 8601)
        /// </param>
        /// <param name="updatedAt">
        /// When the publish was last updated (ISO 8601)
        /// </param>
        /// <param name="name">
        /// Name of the published share page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponsePublishe(
            string shareUrl,
            global::System.Guid compositionId,
            global::Descript.GetProjectResponsePublisheAccessLevel accessLevel,
            global::Descript.GetProjectResponsePublisheMediaType mediaType,
            global::System.DateTime publishedAt,
            global::System.DateTime updatedAt,
            string name)
        {
            this.ShareUrl = shareUrl ?? throw new global::System.ArgumentNullException(nameof(shareUrl));
            this.CompositionId = compositionId;
            this.AccessLevel = accessLevel;
            this.MediaType = mediaType;
            this.PublishedAt = publishedAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponsePublishe" /> class.
        /// </summary>
        public GetProjectResponsePublishe()
        {
        }

    }
}