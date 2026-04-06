
#nullable enable

namespace Descript
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportProjectMediaResponseUploadUrls2
    {
        /// <summary>
        /// Signed URL to PUT the file to. Expires after 3 hours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// GAT asset ID for the uploaded file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AssetId { get; set; }

        /// <summary>
        /// GAT artifact ID for the uploaded file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ArtifactId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaResponseUploadUrls2" /> class.
        /// </summary>
        /// <param name="uploadUrl">
        /// Signed URL to PUT the file to. Expires after 3 hours.
        /// </param>
        /// <param name="assetId">
        /// GAT asset ID for the uploaded file
        /// </param>
        /// <param name="artifactId">
        /// GAT artifact ID for the uploaded file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportProjectMediaResponseUploadUrls2(
            string uploadUrl,
            global::System.Guid assetId,
            global::System.Guid artifactId)
        {
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.AssetId = assetId;
            this.ArtifactId = artifactId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaResponseUploadUrls2" /> class.
        /// </summary>
        public ImportProjectMediaResponseUploadUrls2()
        {
        }
    }
}