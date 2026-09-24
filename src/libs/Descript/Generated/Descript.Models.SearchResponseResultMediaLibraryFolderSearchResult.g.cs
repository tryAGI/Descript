
#nullable enable

namespace Descript
{
    /// <summary>
    /// A folder in the drive media library.
    /// </summary>
    public sealed partial class SearchResponseResultMediaLibraryFolderSearchResult
    {
        /// <summary>
        /// Always `media_library_folder`. The folder holds<br/>
        /// media library files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.SearchResponseResultMediaLibraryFolderSearchResultTypeJsonConverter))]
        public global::Descript.SearchResponseResultMediaLibraryFolderSearchResultType Type { get; set; }

        /// <summary>
        /// ID of the folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FolderId { get; set; }

        /// <summary>
        /// Name of the folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Always `media_library` for a media-library folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.SearchResponseResultMediaLibraryFolderSearchResultLocationJsonConverter))]
        public global::Descript.SearchResponseResultMediaLibraryFolderSearchResultLocation Location { get; set; }

        /// <summary>
        /// Link that opens this media library folder in<br/>
        /// Descript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Owner of the search result. Omitted when the owner is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::Descript.SearchOwner? Owner { get; set; }

        /// <summary>
        /// When the folder was last modified. This is the<br/>
        /// field `updated_after` and `updated_before` filter<br/>
        /// on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseResultMediaLibraryFolderSearchResult" /> class.
        /// </summary>
        /// <param name="folderId">
        /// ID of the folder.
        /// </param>
        /// <param name="name">
        /// Name of the folder.
        /// </param>
        /// <param name="url">
        /// Link that opens this media library folder in<br/>
        /// Descript.
        /// </param>
        /// <param name="updatedAt">
        /// When the folder was last modified. This is the<br/>
        /// field `updated_after` and `updated_before` filter<br/>
        /// on.
        /// </param>
        /// <param name="type">
        /// Always `media_library_folder`. The folder holds<br/>
        /// media library files.
        /// </param>
        /// <param name="location">
        /// Always `media_library` for a media-library folder.
        /// </param>
        /// <param name="owner">
        /// Owner of the search result. Omitted when the owner is unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResponseResultMediaLibraryFolderSearchResult(
            global::System.Guid folderId,
            string name,
            string url,
            global::System.DateTime updatedAt,
            global::Descript.SearchResponseResultMediaLibraryFolderSearchResultType type,
            global::Descript.SearchResponseResultMediaLibraryFolderSearchResultLocation location,
            global::Descript.SearchOwner? owner)
        {
            this.Type = type;
            this.FolderId = folderId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Location = location;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Owner = owner;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseResultMediaLibraryFolderSearchResult" /> class.
        /// </summary>
        public SearchResponseResultMediaLibraryFolderSearchResult()
        {
        }

    }
}