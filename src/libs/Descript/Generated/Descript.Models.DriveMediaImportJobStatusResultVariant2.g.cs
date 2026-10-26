
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DriveMediaImportJobStatusResultVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.DriveMediaImportJobStatusResultVariant2StatusJsonConverter))]
        public global::Descript.DriveMediaImportJobStatusResultVariant2Status? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportJobStatusResultVariant2" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="errorMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DriveMediaImportJobStatusResultVariant2(
            global::Descript.DriveMediaImportJobStatusResultVariant2Status? status,
            string? errorMessage)
        {
            this.Status = status;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportJobStatusResultVariant2" /> class.
        /// </summary>
        public DriveMediaImportJobStatusResultVariant2()
        {
        }

    }
}