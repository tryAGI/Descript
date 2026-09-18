
#nullable enable

namespace Descript
{
    /// <summary>
    /// Owner of the search result. Omitted when the owner is unavailable.
    /// </summary>
    public sealed partial class SearchOwner
    {
        /// <summary>
        /// User ID of the owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Display name of the owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchOwner" /> class.
        /// </summary>
        /// <param name="id">
        /// User ID of the owner.
        /// </param>
        /// <param name="name">
        /// Display name of the owner.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchOwner(
            global::System.Guid id,
            string name)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchOwner" /> class.
        /// </summary>
        public SearchOwner()
        {
        }

    }
}