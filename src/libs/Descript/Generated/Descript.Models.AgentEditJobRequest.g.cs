
#nullable enable

namespace Descript
{
    /// <summary>
    /// Request to run Agent edit.<br/>
    /// The agent will interpret the prompt and either edit an existing project or create a new one.<br/>
    /// You must provide exactly one of `project_id` or `project_name`.
    /// </summary>
    public sealed partial class AgentEditJobRequest
    {
        /// <summary>
        /// The ID of an existing project to edit. Mutually exclusive with `project_name`.<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Name for creating a new project. Mutually exclusive with `project_id`.<br/>
        /// Example: My New Project
        /// </summary>
        /// <example>My New Project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Composition to target within the project. When provided,<br/>
        /// the agent will focus its edits on this specific composition rather<br/>
        /// than choosing one automatically. Only valid when `project_id` is also<br/>
        /// provided. Requires `project_id`.<br/>
        /// Accepts any of the following formats:<br/>
        /// - A full composition UUID (e.g. `39677a40-1c43-4c36-8449-46cfbc4de2b5`)<br/>
        /// - A 5-character short ID from a Descript URL (e.g. `39677`)<br/>
        /// - A full Descript project URL (e.g. `https://web.descript.com/{project_id}/39677`)<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </summary>
        /// <example>39677a40-1c43-4c36-8449-46cfbc4de2b5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_id")]
        public string? CompositionId { get; set; }

        /// <summary>
        /// AI model to use for editing. Accepts a canonical model id<br/>
        /// (e.g. `claude-opus-4.8`) or a friendly alias that tracks the<br/>
        /// stable version of a family (e.g. `claude-opus`). Call<br/>
        /// [GET /agent/models](#operation/listAgentModels) for the current<br/>
        /// set of supported models and aliases.<br/>
        /// Defaults to `auto` when omitted, which selects a recommended<br/>
        /// model for your account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Natural language instruction for the agent to execute.<br/>
        /// Examples: "add studio sound to every clip", "remove all filler words", "create a 30-second highlight reel"<br/>
        /// Example: add studio sound to every clip
        /// </summary>
        /// <example>add studio sound to every clip</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Access level for team members when creating a new project.<br/>
        /// Only applicable when `project_name` is provided (not when using `project_id`).<br/>
        /// Defaults to `none` if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.AgentEditJobRequestTeamAccessJsonConverter))]
        public global::Descript.AgentEditJobRequestTeamAccess? TeamAccess { get; set; }

        /// <summary>
        /// Optional webhook URL to call when the job completes or fails.<br/>
        /// Descript will POST the job status (same format as [GET /jobs/{job_id}](#operation/getJob)) to this URL.<br/>
        /// Example: https://example.com/webhooks/descript/job_callback
        /// </summary>
        /// <example>https://example.com/webhooks/descript/job_callback</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Conversation ID from a previous agent job to continue that conversation.<br/>
        /// Requires `project_id` (a conversation belongs to an existing project).<br/>
        /// When omitted, a new conversation is started. The `conversation_id` is returned<br/>
        /// in the job result when the job completes.<br/>
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
        /// Initializes a new instance of the <see cref="AgentEditJobRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Natural language instruction for the agent to execute.<br/>
        /// Examples: "add studio sound to every clip", "remove all filler words", "create a 30-second highlight reel"<br/>
        /// Example: add studio sound to every clip
        /// </param>
        /// <param name="projectId">
        /// The ID of an existing project to edit. Mutually exclusive with `project_name`.<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="projectName">
        /// Name for creating a new project. Mutually exclusive with `project_id`.<br/>
        /// Example: My New Project
        /// </param>
        /// <param name="compositionId">
        /// Composition to target within the project. When provided,<br/>
        /// the agent will focus its edits on this specific composition rather<br/>
        /// than choosing one automatically. Only valid when `project_id` is also<br/>
        /// provided. Requires `project_id`.<br/>
        /// Accepts any of the following formats:<br/>
        /// - A full composition UUID (e.g. `39677a40-1c43-4c36-8449-46cfbc4de2b5`)<br/>
        /// - A 5-character short ID from a Descript URL (e.g. `39677`)<br/>
        /// - A full Descript project URL (e.g. `https://web.descript.com/{project_id}/39677`)<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </param>
        /// <param name="model">
        /// AI model to use for editing. Accepts a canonical model id<br/>
        /// (e.g. `claude-opus-4.8`) or a friendly alias that tracks the<br/>
        /// stable version of a family (e.g. `claude-opus`). Call<br/>
        /// [GET /agent/models](#operation/listAgentModels) for the current<br/>
        /// set of supported models and aliases.<br/>
        /// Defaults to `auto` when omitted, which selects a recommended<br/>
        /// model for your account.
        /// </param>
        /// <param name="teamAccess">
        /// Access level for team members when creating a new project.<br/>
        /// Only applicable when `project_name` is provided (not when using `project_id`).<br/>
        /// Defaults to `none` if not specified.
        /// </param>
        /// <param name="callbackUrl">
        /// Optional webhook URL to call when the job completes or fails.<br/>
        /// Descript will POST the job status (same format as [GET /jobs/{job_id}](#operation/getJob)) to this URL.<br/>
        /// Example: https://example.com/webhooks/descript/job_callback
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID from a previous agent job to continue that conversation.<br/>
        /// Requires `project_id` (a conversation belongs to an existing project).<br/>
        /// When omitted, a new conversation is started. The `conversation_id` is returned<br/>
        /// in the job result when the job completes.<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentEditJobRequest(
            string prompt,
            global::System.Guid? projectId,
            string? projectName,
            string? compositionId,
            string? model,
            global::Descript.AgentEditJobRequestTeamAccess? teamAccess,
            string? callbackUrl,
            global::System.Guid? conversationId)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.CompositionId = compositionId;
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.TeamAccess = teamAccess;
            this.CallbackUrl = callbackUrl;
            this.ConversationId = conversationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEditJobRequest" /> class.
        /// </summary>
        public AgentEditJobRequest()
        {
        }

    }
}