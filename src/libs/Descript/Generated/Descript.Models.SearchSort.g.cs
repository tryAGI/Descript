
#nullable enable

namespace Descript
{
    /// <summary>
    /// Default Value: relevance
    /// </summary>
    public enum SearchSort
    {
        /// <summary>
        /// most recently modified first.
        /// </summary>
        Newest,
        /// <summary>
        /// least recently modified first.
        /// </summary>
        Oldest,
        /// <summary>
        /// closest matches first. This is the default.
        /// </summary>
        Relevance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchSort value)
        {
            return value switch
            {
                SearchSort.Newest => "newest",
                SearchSort.Oldest => "oldest",
                SearchSort.Relevance => "relevance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchSort? ToEnum(string value)
        {
            return value switch
            {
                "newest" => SearchSort.Newest,
                "oldest" => SearchSort.Oldest,
                "relevance" => SearchSort.Relevance,
                _ => null,
            };
        }
    }
}