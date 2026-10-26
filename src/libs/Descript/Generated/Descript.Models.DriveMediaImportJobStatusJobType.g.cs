
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public enum DriveMediaImportJobStatusJobType
    {
        /// <summary>
        ///
        /// </summary>
        ImportDriveMedia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DriveMediaImportJobStatusJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DriveMediaImportJobStatusJobType value)
        {
            return value switch
            {
                DriveMediaImportJobStatusJobType.ImportDriveMedia => "import/drive_media",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DriveMediaImportJobStatusJobType? ToEnum(string value)
        {
            return value switch
            {
                "import/drive_media" => DriveMediaImportJobStatusJobType.ImportDriveMedia,
                _ => null,
            };
        }
    }
}