
#nullable enable

namespace Descript
{
    /// <summary>
    /// Error response when published project is in an invalid state
    /// </summary>
    public sealed partial class PublishedProjectConflictError
    {
        /// <summary>
        /// Error type identifier<br/>
        /// Example: conflict
        /// </summary>
        /// <example>conflict</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.PublishedProjectConflictErrorErrorJsonConverter))]
        public global::Descript.PublishedProjectConflictErrorError Error { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Published in invalid state
        /// </summary>
        /// <example>Published in invalid state</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Current state of the published project<br/>
        /// Example: processing
        /// </summary>
        /// <example>processing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.PublishedProjectConflictErrorStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Descript.PublishedProjectConflictErrorState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectConflictError" /> class.
        /// </summary>
        /// <param name="error">
        /// Error type identifier<br/>
        /// Example: conflict
        /// </param>
        /// <param name="message">
        /// Human-readable error message<br/>
        /// Example: Published in invalid state
        /// </param>
        /// <param name="state">
        /// Current state of the published project<br/>
        /// Example: processing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishedProjectConflictError(
            string message,
            global::Descript.PublishedProjectConflictErrorState state,
            global::Descript.PublishedProjectConflictErrorError error)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.State = state;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectConflictError" /> class.
        /// </summary>
        public PublishedProjectConflictError()
        {
        }
    }
}