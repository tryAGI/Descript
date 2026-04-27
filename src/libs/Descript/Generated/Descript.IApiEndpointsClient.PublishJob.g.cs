#nullable enable

namespace Descript
{
    public partial interface IApiEndpointsClient
    {
        /// <summary>
        /// Publish project media<br/>
        /// Publish a project composition to create a shareable link and download the exported file.<br/>
        /// Publishes a specific composition from a project, rendering the output as video or audio<br/>
        /// at the specified resolution. When the job completes successfully the result contains both:<br/>
        /// - `share_url`: a public URL that can be used to view the published content on Descript's share site.<br/>
        /// - `download_url`: a time-limited signed URL to download the exported media file directly,<br/>
        ///   along with `download_url_expires_at` indicating when the link expires.<br/>
        /// ### Republishing<br/>
        /// Publishing the same composition a second time automatically reuses the previous share URL,<br/>
        /// overwriting its content — so bookmarks and links handed out for the first publish keep working.<br/>
        /// Republish matching is keyed on `(project_id, composition_id, media_type)`, so a Video publish<br/>
        /// and an Audio publish of the same composition produce two separate share URLs.<br/>
        /// ### Async Operations<br/>
        /// Publish jobs run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint,<br/>
        /// which returns the `share_url`, `download_url`, and `download_url_expires_at` fields once the job finishes.<br/>
        /// ### Dynamic webhook<br/>
        /// If `callback_url` is provided, Descript will POST the job status to that URL when the job completes or fails.<br/>
        /// The payload will match the format returned by [GET /jobs/{job_id}](#operation/getJob).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Descript.PublishJobResponse> PublishJobAsync(

            global::Descript.PublishJobRequest request,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish project media<br/>
        /// Publish a project composition to create a shareable link and download the exported file.<br/>
        /// Publishes a specific composition from a project, rendering the output as video or audio<br/>
        /// at the specified resolution. When the job completes successfully the result contains both:<br/>
        /// - `share_url`: a public URL that can be used to view the published content on Descript's share site.<br/>
        /// - `download_url`: a time-limited signed URL to download the exported media file directly,<br/>
        ///   along with `download_url_expires_at` indicating when the link expires.<br/>
        /// ### Republishing<br/>
        /// Publishing the same composition a second time automatically reuses the previous share URL,<br/>
        /// overwriting its content — so bookmarks and links handed out for the first publish keep working.<br/>
        /// Republish matching is keyed on `(project_id, composition_id, media_type)`, so a Video publish<br/>
        /// and an Audio publish of the same composition produce two separate share URLs.<br/>
        /// ### Async Operations<br/>
        /// Publish jobs run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint,<br/>
        /// which returns the `share_url`, `download_url`, and `download_url_expires_at` fields once the job finishes.<br/>
        /// ### Dynamic webhook<br/>
        /// If `callback_url` is provided, Descript will POST the job status to that URL when the job completes or fails.<br/>
        /// The payload will match the format returned by [GET /jobs/{job_id}](#operation/getJob).
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project to publish.<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="compositionId">
        /// The ID of the composition within the project to publish.<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </param>
        /// <param name="mediaType">
        /// Media type of the published output.<br/>
        /// Default Value: Video
        /// </param>
        /// <param name="resolution">
        /// Resolution for the published output. Only applicable when media_type is Video.
        /// </param>
        /// <param name="callbackUrl">
        /// Optional webhook URL to call when the job completes or fails.<br/>
        /// Descript will POST the job status (same format as [GET /jobs/{job_id}](#operation/getJob)) to this URL.<br/>
        /// Example: https://example.com/webhooks/descript/job_callback
        /// </param>
        /// <param name="accessLevel">
        /// Desired access level for the published share page.<br/>
        /// If omitted, the drive's configured default is used.<br/>
        /// Returns 403 if the requested level is not permitted by the drive's publish settings<br/>
        /// (e.g. requesting `public` when search engine indexing is disabled).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Descript.PublishJobResponse> PublishJobAsync(
            global::System.Guid projectId,
            global::System.Guid? compositionId = default,
            global::Descript.PublishJobRequestMediaType? mediaType = default,
            global::Descript.PublishJobRequestResolution? resolution = default,
            string? callbackUrl = default,
            global::Descript.PublishJobRequestAccessLevel? accessLevel = default,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}