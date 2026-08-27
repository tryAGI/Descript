
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListAgentModelsResponse
    {
        /// <summary>
        /// Canonical model ids currently advertised by the public agent API,<br/>
        /// each tagged with a coarse cost tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableModels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Descript.ListAgentModelsResponseAvailableModel> AvailableModels { get; set; }

        /// <summary>
        /// Friendly aliases that resolve to one of the `availableModels` at<br/>
        /// request time. Pass any alias `id` as `model` and the agent job<br/>
        /// result's `result.resolved_model` (on<br/>
        /// [GET /jobs/{job_id}](#operation/getJob)) will report the canonical<br/>
        /// id that actually ran.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Descript.ListAgentModelsResponseAliase> Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentModelsResponse" /> class.
        /// </summary>
        /// <param name="availableModels">
        /// Canonical model ids currently advertised by the public agent API,<br/>
        /// each tagged with a coarse cost tier.
        /// </param>
        /// <param name="aliases">
        /// Friendly aliases that resolve to one of the `availableModels` at<br/>
        /// request time. Pass any alias `id` as `model` and the agent job<br/>
        /// result's `result.resolved_model` (on<br/>
        /// [GET /jobs/{job_id}](#operation/getJob)) will report the canonical<br/>
        /// id that actually ran.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentModelsResponse(
            global::System.Collections.Generic.IList<global::Descript.ListAgentModelsResponseAvailableModel> availableModels,
            global::System.Collections.Generic.IList<global::Descript.ListAgentModelsResponseAliase> aliases)
        {
            this.AvailableModels = availableModels ?? throw new global::System.ArgumentNullException(nameof(availableModels));
            this.Aliases = aliases ?? throw new global::System.ArgumentNullException(nameof(aliases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentModelsResponse" /> class.
        /// </summary>
        public ListAgentModelsResponse()
        {
        }

    }
}