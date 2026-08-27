
#nullable enable

namespace Descript
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum ListProjectsSort
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
        /// <summary>
        ///
        /// </summary>
        LastViewedAt,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectsSort value)
        {
            return value switch
            {
                ListProjectsSort.CreatedAt => "created_at",
                ListProjectsSort.LastViewedAt => "last_viewed_at",
                ListProjectsSort.Name => "name",
                ListProjectsSort.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectsSort? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListProjectsSort.CreatedAt,
                "last_viewed_at" => ListProjectsSort.LastViewedAt,
                "name" => ListProjectsSort.Name,
                "updated_at" => ListProjectsSort.UpdatedAt,
                _ => null,
            };
        }
    }
}