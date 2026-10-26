
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public enum DriveMediaImportJobStatusJobState
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Stopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DriveMediaImportJobStatusJobStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DriveMediaImportJobStatusJobState value)
        {
            return value switch
            {
                DriveMediaImportJobStatusJobState.Cancelled => "cancelled",
                DriveMediaImportJobStatusJobState.Queued => "queued",
                DriveMediaImportJobStatusJobState.Running => "running",
                DriveMediaImportJobStatusJobState.Stopped => "stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DriveMediaImportJobStatusJobState? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => DriveMediaImportJobStatusJobState.Cancelled,
                "queued" => DriveMediaImportJobStatusJobState.Queued,
                "running" => DriveMediaImportJobStatusJobState.Running,
                "stopped" => DriveMediaImportJobStatusJobState.Stopped,
                _ => null,
            };
        }
    }
}