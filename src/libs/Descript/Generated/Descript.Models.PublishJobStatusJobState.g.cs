
#nullable enable

namespace Descript
{
    /// <summary>
    /// Current state of the job:<br/>
    /// - queued: Job is waiting to start<br/>
    /// - running: Job is actively processing<br/>
    /// - stopped: Job has finished (check result.status for outcome)<br/>
    /// - cancelled: Job was cancelled by user<br/>
    /// Example: stopped
    /// </summary>
    public enum PublishJobStatusJobState
    {
        /// <summary>
        /// Job was cancelled by user
        /// </summary>
        Cancelled,
        /// <summary>
        /// Job is waiting to start
        /// </summary>
        Queued,
        /// <summary>
        /// Job is actively processing
        /// </summary>
        Running,
        /// <summary>
        /// Job has finished (check result.status for outcome)
        /// </summary>
        Stopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishJobStatusJobStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishJobStatusJobState value)
        {
            return value switch
            {
                PublishJobStatusJobState.Cancelled => "cancelled",
                PublishJobStatusJobState.Queued => "queued",
                PublishJobStatusJobState.Running => "running",
                PublishJobStatusJobState.Stopped => "stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishJobStatusJobState? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => PublishJobStatusJobState.Cancelled,
                "queued" => PublishJobStatusJobState.Queued,
                "running" => PublishJobStatusJobState.Running,
                "stopped" => PublishJobStatusJobState.Stopped,
                _ => null,
            };
        }
    }
}