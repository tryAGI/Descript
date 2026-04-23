
#nullable enable

namespace Descript
{
    /// <summary>
    /// Media type of the published output.<br/>
    /// Default Value: Video
    /// </summary>
    public enum PublishJobRequestMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishJobRequestMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishJobRequestMediaType value)
        {
            return value switch
            {
                PublishJobRequestMediaType.Audio => "Audio",
                PublishJobRequestMediaType.Video => "Video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishJobRequestMediaType? ToEnum(string value)
        {
            return value switch
            {
                "Audio" => PublishJobRequestMediaType.Audio,
                "Video" => PublishJobRequestMediaType.Video,
                _ => null,
            };
        }
    }
}