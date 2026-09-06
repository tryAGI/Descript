#nullable enable

using System.CommandLine;

namespace Descript.CLI.Commands;

internal sealed record ExportTranscriptRequestOptionSet(
    Option<global::System.Guid> ProjectId,
                     Option<string?> CompositionId,
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
                CompositionId: new Option<string?>($"--{normalizedPrefix}composition-id")
                {
                    Description = @"Composition to export. If omitted, the first composition in the project is used.

Accepts any of the following formats:
- A full composition UUID (e.g. `39677a40-1c43-4c36-8449-46cfbc4de2b5`)
- A 5-character short ID from a Descript URL (e.g. `39677`)
- A full Descript project URL (e.g. `https://web.descript.com/{project_id}/39677`)
",
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