
#nullable enable

namespace Descript
{
    /// <summary>
    /// Resolution for the published output. Only applicable when media_type is Video.
    /// </summary>
    public enum PublishJobRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x1440p,
        /// <summary>
        /// 
        /// </summary>
        x480p,
        /// <summary>
        /// 
        /// </summary>
        x4k,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishJobRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishJobRequestResolution value)
        {
            return value switch
            {
                PublishJobRequestResolution.x1080p => "1080p",
                PublishJobRequestResolution.x1440p => "1440p",
                PublishJobRequestResolution.x480p => "480p",
                PublishJobRequestResolution.x4k => "4K",
                PublishJobRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishJobRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => PublishJobRequestResolution.x1080p,
                "1440p" => PublishJobRequestResolution.x1440p,
                "480p" => PublishJobRequestResolution.x480p,
                "4K" => PublishJobRequestResolution.x4k,
                "720p" => PublishJobRequestResolution.x720p,
                _ => null,
            };
        }
    }
}