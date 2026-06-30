
#nullable enable

namespace Descript
{
    /// <summary>
    /// The media type the composition was actually published as. For an audio-only composition published with the default Video request, this is Audio.<br/>
    /// Example: Audio
    /// </summary>
    public enum PublishSuccessResultMediaType
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
    public static class PublishSuccessResultMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishSuccessResultMediaType value)
        {
            return value switch
            {
                PublishSuccessResultMediaType.Audio => "Audio",
                PublishSuccessResultMediaType.Video => "Video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishSuccessResultMediaType? ToEnum(string value)
        {
            return value switch
            {
                "Audio" => PublishSuccessResultMediaType.Audio,
                "Video" => PublishSuccessResultMediaType.Video,
                _ => null,
            };
        }
    }
}