
#nullable enable

namespace Descript
{
    /// <summary>
    /// Job status for a drive media import job.
    /// </summary>
    public sealed partial class DriveMediaImportJobStatus
    {
        /// <summary>
        /// The job ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.DriveMediaImportJobStatusJobTypeJsonConverter))]
        public global::Descript.DriveMediaImportJobStatusJobType JobType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.DriveMediaImportJobStatusJobStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Descript.DriveMediaImportJobStatusJobState JobState { get; set; }

        /// <summary>
        /// When the job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the job stopped (only present when job_state is stopped or cancelled).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopped_at")]
        public global::System.DateTime? StoppedAt { get; set; }

        /// <summary>
        /// The drive ID.
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
        /// The target folder ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FolderId { get; set; }

        /// <summary>
        /// Progress information for the workflow (only present when job_state is running)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::Descript.DriveMediaImportJobStatusProgress? Progress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.OneOfJsonConverter<global::Descript.DriveMediaImportJobStatusResultVariant1, global::Descript.DriveMediaImportJobStatusResultVariant2>))]
        public global::Descript.OneOf<global::Descript.DriveMediaImportJobStatusResultVariant1, global::Descript.DriveMediaImportJobStatusResultVariant2>? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportJobStatus" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The job ID.
        /// </param>
        /// <param name="jobState"></param>
        /// <param name="createdAt">
        /// When the job was created.
        /// </param>
        /// <param name="driveId">
        /// The drive ID.
        /// </param>
        /// <param name="folderId">
        /// The target folder ID.
        /// </param>
        /// <param name="jobType"></param>
        /// <param name="stoppedAt">
        /// When the job stopped (only present when job_state is stopped or cancelled).
        /// </param>
        /// <param name="driveName">
        /// Human-readable name of the connected drive (workspace)<br/>
        /// Example: My Team Workspace
        /// </param>
        /// <param name="progress">
        /// Progress information for the workflow (only present when job_state is running)
        /// </param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DriveMediaImportJobStatus(
            string jobId,
            global::Descript.DriveMediaImportJobStatusJobState jobState,
            global::System.DateTime createdAt,
            string driveId,
            string folderId,
            global::Descript.DriveMediaImportJobStatusJobType jobType,
            global::System.DateTime? stoppedAt,
            string? driveName,
            global::Descript.DriveMediaImportJobStatusProgress? progress,
            global::Descript.OneOf<global::Descript.DriveMediaImportJobStatusResultVariant1, global::Descript.DriveMediaImportJobStatusResultVariant2>? result)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.JobType = jobType;
            this.JobState = jobState;
            this.CreatedAt = createdAt;
            this.StoppedAt = stoppedAt;
            this.DriveId = driveId ?? throw new global::System.ArgumentNullException(nameof(driveId));
            this.DriveName = driveName;
            this.FolderId = folderId ?? throw new global::System.ArgumentNullException(nameof(folderId));
            this.Progress = progress;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportJobStatus" /> class.
        /// </summary>
        public DriveMediaImportJobStatus()
        {
        }

    }
}