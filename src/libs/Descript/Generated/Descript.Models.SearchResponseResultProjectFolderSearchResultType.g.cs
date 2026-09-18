
#nullable enable

namespace Descript
{
    /// <summary>
    /// Always `project_folder`. The folder holds projects.
    /// </summary>
    public enum SearchResponseResultProjectFolderSearchResultType
    {
        /// <summary>
        ///
        /// </summary>
        ProjectFolder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchResponseResultProjectFolderSearchResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResponseResultProjectFolderSearchResultType value)
        {
            return value switch
            {
                SearchResponseResultProjectFolderSearchResultType.ProjectFolder => "project_folder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResponseResultProjectFolderSearchResultType? ToEnum(string value)
        {
            return value switch
            {
                "project_folder" => SearchResponseResultProjectFolderSearchResultType.ProjectFolder,
                _ => null,
            };
        }
    }
}