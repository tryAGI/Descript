
#nullable enable

namespace Descript
{
    /// <summary>
    /// Indicates successful completion
    /// </summary>
    public enum PublishSuccessResultStatus
    {
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishSuccessResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishSuccessResultStatus value)
        {
            return value switch
            {
                PublishSuccessResultStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishSuccessResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => PublishSuccessResultStatus.Success,
                _ => null,
            };
        }
    }
}