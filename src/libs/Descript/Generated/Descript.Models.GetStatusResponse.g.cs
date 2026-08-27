
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetStatusResponse
    {
        /// <summary>
        /// The drive ID associated with the authentication token, or null if the token has no associated drive<br/>
        /// Example: c9c5c47e-158a-49f7-846b-4f6ee2a229a2
        /// </summary>
        /// <example>c9c5c47e-158a-49f7-846b-4f6ee2a229a2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("drive_id")]
        public global::System.Guid? DriveId { get; set; }

        /// <summary>
        /// Human-readable name of the connected drive (workspace), or null if unavailable<br/>
        /// Example: My Team Workspace
        /// </summary>
        /// <example>My Team Workspace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("drive_name")]
        public string? DriveName { get; set; }

        /// <summary>
        /// Current API version<br/>
        /// Example: 1.2
        /// </summary>
        /// <example>1.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatusResponse" /> class.
        /// </summary>
        /// <param name="apiVersion">
        /// Current API version<br/>
        /// Example: 1.2
        /// </param>
        /// <param name="driveId">
        /// The drive ID associated with the authentication token, or null if the token has no associated drive<br/>
        /// Example: c9c5c47e-158a-49f7-846b-4f6ee2a229a2
        /// </param>
        /// <param name="driveName">
        /// Human-readable name of the connected drive (workspace), or null if unavailable<br/>
        /// Example: My Team Workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetStatusResponse(
            string apiVersion,
            global::System.Guid? driveId,
            string? driveName)
        {
            this.DriveId = driveId;
            this.DriveName = driveName;
            this.ApiVersion = apiVersion ?? throw new global::System.ArgumentNullException(nameof(apiVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatusResponse" /> class.
        /// </summary>
        public GetStatusResponse()
        {
        }

    }
}