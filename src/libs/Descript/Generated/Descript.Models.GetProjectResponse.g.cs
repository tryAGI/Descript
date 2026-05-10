
#nullable enable

namespace Descript
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponse
    {
        /// <summary>
        /// Project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Project name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Drive ID the project belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drive_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DriveId { get; set; }

        /// <summary>
        /// When the project was created (ISO 8601)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the project was last updated (ISO 8601)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Full folder path for the project (e.g. "Clients/Acme/Videos"). Absent when the project is at the drive root.<br/>
        /// Example: Clients/Acme/Videos
        /// </summary>
        /// <example>Clients/Acme/Videos</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_path")]
        public string? FolderPath { get; set; }

        /// <summary>
        /// Map of display path to media file info
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Descript.GetProjectResponseMediaFiles2> MediaFiles { get; set; }

        /// <summary>
        /// Compositions in the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compositions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Descript.GetProjectResponseComposition> Compositions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Project ID
        /// </param>
        /// <param name="name">
        /// Project name
        /// </param>
        /// <param name="driveId">
        /// Drive ID the project belongs to
        /// </param>
        /// <param name="createdAt">
        /// When the project was created (ISO 8601)
        /// </param>
        /// <param name="updatedAt">
        /// When the project was last updated (ISO 8601)
        /// </param>
        /// <param name="mediaFiles">
        /// Map of display path to media file info
        /// </param>
        /// <param name="compositions">
        /// Compositions in the project
        /// </param>
        /// <param name="folderPath">
        /// Full folder path for the project (e.g. "Clients/Acme/Videos"). Absent when the project is at the drive root.<br/>
        /// Example: Clients/Acme/Videos
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponse(
            global::System.Guid id,
            string name,
            global::System.Guid driveId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.Dictionary<string, global::Descript.GetProjectResponseMediaFiles2> mediaFiles,
            global::System.Collections.Generic.IList<global::Descript.GetProjectResponseComposition> compositions,
            string? folderPath)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DriveId = driveId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FolderPath = folderPath;
            this.MediaFiles = mediaFiles ?? throw new global::System.ArgumentNullException(nameof(mediaFiles));
            this.Compositions = compositions ?? throw new global::System.ArgumentNullException(nameof(compositions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponse" /> class.
        /// </summary>
        public GetProjectResponse()
        {
        }

    }
}