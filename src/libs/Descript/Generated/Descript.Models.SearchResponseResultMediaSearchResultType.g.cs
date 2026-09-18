
#nullable enable

namespace Descript
{
    /// <summary>
    /// The kind of media: `video`, `audio`, or `image`.
    /// </summary>
    public enum SearchResponseResultMediaSearchResultType
    {
        /// <summary>
        /// `video`, `audio`, or `image`.
        /// </summary>
        Audio,
        /// <summary>
        /// `video`, `audio`, or `image`.
        /// </summary>
        Image,
        /// <summary>
        /// `video`, `audio`, or `image`.
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchResponseResultMediaSearchResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResponseResultMediaSearchResultType value)
        {
            return value switch
            {
                SearchResponseResultMediaSearchResultType.Audio => "audio",
                SearchResponseResultMediaSearchResultType.Image => "image",
                SearchResponseResultMediaSearchResultType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResponseResultMediaSearchResultType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => SearchResponseResultMediaSearchResultType.Audio,
                "image" => SearchResponseResultMediaSearchResultType.Image,
                "video" => SearchResponseResultMediaSearchResultType.Video,
                _ => null,
            };
        }
    }
}