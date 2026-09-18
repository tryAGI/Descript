
#nullable enable

namespace Descript
{
    /// <summary>
    /// Always `media_library` for a media-library folder.
    /// </summary>
    public enum SearchResponseResultMediaLibraryFolderSearchResultLocation
    {
        /// <summary>
        ///
        /// </summary>
        MediaLibrary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchResponseResultMediaLibraryFolderSearchResultLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResponseResultMediaLibraryFolderSearchResultLocation value)
        {
            return value switch
            {
                SearchResponseResultMediaLibraryFolderSearchResultLocation.MediaLibrary => "media_library",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResponseResultMediaLibraryFolderSearchResultLocation? ToEnum(string value)
        {
            return value switch
            {
                "media_library" => SearchResponseResultMediaLibraryFolderSearchResultLocation.MediaLibrary,
                _ => null,
            };
        }
    }
}