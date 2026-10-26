
#nullable enable

namespace Descript
{
    /// <summary>
    /// Progress information for the workflow (only present when job_state is running)
    /// </summary>
    public sealed partial class DriveMediaImportJobStatusProgress
    {
        /// <summary>
        /// Human-readable label describing the current action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Percentage of the workflow that has been completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent")]
        public int? Percent { get; set; }

        /// <summary>
        /// When the progress was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_update_at")]
        public global::System.DateTime? LastUpdateAt { get; set; }

        /// <summary>
        /// Whether the job is still waiting for direct uploads to finish
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waiting_for_uploads")]
        public bool? WaitingForUploads { get; set; }

        /// <summary>
        /// Number of direct upload files received so far
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_artifacts")]
        public int? UploadedArtifacts { get; set; }

        /// <summary>
        /// Total number of direct upload files expected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_artifacts")]
        public int? TotalArtifacts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportJobStatusProgress" /> class.
        /// </summary>
        /// <param name="label">
        /// Human-readable label describing the current action
        /// </param>
        /// <param name="percent">
        /// Percentage of the workflow that has been completed
        /// </param>
        /// <param name="lastUpdateAt">
        /// When the progress was last updated
        /// </param>
        /// <param name="waitingForUploads">
        /// Whether the job is still waiting for direct uploads to finish
        /// </param>
        /// <param name="uploadedArtifacts">
        /// Number of direct upload files received so far
        /// </param>
        /// <param name="totalArtifacts">
        /// Total number of direct upload files expected
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DriveMediaImportJobStatusProgress(
            string label,
            int? percent,
            global::System.DateTime? lastUpdateAt,
            bool? waitingForUploads,
            int? uploadedArtifacts,
            int? totalArtifacts)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Percent = percent;
            this.LastUpdateAt = lastUpdateAt;
            this.WaitingForUploads = waitingForUploads;
            this.UploadedArtifacts = uploadedArtifacts;
            this.TotalArtifacts = totalArtifacts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportJobStatusProgress" /> class.
        /// </summary>
        public DriveMediaImportJobStatusProgress()
        {
        }

    }
}