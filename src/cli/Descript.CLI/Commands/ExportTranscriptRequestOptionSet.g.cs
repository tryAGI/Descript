#nullable enable

using System.CommandLine;

namespace Descript.CLI.Commands;

internal sealed record ExportTranscriptRequestOptionSet(
    Option<global::System.Guid> ProjectId,
                     Option<global::System.Guid?> CompositionId,
                     Option<global::Descript.ExportTranscriptRequestFormat> Format,
                     Option<global::Descript.ExportTranscriptRequestIncludeSpeakerLabels?> IncludeSpeakerLabels,
                     Option<bool?> IncludeMarkers)
{
    public static ExportTranscriptRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ExportTranscriptRequestOptionSet(
                        ProjectId: new Option<global::System.Guid>($"--{normalizedPrefix}project-id")
                {
                    Description = @"The ID of the project to export from.",
                    Required = true,
                },
                CompositionId: new Option<global::System.Guid?>($"--{normalizedPrefix}composition-id")
                {
                    Description = @"The ID of the composition to export. Defaults to the first composition.",
                },
                Format: new Option<global::Descript.ExportTranscriptRequestFormat>($"--{normalizedPrefix}format")
                {
                    Description = @"Transcript file format. The response body is the raw transcript file
in the requested format (binary for `docx`, plain text otherwise).
The `srt` format exports a SubRip subtitle file with timed captions.
",
                    Required = true,
                },
                IncludeSpeakerLabels: new Option<global::Descript.ExportTranscriptRequestIncludeSpeakerLabels?>($"--{normalizedPrefix}include-speaker-labels")
                {
                    Description = @"Speaker label mode.
- `off`: No speaker labels
- `changes`: Show speaker label when the speaker changes
- `every_paragraph`: Show speaker label on every paragraph
",
                },
                IncludeMarkers: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}include-markers", description: @"Include markers in the transcript.")
        );
    }
}