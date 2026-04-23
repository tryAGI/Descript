
#nullable enable

namespace Descript
{
    /// <summary>
    /// Type of job
    /// </summary>
    public enum PublishJobStatusJobType
    {
        /// <summary>
        /// 
        /// </summary>
        Publish,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishJobStatusJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishJobStatusJobType value)
        {
            return value switch
            {
                PublishJobStatusJobType.Publish => "publish",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishJobStatusJobType? ToEnum(string value)
        {
            return value switch
            {
                "publish" => PublishJobStatusJobType.Publish,
                _ => null,
            };
        }
    }
}