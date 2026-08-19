
#nullable enable

namespace Descript
{
    /// <summary>
    /// Result when Agent edit completed successfully
    /// </summary>
    public sealed partial class AgentSuccessResult
    {
        /// <summary>
        /// Indicates successful completion<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.AgentSuccessResultStatusJsonConverter))]
        public global::Descript.AgentSuccessResultStatus Status { get; set; }

        /// <summary>
        /// AI response describing what was done<br/>
        /// Example: I added Studio Sound to all 3 clips in your composition
        /// </summary>
        /// <example>I added Studio Sound to all 3 clips in your composition</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentResponse { get; set; }

        /// <summary>
        /// Whether the agent made modifications to the project<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_changed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ProjectChanged { get; set; }

        /// <summary>
        /// Media minutes (in seconds) consumed by this operation<br/>
        /// Example: 34
        /// </summary>
        /// <example>34</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_seconds_used")]
        public int? MediaSecondsUsed { get; set; }

        /// <summary>
        /// AI credits consumed by this operation<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_credits_used")]
        public int? AiCreditsUsed { get; set; }

        /// <summary>
        /// Model reported for this job: the canonical id for an explicit model or<br/>
        /// alias (e.g. `claude-opus-4.8` for `claude-opus`), `auto` for an `auto`<br/>
        /// request, or `inherited` when a resume keeps the conversation's model.<br/>
        /// Present on jobs submitted via the public API after the model-aliases<br/>
        /// launch; older jobs may omit it.<br/>
        /// Example: claude-opus-4.8
        /// </summary>
        /// <example>claude-opus-4.8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_model")]
        public string? ResolvedModel { get; set; }

        /// <summary>
        /// Conversation ID for this agent session. Pass this value as `conversation_id` in a<br/>
        /// subsequent [POST /jobs/agent](#operation/agentEditJob) request to continue the conversation.<br/>
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
        /// Initializes a new instance of the <see cref="AgentSuccessResult" /> class.
        /// </summary>
        /// <param name="agentResponse">
        /// AI response describing what was done<br/>
        /// Example: I added Studio Sound to all 3 clips in your composition
        /// </param>
        /// <param name="projectChanged">
        /// Whether the agent made modifications to the project<br/>
        /// Example: true
        /// </param>
        /// <param name="status">
        /// Indicates successful completion<br/>
        /// Example: success
        /// </param>
        /// <param name="mediaSecondsUsed">
        /// Media minutes (in seconds) consumed by this operation<br/>
        /// Example: 34
        /// </param>
        /// <param name="aiCreditsUsed">
        /// AI credits consumed by this operation<br/>
        /// Example: 5
        /// </param>
        /// <param name="resolvedModel">
        /// Model reported for this job: the canonical id for an explicit model or<br/>
        /// alias (e.g. `claude-opus-4.8` for `claude-opus`), `auto` for an `auto`<br/>
        /// request, or `inherited` when a resume keeps the conversation's model.<br/>
        /// Present on jobs submitted via the public API after the model-aliases<br/>
        /// launch; older jobs may omit it.<br/>
        /// Example: claude-opus-4.8
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID for this agent session. Pass this value as `conversation_id` in a<br/>
        /// subsequent [POST /jobs/agent](#operation/agentEditJob) request to continue the conversation.<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSuccessResult(
            string agentResponse,
            bool projectChanged,
            global::Descript.AgentSuccessResultStatus status,
            int? mediaSecondsUsed,
            int? aiCreditsUsed,
            string? resolvedModel,
            global::System.Guid? conversationId)
        {
            this.Status = status;
            this.AgentResponse = agentResponse ?? throw new global::System.ArgumentNullException(nameof(agentResponse));
            this.ProjectChanged = projectChanged;
            this.MediaSecondsUsed = mediaSecondsUsed;
            this.AiCreditsUsed = aiCreditsUsed;
            this.ResolvedModel = resolvedModel;
            this.ConversationId = conversationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSuccessResult" /> class.
        /// </summary>
        public AgentSuccessResult()
        {
        }

    }
}