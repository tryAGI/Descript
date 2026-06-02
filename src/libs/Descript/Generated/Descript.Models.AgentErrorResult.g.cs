
#nullable enable

namespace Descript
{
    /// <summary>
    /// Result when Agent edit failed
    /// </summary>
    public sealed partial class AgentErrorResult
    {
        /// <summary>
        /// Indicates the job failed<br/>
        /// Example: error
        /// </summary>
        /// <example>error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.AgentErrorResultStatusJsonConverter))]
        public global::Descript.AgentErrorResultStatus Status { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: AI agent failed to process the request
        /// </summary>
        /// <example>AI agent failed to process the request</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorMessage { get; set; }

        /// <summary>
        /// Machine-readable error code<br/>
        /// Example: agent_execution_failed
        /// </summary>
        /// <example>agent_execution_failed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Conversation ID for this agent session, if one was created before the error occurred.<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </summary>
        /// <example>a1b2c3d4-e5f6-7890-abcd-ef1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public global::System.Guid? ConversationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentErrorResult" /> class.
        /// </summary>
        /// <param name="errorMessage">
        /// Human-readable error message<br/>
        /// Example: AI agent failed to process the request
        /// </param>
        /// <param name="status">
        /// Indicates the job failed<br/>
        /// Example: error
        /// </param>
        /// <param name="errorCode">
        /// Machine-readable error code<br/>
        /// Example: agent_execution_failed
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID for this agent session, if one was created before the error occurred.<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentErrorResult(
            string errorMessage,
            global::Descript.AgentErrorResultStatus status,
            string? errorCode,
            global::System.Guid? conversationId)
        {
            this.Status = status;
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
            this.ErrorCode = errorCode;
            this.ConversationId = conversationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentErrorResult" /> class.
        /// </summary>
        public AgentErrorResult()
        {
        }

    }
}