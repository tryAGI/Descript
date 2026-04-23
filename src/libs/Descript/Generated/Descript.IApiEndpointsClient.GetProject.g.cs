#nullable enable

namespace Descript
{
    public partial interface IApiEndpointsClient
    {
        /// <summary>
        /// Get project details<br/>
        /// Get a detailed project summary including all media files and compositions.<br/>
        /// Returns the project's id, name, drive_id, a map of media files (keyed by<br/>
        /// display path) with type and duration, and a list of compositions with id,<br/>
        /// name, duration, and media type.<br/>
        /// Use this to inspect a project's contents before editing or importing media.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Descript.GetProjectResponse> GetProjectAsync(
            global::System.Guid projectId,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}