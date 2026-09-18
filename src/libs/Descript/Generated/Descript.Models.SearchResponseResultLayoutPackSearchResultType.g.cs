
#nullable enable

namespace Descript
{
    /// <summary>
    /// Always `layout_pack` for a layout pack result.
    /// </summary>
    public enum SearchResponseResultLayoutPackSearchResultType
    {
        /// <summary>
        ///
        /// </summary>
        LayoutPack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchResponseResultLayoutPackSearchResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResponseResultLayoutPackSearchResultType value)
        {
            return value switch
            {
                SearchResponseResultLayoutPackSearchResultType.LayoutPack => "layout_pack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResponseResultLayoutPackSearchResultType? ToEnum(string value)
        {
            return value switch
            {
                "layout_pack" => SearchResponseResultLayoutPackSearchResultType.LayoutPack,
                _ => null,
            };
        }
    }
}