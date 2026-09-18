
#nullable enable

namespace Descript
{
    /// <summary>
    /// A layout pack matched.
    /// </summary>
    public sealed partial class SearchResponseResultLayoutPackSearchResult
    {
        /// <summary>
        /// Always `layout_pack` for a layout pack result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.SearchResponseResultLayoutPackSearchResultTypeJsonConverter))]
        public global::Descript.SearchResponseResultLayoutPackSearchResultType Type { get; set; }

        /// <summary>
        /// ID of the layout pack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Name of the layout pack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Owner of the search result. Omitted when the owner is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::Descript.SearchOwner? Owner { get; set; }

        /// <summary>
        /// When the layout pack was last modified. This is<br/>
        /// the field `updated_after` and `updated_before`<br/>
        /// filter on.
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
        /// Initializes a new instance of the <see cref="SearchResponseResultLayoutPackSearchResult" /> class.
        /// </summary>
        /// <param name="projectId">
        /// ID of the layout pack.
        /// </param>
        /// <param name="name">
        /// Name of the layout pack.
        /// </param>
        /// <param name="updatedAt">
        /// When the layout pack was last modified. This is<br/>
        /// the field `updated_after` and `updated_before`<br/>
        /// filter on.
        /// </param>
        /// <param name="type">
        /// Always `layout_pack` for a layout pack result.
        /// </param>
        /// <param name="owner">
        /// Owner of the search result. Omitted when the owner is unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResponseResultLayoutPackSearchResult(
            global::System.Guid projectId,
            string name,
            global::System.DateTime updatedAt,
            global::Descript.SearchResponseResultLayoutPackSearchResultType type,
            global::Descript.SearchOwner? owner)
        {
            this.Type = type;
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseResultLayoutPackSearchResult" /> class.
        /// </summary>
        public SearchResponseResultLayoutPackSearchResult()
        {
        }

    }
}