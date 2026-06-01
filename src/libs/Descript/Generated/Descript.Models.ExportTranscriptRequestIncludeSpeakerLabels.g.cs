
#nullable enable

namespace Descript
{
    /// <summary>
    /// Speaker label mode.<br/>
    /// - `off`: No speaker labels<br/>
    /// - `changes`: Show speaker label when the speaker changes<br/>
    /// - `every_paragraph`: Show speaker label on every paragraph<br/>
    /// Default Value: changes
    /// </summary>
    public enum ExportTranscriptRequestIncludeSpeakerLabels
    {
        /// <summary>
        /// Show speaker label when the speaker changes
        /// </summary>
        Changes,
        /// <summary>
        /// Show speaker label on every paragraph
        /// </summary>
        EveryParagraph,
        /// <summary>
        /// No speaker labels
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportTranscriptRequestIncludeSpeakerLabelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportTranscriptRequestIncludeSpeakerLabels value)
        {
            return value switch
            {
                ExportTranscriptRequestIncludeSpeakerLabels.Changes => "changes",
                ExportTranscriptRequestIncludeSpeakerLabels.EveryParagraph => "every_paragraph",
                ExportTranscriptRequestIncludeSpeakerLabels.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportTranscriptRequestIncludeSpeakerLabels? ToEnum(string value)
        {
            return value switch
            {
                "changes" => ExportTranscriptRequestIncludeSpeakerLabels.Changes,
                "every_paragraph" => ExportTranscriptRequestIncludeSpeakerLabels.EveryParagraph,
                "off" => ExportTranscriptRequestIncludeSpeakerLabels.Off,
                _ => null,
            };
        }
    }
}