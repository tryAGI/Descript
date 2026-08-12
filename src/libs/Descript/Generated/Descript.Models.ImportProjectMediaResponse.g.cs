
#nullable enable

namespace Descript
{
    /// <summary>
    /// Response returned when creating an import job
    /// </summary>
    public sealed partial class ImportProjectMediaResponse
    {
        /// <summary>
        /// Unique identifier for the job<br/>
        /// Example: 6dc3f30a-58c2-4174-96a6-dc18cf3c7776
        /// </summary>
        /// <example>6dc3f30a-58c2-4174-96a6-dc18cf3c7776</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        /// Drive ID where the project is located<br/>
        /// Example: c9c5c47e-158a-49f7-846b-4f6ee2a229a2
        /// </summary>
        /// <example>c9c5c47e-158a-49f7-846b-4f6ee2a229a2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("drive_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DriveId { get; set; }

        /// <summary>
        /// Human-readable name of the connected drive (workspace)<br/>
        /// Example: My Team Workspace
        /// </summary>
        /// <example>My Team Workspace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("drive_name")]
        public string? DriveName { get; set; }

        /// <summary>
        /// Project ID (newly created or existing)<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// URL to access the project in Descript web app<br/>
        /// Example: https://web.descript.com/9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>https://web.descript.com/9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectUrl { get; set; }

        /// <summary>
        /// Signed upload URLs for each direct upload media item. Only present when the request<br/>
        /// includes direct upload references. PUT the file contents to the `upload_url` with<br/>
        /// `Content-Type: application/octet-stream`. The import job will automatically detect<br/>
        /// the upload and process the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_urls")]
        public global::System.Collections.Generic.Dictionary<string, global::Descript.ImportProjectMediaResponseUploadUrls2>? UploadUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Unique identifier for the job<br/>
        /// Example: 6dc3f30a-58c2-4174-96a6-dc18cf3c7776
        /// </param>
        /// <param name="driveId">
        /// Drive ID where the project is located<br/>
        /// Example: c9c5c47e-158a-49f7-846b-4f6ee2a229a2
        /// </param>
        /// <param name="projectId">
        /// Project ID (newly created or existing)<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="projectUrl">
        /// URL to access the project in Descript web app<br/>
        /// Example: https://web.descript.com/9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="driveName">
        /// Human-readable name of the connected drive (workspace)<br/>
        /// Example: My Team Workspace
        /// </param>
        /// <param name="uploadUrls">
        /// Signed upload URLs for each direct upload media item. Only present when the request<br/>
        /// includes direct upload references. PUT the file contents to the `upload_url` with<br/>
        /// `Content-Type: application/octet-stream`. The import job will automatically detect<br/>
        /// the upload and process the file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportProjectMediaResponse(
            global::System.Guid jobId,
            global::System.Guid driveId,
            global::System.Guid projectId,
            string projectUrl,
            string? driveName,
            global::System.Collections.Generic.Dictionary<string, global::Descript.ImportProjectMediaResponseUploadUrls2>? uploadUrls)
        {
            this.JobId = jobId;
            this.DriveId = driveId;
            this.DriveName = driveName;
            this.ProjectId = projectId;
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
            this.UploadUrls = uploadUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaResponse" /> class.
        /// </summary>
        public ImportProjectMediaResponse()
        {
        }

    }
}