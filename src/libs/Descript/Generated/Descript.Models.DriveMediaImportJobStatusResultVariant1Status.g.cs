
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public enum DriveMediaImportJobStatusResultVariant1Status
    {
        /// <summary>
        ///
        /// </summary>
        Partial,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DriveMediaImportJobStatusResultVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DriveMediaImportJobStatusResultVariant1Status value)
        {
            return value switch
            {
                DriveMediaImportJobStatusResultVariant1Status.Partial => "partial",
                DriveMediaImportJobStatusResultVariant1Status.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DriveMediaImportJobStatusResultVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "partial" => DriveMediaImportJobStatusResultVariant1Status.Partial,
                "success" => DriveMediaImportJobStatusResultVariant1Status.Success,
                _ => null,
            };
        }
    }
}