#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ApiEndpointsExportTranscriptCommandApiCommand
{
    private static Option<global::System.Guid> ProjectId { get; } = new(
        name: @"--project-id")
    {
        Description = @"The ID of the project to export from.",
        Required = true,
    };

    private static Option<global::System.Guid?> CompositionId { get; } = new(
        name: @"--composition-id")
    {
        Description = @"The ID of the composition to export. Defaults to the first composition.",
    };

    private static Option<global::Descript.ExportTranscriptRequestFormat> Format { get; } = new(
        name: @"--format")
    {
        Description = @"Transcript file format. The response body is the raw transcript file
in the requested format (binary for `docx`, plain text otherwise).
",
        Required = true,
    };

    private static Option<global::Descript.ExportTranscriptRequestIncludeSpeakerLabels?> IncludeSpeakerLabels { get; } = new(
        name: @"--include-speaker-labels")
    {
        Description = @"Speaker label mode.
- `off`: No speaker labels
- `changes`: Show speaker label when the speaker changes
- `every_paragraph`: Show speaker label on every paragraph
",
    };

    private static Option<bool?> IncludeMarkers { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-markers",
        description: @"Include markers in the transcript.");

    private static Option<global::Descript.ExportTranscriptRequestTimecodes?> Timecodes { get; } = new(
        name: @"--timecodes")
    {
        Description = @"Timecode options. When provided, timecodes are included in
the output.
",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, string value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, string value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"export-transcript", @"Export project transcript
Export the transcript from a project composition.

Supports plain text, Markdown, HTML, RTF, and DOCX formats.
Options include speaker labels, timecodes, and markers.

The response body is the raw transcript file (binary for `docx`,
text otherwise) with a `Content-Disposition: attachment` header and
an `X-Composition-Id` header identifying the exported composition.
");
                        command.Options.Add(ProjectId);
                        command.Options.Add(CompositionId);
                        command.Options.Add(Format);
                        command.Options.Add(IncludeSpeakerLabels);
                        command.Options.Add(IncludeMarkers);
                        command.Options.Add(Timecodes);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Descript.ExportTranscriptRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Descript.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var compositionId = CliRuntime.WasSpecified(parseResult, CompositionId) ? parseResult.GetValue(CompositionId) : (__requestBase is { } __CompositionIdBaseValue ? __CompositionIdBaseValue.CompositionId : default);
                        var format = parseResult.GetRequiredValue(Format);
                        var includeSpeakerLabels = CliRuntime.WasSpecified(parseResult, IncludeSpeakerLabels) ? parseResult.GetValue(IncludeSpeakerLabels) : (__requestBase is { } __IncludeSpeakerLabelsBaseValue ? __IncludeSpeakerLabelsBaseValue.IncludeSpeakerLabels : default);
                        var includeMarkers = CliRuntime.WasSpecified(parseResult, IncludeMarkers) ? parseResult.GetValue(IncludeMarkers) : (__requestBase is { } __IncludeMarkersBaseValue ? __IncludeMarkersBaseValue.IncludeMarkers : default);
                        var timecodes = CliRuntime.WasSpecified(parseResult, Timecodes) ? parseResult.GetValue(Timecodes) : (__requestBase is { } __TimecodesBaseValue ? __TimecodesBaseValue.Timecodes : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiEndpoints.ExportTranscriptAsync(
                                    projectId: projectId,
                                    compositionId: compositionId,
                                    format: format,
                                    includeSpeakerLabels: includeSpeakerLabels,
                                    includeMarkers: includeMarkers,
                                    timecodes: timecodes,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Descript.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}