#nullable enable

using System.CommandLine;

namespace Descript.CLI.Commands;

internal sealed record ExportTranscriptRequestTimecodesOptionSet(
    Option<double?> FrequencySeconds,
                     Option<bool?> OnParagraphs,
                     Option<bool?> OnSpeakers,
                     Option<bool?> OnMarkers,
                     Option<double?> OffsetSeconds)
{
    public static ExportTranscriptRequestTimecodesOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ExportTranscriptRequestTimecodesOptionSet(
                        FrequencySeconds: new Option<double?>($"--{normalizedPrefix}frequency-seconds")
                {
                    Description = @"Interval in seconds for timecode insertion.",
                },
                OnParagraphs: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}on-paragraphs", description: @"Show timecodes at paragraph breaks."),
                OnSpeakers: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}on-speakers", description: @"Show timecodes at speaker changes."),
                OnMarkers: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}on-markers", description: @"Show timecodes at markers."),
                OffsetSeconds: new Option<double?>($"--{normalizedPrefix}offset-seconds")
                {
                    Description = @"Offset in seconds applied to all timecodes.",
                }
        );
    }
}