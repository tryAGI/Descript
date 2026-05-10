
#nullable enable

namespace Descript
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectsResponseDataItem
    {
        /// <summary>
        /// Project ID<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Project name<br/>
        /// Example: Marketing Video
        /// </summary>
        /// <example>Marketing Video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// When the project was created<br/>
        /// Example: 2025-11-18T10:30:00Z
        /// </summary>
        /// <example>2025-11-18T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the project was last updated<br/>
        /// Example: 2025-11-19T14:00:00Z
        /// </summary>
        /// <example>2025-11-19T14:00:00Z</example>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Project ID<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="name">
        /// Project name<br/>
        /// Example: Marketing Video
        /// </param>
        /// <param name="createdAt">
        /// When the project was created<br/>
        /// Example: 2025-11-18T10:30:00Z
        /// </param>
        /// <param name="updatedAt">
        /// When the project was last updated<br/>
        /// Example: 2025-11-19T14:00:00Z
        /// </param>
        /// <param name="folderPath">
        /// Full folder path for the project (e.g. "Clients/Acme/Videos"). Absent when the project is at the drive root.<br/>
        /// Example: Clients/Acme/Videos
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectsResponseDataItem(
            global::System.Guid id,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? folderPath)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FolderPath = folderPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectsResponseDataItem" /> class.
        /// </summary>
        public ListProjectsResponseDataItem()
        {
        }

    }
}