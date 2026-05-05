#nullable enable

namespace Descript
{
    public partial interface IApiEndpointsClient
    {
        /// <summary>
        /// List projects<br/>
        /// List projects accessible to the authenticated user within a drive.<br/>
        /// The drive is determined from the access token.<br/>
        /// Results are paginated. Use the `cursor` from the response `pagination.next_cursor`<br/>
        /// to fetch subsequent pages.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="updatedAfter"></param>
        /// <param name="updatedBefore"></param>
        /// <param name="sort">
        /// Default Value: created_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Descript.ListProjectsResponse> ListProjectsAsync(
            string? name = default,
            string? createdBy = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            global::System.DateTime? updatedAfter = default,
            global::System.DateTime? updatedBefore = default,
            global::Descript.ListProjectsSort? sort = default,
            global::Descript.ListProjectsDirection? direction = default,
            string? cursor = default,
            int? limit = default,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List projects<br/>
        /// List projects accessible to the authenticated user within a drive.<br/>
        /// The drive is determined from the access token.<br/>
        /// Results are paginated. Use the `cursor` from the response `pagination.next_cursor`<br/>
        /// to fetch subsequent pages.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="updatedAfter"></param>
        /// <param name="updatedBefore"></param>
        /// <param name="sort">
        /// Default Value: created_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Descript.AutoSDKHttpResponse<global::Descript.ListProjectsResponse>> ListProjectsAsResponseAsync(
            string? name = default,
            string? createdBy = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            global::System.DateTime? updatedAfter = default,
            global::System.DateTime? updatedBefore = default,
            global::Descript.ListProjectsSort? sort = default,
            global::Descript.ListProjectsDirection? direction = default,
            string? cursor = default,
            int? limit = default,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}