
#nullable enable

namespace Descript
{
    /// <summary>
    /// Indicates the publish job failed
    /// </summary>
    public enum PublishErrorResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishErrorResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishErrorResultStatus value)
        {
            return value switch
            {
                PublishErrorResultStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishErrorResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => PublishErrorResultStatus.Error,
                _ => null,
            };
        }
    }
}