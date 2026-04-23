
#nullable enable

namespace Descript
{
    /// <summary>
    /// Desired access level for the published share page.<br/>
    /// If omitted, the drive's configured default is used.<br/>
    /// Returns 403 if the requested level is not permitted by the drive's publish settings<br/>
    /// (e.g. requesting `public` when search engine indexing is disabled).
    /// </summary>
    public enum PublishJobRequestAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Drive,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Unlisted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishJobRequestAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishJobRequestAccessLevel value)
        {
            return value switch
            {
                PublishJobRequestAccessLevel.Drive => "drive",
                PublishJobRequestAccessLevel.Private => "private",
                PublishJobRequestAccessLevel.Public => "public",
                PublishJobRequestAccessLevel.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishJobRequestAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "drive" => PublishJobRequestAccessLevel.Drive,
                "private" => PublishJobRequestAccessLevel.Private,
                "public" => PublishJobRequestAccessLevel.Public,
                "unlisted" => PublishJobRequestAccessLevel.Unlisted,
                _ => null,
            };
        }
    }
}