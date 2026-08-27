
#nullable enable

namespace Descript
{
    /// <summary>
    /// Access level of the published share page
    /// </summary>
    public enum GetProjectResponsePublisheAccessLevel
    {
        /// <summary>
        ///
        /// </summary>
        Drive,
        /// <summary>
        ///
        /// </summary>
        Password,
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
    public static class GetProjectResponsePublisheAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponsePublisheAccessLevel value)
        {
            return value switch
            {
                GetProjectResponsePublisheAccessLevel.Drive => "drive",
                GetProjectResponsePublisheAccessLevel.Password => "password",
                GetProjectResponsePublisheAccessLevel.Private => "private",
                GetProjectResponsePublisheAccessLevel.Public => "public",
                GetProjectResponsePublisheAccessLevel.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponsePublisheAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "drive" => GetProjectResponsePublisheAccessLevel.Drive,
                "password" => GetProjectResponsePublisheAccessLevel.Password,
                "private" => GetProjectResponsePublisheAccessLevel.Private,
                "public" => GetProjectResponsePublisheAccessLevel.Public,
                "unlisted" => GetProjectResponsePublisheAccessLevel.Unlisted,
                _ => null,
            };
        }
    }
}