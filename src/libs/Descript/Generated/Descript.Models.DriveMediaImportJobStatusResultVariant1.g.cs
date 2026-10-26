
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DriveMediaImportJobStatusResultVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.DriveMediaImportJobStatusResultVariant1StatusJsonConverter))]
        public global::Descript.DriveMediaImportJobStatusResultVariant1Status? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_status")]
        public global::System.Collections.Generic.Dictionary<string, global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatus2>? MediaStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_seconds_used")]
        public double? MediaSecondsUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportJobStatusResultVariant1" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="mediaStatus"></param>
        /// <param name="mediaSecondsUsed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DriveMediaImportJobStatusResultVariant1(
            global::Descript.DriveMediaImportJobStatusResultVariant1Status? status,
            global::System.Collections.Generic.Dictionary<string, global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatus2>? mediaStatus,
            double? mediaSecondsUsed)
        {
            this.Status = status;
            this.MediaStatus = mediaStatus;
            this.MediaSecondsUsed = mediaSecondsUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportJobStatusResultVariant1" /> class.
        /// </summary>
        public DriveMediaImportJobStatusResultVariant1()
        {
        }

    }
}