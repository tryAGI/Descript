
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public enum PublishJobStatusResultDiscriminatorStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishJobStatusResultDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishJobStatusResultDiscriminatorStatus value)
        {
            return value switch
            {
                PublishJobStatusResultDiscriminatorStatus.Error => "error",
                PublishJobStatusResultDiscriminatorStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishJobStatusResultDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => PublishJobStatusResultDiscriminatorStatus.Error,
                "success" => PublishJobStatusResultDiscriminatorStatus.Success,
                _ => null,
            };
        }
    }
}