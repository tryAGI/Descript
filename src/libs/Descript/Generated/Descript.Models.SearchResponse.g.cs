
#nullable enable

namespace Descript
{
    /// <summary>
    /// Ranked search results.
    /// </summary>
    public sealed partial class SearchResponse
    {
        /// <summary>
        /// Search results ranked by relevance, best match first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Descript.OneOf<global::Descript.SearchResponseResultProjectSearchResult, global::Descript.SearchResponseResultMediaSearchResult, global::Descript.SearchResponseResultLayoutPackSearchResult, global::Descript.SearchResponseResultProjectFolderSearchResult, global::Descript.SearchResponseResultMediaLibraryFolderSearchResult>> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// Search results ranked by relevance, best match first.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResponse(
            global::System.Collections.Generic.IList<global::Descript.OneOf<global::Descript.SearchResponseResultProjectSearchResult, global::Descript.SearchResponseResultMediaSearchResult, global::Descript.SearchResponseResultLayoutPackSearchResult, global::Descript.SearchResponseResultProjectFolderSearchResult, global::Descript.SearchResponseResultMediaLibraryFolderSearchResult>> results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        public SearchResponse()
        {
        }

    }
}