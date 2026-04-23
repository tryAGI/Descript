
#nullable enable

namespace Descript
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListProjectsDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectsDirection value)
        {
            return value switch
            {
                ListProjectsDirection.Asc => "asc",
                ListProjectsDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectsDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListProjectsDirection.Asc,
                "desc" => ListProjectsDirection.Desc,
                _ => null,
            };
        }
    }
}