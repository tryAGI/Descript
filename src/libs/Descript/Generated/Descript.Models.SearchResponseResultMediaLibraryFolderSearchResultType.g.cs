
#nullable enable

namespace Descript
{
    /// <summary>
    /// Always `media_library_folder`. The folder holds<br/>
    /// media library files.
    /// </summary>
    public enum SearchResponseResultMediaLibraryFolderSearchResultType
    {
        /// <summary>
        ///
        /// </summary>
        MediaLibraryFolder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchResponseResultMediaLibraryFolderSearchResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResponseResultMediaLibraryFolderSearchResultType value)
        {
            return value switch
            {
                SearchResponseResultMediaLibraryFolderSearchResultType.MediaLibraryFolder => "media_library_folder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResponseResultMediaLibraryFolderSearchResultType? ToEnum(string value)
        {
            return value switch
            {
                "media_library_folder" => SearchResponseResultMediaLibraryFolderSearchResultType.MediaLibraryFolder,
                _ => null,
            };
        }
    }
}