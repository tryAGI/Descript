
#nullable enable

namespace Descript
{
    /// <summary>
    /// A video, audio, or image file in the drive media library,<br/>
    /// Brand Studio, or a project.
    /// </summary>
    public sealed partial class SearchResponseResultMediaSearchResult
    {
        /// <summary>
        /// The kind of media: `video`, `audio`, or `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.SearchResponseResultMediaSearchResultTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Descript.SearchResponseResultMediaSearchResultType Type { get; set; }

        /// <summary>
        /// ID of the file. Endpoints that take an `asset_id` accept it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AssetId { get; set; }

        /// <summary>
        /// ID of the project that contains the file. Present<br/>
        /// only when `location` is `project`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// ID of the Brand Studio that contains the file.<br/>
        /// Present only when `location` is `brand_studio`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brand_studio_id")]
        public global::System.Guid? BrandStudioId { get; set; }

        /// <summary>
        /// File name of the media file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Where the file lives: `media_library` in the drive<br/>
        /// media library, `project` inside a project, or<br/>
        /// `brand_studio` in Brand Studio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.SearchResponseResultMediaSearchResultLocationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Descript.SearchResponseResultMediaSearchResultLocation Location { get; set; }

        /// <summary>
        /// Owner of the search result. Omitted when the owner is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::Descript.SearchOwner? Owner { get; set; }

        /// <summary>
        /// When the file was last modified. This is the<br/>
        /// field `updated_after` and `updated_before` filter<br/>
        /// on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Playback length of the file in seconds. Omitted<br/>
        /// for images and for files with no duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseResultMediaSearchResult" /> class.
        /// </summary>
        /// <param name="type">
        /// The kind of media: `video`, `audio`, or `image`.
        /// </param>
        /// <param name="assetId">
        /// ID of the file. Endpoints that take an `asset_id` accept it.
        /// </param>
        /// <param name="name">
        /// File name of the media file.
        /// </param>
        /// <param name="location">
        /// Where the file lives: `media_library` in the drive<br/>
        /// media library, `project` inside a project, or<br/>
        /// `brand_studio` in Brand Studio.
        /// </param>
        /// <param name="updatedAt">
        /// When the file was last modified. This is the<br/>
        /// field `updated_after` and `updated_before` filter<br/>
        /// on.
        /// </param>
        /// <param name="projectId">
        /// ID of the project that contains the file. Present<br/>
        /// only when `location` is `project`.
        /// </param>
        /// <param name="brandStudioId">
        /// ID of the Brand Studio that contains the file.<br/>
        /// Present only when `location` is `brand_studio`.
        /// </param>
        /// <param name="owner">
        /// Owner of the search result. Omitted when the owner is unavailable.
        /// </param>
        /// <param name="duration">
        /// Playback length of the file in seconds. Omitted<br/>
        /// for images and for files with no duration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResponseResultMediaSearchResult(
            global::Descript.SearchResponseResultMediaSearchResultType type,
            global::System.Guid assetId,
            string name,
            global::Descript.SearchResponseResultMediaSearchResultLocation location,
            global::System.DateTime updatedAt,
            global::System.Guid? projectId,
            global::System.Guid? brandStudioId,
            global::Descript.SearchOwner? owner,
            double? duration)
        {
            this.Type = type;
            this.AssetId = assetId;
            this.ProjectId = projectId;
            this.BrandStudioId = brandStudioId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Location = location;
            this.Owner = owner;
            this.UpdatedAt = updatedAt;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseResultMediaSearchResult" /> class.
        /// </summary>
        public SearchResponseResultMediaSearchResult()
        {
        }

    }
}