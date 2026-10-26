
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DriveMediaImportRequest
    {
        /// <summary>
        /// Target drive media folder ID (UUID) or "root" for the root folder. If not provided, defaults to root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Map of media reference IDs to their import definitions. Key is the display name<br/>
        /// or path (e.g. "video.mp4" or "Folder/SubFolder/video.mp4"). Paths with forward<br/>
        /// slashes create nested folders automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_media")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object AddMedia { get; set; }

        /// <summary>
        /// Optional callback URL to receive notifications about job status changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportRequest" /> class.
        /// </summary>
        /// <param name="addMedia">
        /// Map of media reference IDs to their import definitions. Key is the display name<br/>
        /// or path (e.g. "video.mp4" or "Folder/SubFolder/video.mp4"). Paths with forward<br/>
        /// slashes create nested folders automatically.
        /// </param>
        /// <param name="folderId">
        /// Target drive media folder ID (UUID) or "root" for the root folder. If not provided, defaults to root.
        /// </param>
        /// <param name="callbackUrl">
        /// Optional callback URL to receive notifications about job status changes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DriveMediaImportRequest(
            object addMedia,
            string? folderId,
            string? callbackUrl)
        {
            this.FolderId = folderId;
            this.AddMedia = addMedia ?? throw new global::System.ArgumentNullException(nameof(addMedia));
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportRequest" /> class.
        /// </summary>
        public DriveMediaImportRequest()
        {
        }

    }
}