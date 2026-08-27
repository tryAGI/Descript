
#nullable enable

namespace Descript
{
    /// <summary>
    /// Media type of the published output. Defaults to `Video` when omitted.<br/>
    /// If the target composition has no video content:<br/>
    /// - omitting `media_type` publishes it as `Audio`<br/>
    ///   (the completed job result reports `media_type: Audio`),<br/>
    /// - explicitly requesting `Video` is rejected with a 422.<br/>
    /// Default Value: Video
    /// </summary>
    public enum PublishJobRequestMediaType
    {
        /// <summary>
        /// Audio`),
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