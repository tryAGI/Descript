
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DriveMediaImportResponse
    {
        /// <summary>
        /// The ID of the created import job. Use this to query job status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// The drive ID where the media is being imported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drive_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DriveId { get; set; }

        /// <summary>
        /// Human-readable name of the connected drive (workspace)<br/>
        /// Example: My Team Workspace
        /// </summary>
        /// <example>My Team Workspace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("drive_name")]
        public string? DriveName { get; set; }

        /// <summary>
        /// The target folder ID in the drive media library.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FolderId { get; set; }

        /// <summary>
        /// Signed upload URLs for direct upload media items. Only present when the request includes direct upload references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_urls")]
        public global::System.Collections.Generic.Dictionary<string, global::Descript.DriveMediaImportResponseUploadUrls2>? UploadUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the created import job. Use this to query job status.
        /// </param>
        /// <param name="driveId">
        /// The drive ID where the media is being imported.
        /// </param>
        /// <param name="folderId">
        /// The target folder ID in the drive media library.
        /// </param>
        /// <param name="driveName">
        /// Human-readable name of the connected drive (workspace)<br/>
        /// Example: My Team Workspace
        /// </param>
        /// <param name="uploadUrls">
        /// Signed upload URLs for direct upload media items. Only present when the request includes direct upload references.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DriveMediaImportResponse(
            string jobId,
            string driveId,
            string folderId,
            string? driveName,
            global::System.Collections.Generic.Dictionary<string, global::Descript.DriveMediaImportResponseUploadUrls2>? uploadUrls)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.DriveId = driveId ?? throw new global::System.ArgumentNullException(nameof(driveId));
            this.DriveName = driveName;
            this.FolderId = folderId ?? throw new global::System.ArgumentNullException(nameof(folderId));
            this.UploadUrls = uploadUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportResponse" /> class.
        /// </summary>
        public DriveMediaImportResponse()
        {
        }

    }
}