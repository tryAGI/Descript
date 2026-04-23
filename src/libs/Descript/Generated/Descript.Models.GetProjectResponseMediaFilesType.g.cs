
#nullable enable

namespace Descript
{
    /// <summary>
    /// Media type
    /// </summary>
    public enum GetProjectResponseMediaFilesType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Sequence,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseMediaFilesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseMediaFilesType value)
        {
            return value switch
            {
                GetProjectResponseMediaFilesType.Audio => "audio",
                GetProjectResponseMediaFilesType.Image => "image",
                GetProjectResponseMediaFilesType.Other => "other",
                GetProjectResponseMediaFilesType.Sequence => "sequence",
                GetProjectResponseMediaFilesType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseMediaFilesType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => GetProjectResponseMediaFilesType.Audio,
                "image" => GetProjectResponseMediaFilesType.Image,
                "other" => GetProjectResponseMediaFilesType.Other,
                "sequence" => GetProjectResponseMediaFilesType.Sequence,
                "video" => GetProjectResponseMediaFilesType.Video,
                _ => null,
            };
        }
    }
}