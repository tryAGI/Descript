
#nullable enable

namespace Descript
{
    /// <summary>
    /// Media type of the published output
    /// </summary>
    public enum GetProjectResponsePublisheMediaType
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Audiogram,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponsePublisheMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponsePublisheMediaType value)
        {
            return value switch
            {
                GetProjectResponsePublisheMediaType.Audio => "audio",
                GetProjectResponsePublisheMediaType.Audiogram => "audiogram",
                GetProjectResponsePublisheMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponsePublisheMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => GetProjectResponsePublisheMediaType.Audio,
                "audiogram" => GetProjectResponsePublisheMediaType.Audiogram,
                "video" => GetProjectResponsePublisheMediaType.Video,
                _ => null,
            };
        }
    }
}