
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DriveMediaImportJobStatusResultVariant1MediaStatus2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.DriveMediaImportJobStatusResultVariant1MediaStatusStatusJsonConverter))]
        public global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatusStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportJobStatusResultVariant1MediaStatus2" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="errorMessage"></param>
        /// <param name="durationSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DriveMediaImportJobStatusResultVariant1MediaStatus2(
            global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatusStatus? status,
            string? errorMessage,
            double? durationSeconds)
        {
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.DurationSeconds = durationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportJobStatusResultVariant1MediaStatus2" /> class.
        /// </summary>
        public DriveMediaImportJobStatusResultVariant1MediaStatus2()
        {
        }

    }
}