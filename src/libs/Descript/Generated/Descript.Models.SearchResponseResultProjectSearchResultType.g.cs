
#nullable enable

namespace Descript
{
    /// <summary>
    /// Always `project` for a project result.
    /// </summary>
    public enum SearchResponseResultProjectSearchResultType
    {
        /// <summary>
        ///
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchResponseResultProjectSearchResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResponseResultProjectSearchResultType value)
        {
            return value switch
            {
                SearchResponseResultProjectSearchResultType.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResponseResultProjectSearchResultType? ToEnum(string value)
        {
            return value switch
            {
                "project" => SearchResponseResultProjectSearchResultType.Project,
                _ => null,
            };
        }
    }
}