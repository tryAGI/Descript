
#nullable enable

namespace Descript
{
    /// <summary>
    /// Map of media reference IDs to their import definitions. Key is the display name<br/>
    /// or path (e.g. "video.mp4" or "Folder/SubFolder/video.mp4"). Paths with forward<br/>
    /// slashes create nested folders automatically.
    /// </summary>
    public sealed partial class DriveMediaImportRequestAddMedia
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}