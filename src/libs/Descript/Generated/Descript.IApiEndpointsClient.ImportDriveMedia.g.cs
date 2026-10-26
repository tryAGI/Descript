#nullable enable

namespace Descript
{
    public partial interface IApiEndpointsClient
    {
        /// <summary>
        /// Import media to drive library<br/>
        /// Import media files into the drive media library (shared workspace-level media collection).<br/>
        /// Unlike project media import, this endpoint adds files to the drive's shared media library<br/>
        /// rather than to a specific project. Files can optionally be placed in a folder.<br/>
        /// ### Media URL requirements<br/>
        /// - URLs must be accessible by Descript servers<br/>
        /// - URLs must support HTTP Range requests<br/>
        /// - Recommended to sign URLs for 12-48 hours to reduce chance of failure<br/>
        /// - [Supported file types](https://help.descript.com/add-and-manage-media/supported-file-types)<br/>
        /// ### Direct file upload<br/>
        /// Instead of providing a URL, you can upload files directly by specifying `content_type` and `file_size` for a media item. The response will include a signed `upload_url` for each direct upload item. PUT the file bytes to that URL, and the import job will process it automatically. See the [Direct file upload](#tag/Direct-file-upload) guide for a full walkthrough.<br/>
        /// ### Async Operations<br/>
        /// Imports run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint.<br/>
        /// ### Dynamic webhook<br/>
        /// If `callback_url` is provided, Descript will POST the job status to that URL when the job finishes (successfully or not).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Descript.DriveMediaImportResponse> ImportDriveMediaAsync(

            global::Descript.DriveMediaImportRequest request,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import media to drive library<br/>
        /// Import media files into the drive media library (shared workspace-level media collection).<br/>
        /// Unlike project media import, this endpoint adds files to the drive's shared media library<br/>
        /// rather than to a specific project. Files can optionally be placed in a folder.<br/>
        /// ### Media URL requirements<br/>
        /// - URLs must be accessible by Descript servers<br/>
        /// - URLs must support HTTP Range requests<br/>
        /// - Recommended to sign URLs for 12-48 hours to reduce chance of failure<br/>
        /// - [Supported file types](https://help.descript.com/add-and-manage-media/supported-file-types)<br/>
        /// ### Direct file upload<br/>
        /// Instead of providing a URL, you can upload files directly by specifying `content_type` and `file_size` for a media item. The response will include a signed `upload_url` for each direct upload item. PUT the file bytes to that URL, and the import job will process it automatically. See the [Direct file upload](#tag/Direct-file-upload) guide for a full walkthrough.<br/>
        /// ### Async Operations<br/>
        /// Imports run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint.<br/>
        /// ### Dynamic webhook<br/>
        /// If `callback_url` is provided, Descript will POST the job status to that URL when the job finishes (successfully or not).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Descript.AutoSDKHttpResponse<global::Descript.DriveMediaImportResponse>> ImportDriveMediaAsResponseAsync(

            global::Descript.DriveMediaImportRequest request,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import media to drive library<br/>
        /// Import media files into the drive media library (shared workspace-level media collection).<br/>
        /// Unlike project media import, this endpoint adds files to the drive's shared media library<br/>
        /// rather than to a specific project. Files can optionally be placed in a folder.<br/>
        /// ### Media URL requirements<br/>
        /// - URLs must be accessible by Descript servers<br/>
        /// - URLs must support HTTP Range requests<br/>
        /// - Recommended to sign URLs for 12-48 hours to reduce chance of failure<br/>
        /// - [Supported file types](https://help.descript.com/add-and-manage-media/supported-file-types)<br/>
        /// ### Direct file upload<br/>
        /// Instead of providing a URL, you can upload files directly by specifying `content_type` and `file_size` for a media item. The response will include a signed `upload_url` for each direct upload item. PUT the file bytes to that URL, and the import job will process it automatically. See the [Direct file upload](#tag/Direct-file-upload) guide for a full walkthrough.<br/>
        /// ### Async Operations<br/>
        /// Imports run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint.<br/>
        /// ### Dynamic webhook<br/>
        /// If `callback_url` is provided, Descript will POST the job status to that URL when the job finishes (successfully or not).
        /// </summary>
        /// <param name="folderId">
        /// Target drive media folder ID (UUID) or "root" for the root folder. If not provided, defaults to root.
        /// </param>
        /// <param name="addMedia">
        /// Map of media reference IDs to their import definitions. Key is the display name<br/>
        /// or path (e.g. "video.mp4" or "Folder/SubFolder/video.mp4"). Paths with forward<br/>
        /// slashes create nested folders automatically.
        /// </param>
        /// <param name="callbackUrl">
        /// Optional callback URL to receive notifications about job status changes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Descript.DriveMediaImportResponse> ImportDriveMediaAsync(
            object addMedia,
            string? folderId = default,
            string? callbackUrl = default,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}