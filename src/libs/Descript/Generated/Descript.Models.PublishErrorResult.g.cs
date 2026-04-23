
#nullable enable

namespace Descript
{
    /// <summary>
    /// Result when publish failed
    /// </summary>
    public sealed partial class PublishErrorResult
    {
        /// <summary>
        /// Indicates the publish job failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.PublishErrorResultStatusJsonConverter))]
        public global::Descript.PublishErrorResultStatus Status { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Export failed during render
        /// </summary>
        /// <example>Export failed during render</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishErrorResult" /> class.
        /// </summary>
        /// <param name="errorMessage">
        /// Human-readable error message<br/>
        /// Example: Export failed during render
        /// </param>
        /// <param name="status">
        /// Indicates the publish job failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishErrorResult(
            string errorMessage,
            global::Descript.PublishErrorResultStatus status)
        {
            this.Status = status;
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishErrorResult" /> class.
        /// </summary>
        public PublishErrorResult()
        {
        }
    }
}