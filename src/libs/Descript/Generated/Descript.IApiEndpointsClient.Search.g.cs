#nullable enable

namespace Descript
{
    public partial interface IApiEndpointsClient
    {
        /// <summary>
        /// Search a drive<br/>
        /// Search the drive tied to the personal API token. Matches project names,<br/>
        /// folder names, layout pack names, media file names, composition text,<br/>
        /// and transcripts across projects, the drive media library, and Brand<br/>
        /// Studio. Returns up to 100 results ranked by relevance.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="updatedAfter"></param>
        /// <param name="updatedBefore"></param>
        /// <param name="owner"></param>
        /// <param name="type"></param>
        /// <param name="match"></param>
        /// <param name="sort">
        /// Default Value: relevance
        /// </param>
        /// <param name="limit">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Descript.SearchResponse> SearchAsync(
            string query,
            global::System.DateTime? updatedAfter = default,
            global::System.DateTime? updatedBefore = default,
            global::System.Collections.Generic.IList<global::System.Guid>? owner = default,
            global::System.Collections.Generic.IList<global::Descript.SearchTypeItem>? type = default,
            global::System.Collections.Generic.IList<global::Descript.SearchMatchItem>? match = default,
            global::Descript.SearchSort? sort = default,
            int? limit = default,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search a drive<br/>
        /// Search the drive tied to the personal API token. Matches project names,<br/>
        /// folder names, layout pack names, media file names, composition text,<br/>
        /// and transcripts across projects, the drive media library, and Brand<br/>
        /// Studio. Returns up to 100 results ranked by relevance.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="updatedAfter"></param>
        /// <param name="updatedBefore"></param>
        /// <param name="owner"></param>
        /// <param name="type"></param>
        /// <param name="match"></param>
        /// <param name="sort">
        /// Default Value: relevance
        /// </param>
        /// <param name="limit">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Descript.AutoSDKHttpResponse<global::Descript.SearchResponse>> SearchAsResponseAsync(
            string query,
            global::System.DateTime? updatedAfter = default,
            global::System.DateTime? updatedBefore = default,
            global::System.Collections.Generic.IList<global::System.Guid>? owner = default,
            global::System.Collections.Generic.IList<global::Descript.SearchTypeItem>? type = default,
            global::System.Collections.Generic.IList<global::Descript.SearchMatchItem>? match = default,
            global::Descript.SearchSort? sort = default,
            int? limit = default,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}