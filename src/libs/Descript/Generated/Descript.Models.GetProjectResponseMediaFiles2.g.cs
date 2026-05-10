
#nullable enable

namespace Descript
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponseMediaFiles2
    {
        /// <summary>
        /// Media type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Descript.JsonConverters.GetProjectResponseMediaFilesTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Descript.GetProjectResponseMediaFilesType Type { get; set; }

        /// <summary>
        /// Duration in seconds (absent for images)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public float? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseMediaFiles2" /> class.
        /// </summary>
        /// <param name="type">
        /// Media type
        /// </param>
        /// <param name="duration">
        /// Duration in seconds (absent for images)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseMediaFiles2(
            global::Descript.GetProjectResponseMediaFilesType type,
            float? duration)
        {
            this.Type = type;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseMediaFiles2" /> class.
        /// </summary>
        public GetProjectResponseMediaFiles2()
        {
        }

    }
}