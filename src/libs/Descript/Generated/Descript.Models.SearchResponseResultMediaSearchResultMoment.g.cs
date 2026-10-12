
#nullable enable

namespace Descript
{
    /// <summary>
    /// The time range of the best match for a visual search.<br/>
    /// Present only on visual video matches. The time range is<br/>
    /// represented by `start_time_sec` and `end_time_sec`, in seconds.<br/>
    /// Omitted for images, and non-visual searches.
    /// </summary>
    public sealed partial class SearchResponseResultMediaSearchResultMoment
    {
        /// <summary>
        /// Start of the matched time range, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_sec")]
        public double? StartTimeSec { get; set; }

        /// <summary>
        /// End of the matched time range, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time_sec")]
        public double? EndTimeSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseResultMediaSearchResultMoment" /> class.
        /// </summary>
        /// <param name="startTimeSec">
        /// Start of the matched time range, in seconds.
        /// </param>
        /// <param name="endTimeSec">
        /// End of the matched time range, in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResponseResultMediaSearchResultMoment(
            double? startTimeSec,
            double? endTimeSec)
        {
            this.StartTimeSec = startTimeSec;
            this.EndTimeSec = endTimeSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseResultMediaSearchResultMoment" /> class.
        /// </summary>
        public SearchResponseResultMediaSearchResultMoment()
        {
        }

    }
}