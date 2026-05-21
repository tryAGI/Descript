
#nullable enable

namespace Descript
{
    /// <summary>
    /// Signed upload URLs for each direct upload media item. Only present when the request<br/>
    /// includes direct upload references. PUT the file contents to the `upload_url` with<br/>
    /// `Content-Type: application/octet-stream`. The import job will automatically detect<br/>
    /// the upload and process the file.
    /// </summary>
    public sealed partial class ImportProjectMediaResponseUploadUrls
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}