
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public enum DriveMediaImportJobStatusResultVariant1MediaStatusStatus
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
    public static class DriveMediaImportJobStatusResultVariant1MediaStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DriveMediaImportJobStatusResultVariant1MediaStatusStatus value)
        {
            return value switch
            {
                DriveMediaImportJobStatusResultVariant1MediaStatusStatus.Error => "error",
                DriveMediaImportJobStatusResultVariant1MediaStatusStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DriveMediaImportJobStatusResultVariant1MediaStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => DriveMediaImportJobStatusResultVariant1MediaStatusStatus.Error,
                "success" => DriveMediaImportJobStatusResultVariant1MediaStatusStatus.Success,
                _ => null,
            };
        }
    }
}