
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DriveMediaImportResponseUploadUrls2
    {
        /// <summary>
        /// Signed URL to PUT the file bytes to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        public string? UploadUrl { get; set; }

        /// <summary>
        /// The asset ID for the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// The artifact ID for the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_id")]
        public string? ArtifactId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportResponseUploadUrls2" /> class.
        /// </summary>
        /// <param name="uploadUrl">
        /// Signed URL to PUT the file bytes to.
        /// </param>
        /// <param name="assetId">
        /// The asset ID for the uploaded file.
        /// </param>
        /// <param name="artifactId">
        /// The artifact ID for the uploaded file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DriveMediaImportResponseUploadUrls2(
            string? uploadUrl,
            string? assetId,
            string? artifactId)
        {
            this.UploadUrl = uploadUrl;
            this.AssetId = assetId;
            this.ArtifactId = artifactId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMediaImportResponseUploadUrls2" /> class.
        /// </summary>
        public DriveMediaImportResponseUploadUrls2()
        {
        }

    }
}