
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListAgentModelsResponseAvailableModel
    {
        /// <summary>
        /// Canonical model id to pass as `model` on `POST /jobs/agent`.<br/>
        /// Example: claude-opus-4.8
        /// </summary>
        /// <example>claude-opus-4.8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Relative cost tier for this model.<br/>
        /// Example: high
        /// </summary>
        /// <example>high</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.ListAgentModelsResponseAvailableModelCostJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Descript.ListAgentModelsResponseAvailableModelCost Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentModelsResponseAvailableModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Canonical model id to pass as `model` on `POST /jobs/agent`.<br/>
        /// Example: claude-opus-4.8
        /// </param>
        /// <param name="cost">
        /// Relative cost tier for this model.<br/>
        /// Example: high
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentModelsResponseAvailableModel(
            string id,
            global::Descript.ListAgentModelsResponseAvailableModelCost cost)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentModelsResponseAvailableModel" /> class.
        /// </summary>
        public ListAgentModelsResponseAvailableModel()
        {
        }

    }
}