
#nullable enable

namespace Descript
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAgentModelsResponseAliase
    {
        /// <summary>
        /// Alias id callers can pass as `model`.<br/>
        /// Example: claude-opus
        /// </summary>
        /// <example>claude-opus</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Canonical model id this alias currently resolves to.<br/>
        /// Example: claude-opus-4.8
        /// </summary>
        /// <example>claude-opus-4.8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolvesTo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResolvesTo { get; set; }

        /// <summary>
        /// Human-readable description of the alias's intent.<br/>
        /// Example: Tracks stable Anthropic Claude Opus
        /// </summary>
        /// <example>Tracks stable Anthropic Claude Opus</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Relative cost tier of the model this alias resolves to.<br/>
        /// Example: high
        /// </summary>
        /// <example>high</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.ListAgentModelsResponseAliaseCostJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Descript.ListAgentModelsResponseAliaseCost Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentModelsResponseAliase" /> class.
        /// </summary>
        /// <param name="id">
        /// Alias id callers can pass as `model`.<br/>
        /// Example: claude-opus
        /// </param>
        /// <param name="resolvesTo">
        /// Canonical model id this alias currently resolves to.<br/>
        /// Example: claude-opus-4.8
        /// </param>
        /// <param name="description">
        /// Human-readable description of the alias's intent.<br/>
        /// Example: Tracks stable Anthropic Claude Opus
        /// </param>
        /// <param name="cost">
        /// Relative cost tier of the model this alias resolves to.<br/>
        /// Example: high
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentModelsResponseAliase(
            string id,
            string resolvesTo,
            string description,
            global::Descript.ListAgentModelsResponseAliaseCost cost)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ResolvesTo = resolvesTo ?? throw new global::System.ArgumentNullException(nameof(resolvesTo));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentModelsResponseAliase" /> class.
        /// </summary>
        public ListAgentModelsResponseAliase()
        {
        }

    }
}