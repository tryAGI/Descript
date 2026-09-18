
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchMatchItem
    {
        /// <summary>
        ///
        /// </summary>
        Content,
        /// <summary>
        ///
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchMatchItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMatchItem value)
        {
            return value switch
            {
                SearchMatchItem.Content => "content",
                SearchMatchItem.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMatchItem? ToEnum(string value)
        {
            return value switch
            {
                "content" => SearchMatchItem.Content,
                "name" => SearchMatchItem.Name,
                _ => null,
            };
        }
    }
}