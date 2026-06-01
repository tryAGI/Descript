
#nullable enable

namespace Descript
{
    /// <summary>
    /// Transcript file format. For `docx`, the response `content` field<br/>
    /// contains the base64-encoded binary file.
    /// </summary>
    public enum ExportTranscriptRequestFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Docx,
        /// <summary>
        /// 
        /// </summary>
        Html,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        Rtf,
        /// <summary>
        /// 
        /// </summary>
        Txt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportTranscriptRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportTranscriptRequestFormat value)
        {
            return value switch
            {
                ExportTranscriptRequestFormat.Docx => "docx",
                ExportTranscriptRequestFormat.Html => "html",
                ExportTranscriptRequestFormat.Markdown => "markdown",
                ExportTranscriptRequestFormat.Rtf => "rtf",
                ExportTranscriptRequestFormat.Txt => "txt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportTranscriptRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "docx" => ExportTranscriptRequestFormat.Docx,
                "html" => ExportTranscriptRequestFormat.Html,
                "markdown" => ExportTranscriptRequestFormat.Markdown,
                "rtf" => ExportTranscriptRequestFormat.Rtf,
                "txt" => ExportTranscriptRequestFormat.Txt,
                _ => null,
            };
        }
    }
}