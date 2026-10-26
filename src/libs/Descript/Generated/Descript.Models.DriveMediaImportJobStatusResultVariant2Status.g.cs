
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public enum DriveMediaImportJobStatusResultVariant2Status
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DriveMediaImportJobStatusResultVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DriveMediaImportJobStatusResultVariant2Status value)
        {
            return value switch
            {
                DriveMediaImportJobStatusResultVariant2Status.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DriveMediaImportJobStatusResultVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "error" => DriveMediaImportJobStatusResultVariant2Status.Error,
                _ => null,
            };
        }
    }
}