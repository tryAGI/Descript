
#nullable enable

namespace Descript
{
    /// <summary>
    /// Where the file lives: `media_library` in the drive<br/>
    /// media library, `project` inside a project, or<br/>
    /// `brand_studio` in Brand Studio.
    /// </summary>
    public enum SearchResponseResultMediaSearchResultLocation
    {
        /// <summary>
        ///
        /// </summary>
        BrandStudio,
        /// <summary>
        /// `media_library` in the drive
        /// </summary>
        MediaLibrary,
        /// <summary>
        ///
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchResponseResultMediaSearchResultLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResponseResultMediaSearchResultLocation value)
        {
            return value switch
            {
                SearchResponseResultMediaSearchResultLocation.BrandStudio => "brand_studio",
                SearchResponseResultMediaSearchResultLocation.MediaLibrary => "media_library",
                SearchResponseResultMediaSearchResultLocation.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResponseResultMediaSearchResultLocation? ToEnum(string value)
        {
            return value switch
            {
                "brand_studio" => SearchResponseResultMediaSearchResultLocation.BrandStudio,
                "media_library" => SearchResponseResultMediaSearchResultLocation.MediaLibrary,
                "project" => SearchResponseResultMediaSearchResultLocation.Project,
                _ => null,
            };
        }
    }
}