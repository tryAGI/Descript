#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ApiEndpointsExportTranscriptAsBytesCommandApiCommand
{
    private static readonly ExportTranscriptRequestOptionSet ExportTranscriptRequestOptionSetOptions = ExportTranscriptRequestOptionSet.Create();

    private static readonly ExportTranscriptRequestTimecodesOptionSet TimecodesOptions = ExportTranscriptRequestTimecodesOptionSet.Create(@"timecodes");
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

    public static Command Create()
    {
        var command = new Command(@"export-transcript-as-bytes", @"Export project transcript
Export the transcript from a project composition.

Supports plain text, Markdown, HTML, RTF, DOCX, and SRT (SubRip subtitle) formats.
Options include speaker labels, timecodes, and markers.

The response body is the raw transcript file (binary for `docx`,
text otherwise) with a `Content-Disposition: attachment` header and
an `X-Composition-Id` header identifying the exported composition.
");
                        command.Options.Add(ExportTranscriptRequestOptionSetOptions.ProjectId);
                        command.Options.Add(ExportTranscriptRequestOptionSetOptions.CompositionId);
                        command.Options.Add(ExportTranscriptRequestOptionSetOptions.Format);
                        command.Options.Add(ExportTranscriptRequestOptionSetOptions.IncludeSpeakerLabels);
                        command.Options.Add(ExportTranscriptRequestOptionSetOptions.IncludeMarkers);                        command.Options.Add(TimecodesOptions.FrequencySeconds);
                        command.Options.Add(TimecodesOptions.OnParagraphs);
                        command.Options.Add(TimecodesOptions.OnSpeakers);
                        command.Options.Add(TimecodesOptions.OnMarkers);
                        command.Options.Add(TimecodesOptions.OffsetSeconds);
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
                            cancellationToken).ConfigureAwait(false);                        var projectId = parseResult.GetRequiredValue(ExportTranscriptRequestOptionSetOptions.ProjectId);
                        var compositionId = CliRuntime.WasSpecified(parseResult, ExportTranscriptRequestOptionSetOptions.CompositionId) ? parseResult.GetValue(ExportTranscriptRequestOptionSetOptions.CompositionId) : (__requestBase is { } __CompositionIdBaseValue ? __CompositionIdBaseValue.CompositionId : default);
                        var format = parseResult.GetRequiredValue(ExportTranscriptRequestOptionSetOptions.Format);
                        var includeSpeakerLabels = CliRuntime.WasSpecified(parseResult, ExportTranscriptRequestOptionSetOptions.IncludeSpeakerLabels) ? parseResult.GetValue(ExportTranscriptRequestOptionSetOptions.IncludeSpeakerLabels) : (__requestBase is { } __IncludeSpeakerLabelsBaseValue ? __IncludeSpeakerLabelsBaseValue.IncludeSpeakerLabels : default);
                        var includeMarkers = CliRuntime.WasSpecified(parseResult, ExportTranscriptRequestOptionSetOptions.IncludeMarkers) ? parseResult.GetValue(ExportTranscriptRequestOptionSetOptions.IncludeMarkers) : (__requestBase is { } __IncludeMarkersBaseValue ? __IncludeMarkersBaseValue.IncludeMarkers : default);

                        var __TimecodesBase = __requestBase is { } __TimecodesBaseValue ? __TimecodesBaseValue.Timecodes : default;                        var timecodesFrequencySeconds = CliRuntime.WasSpecified(parseResult, TimecodesOptions.FrequencySeconds) ? parseResult.GetValue(TimecodesOptions.FrequencySeconds) : (__TimecodesBase is { } __TimecodesfrequencySecondsBaseValue ? __TimecodesfrequencySecondsBaseValue.FrequencySeconds : default);
                        var timecodesOnParagraphs = CliRuntime.WasSpecified(parseResult, TimecodesOptions.OnParagraphs) ? parseResult.GetValue(TimecodesOptions.OnParagraphs) : (__TimecodesBase is { } __TimecodesonParagraphsBaseValue ? __TimecodesonParagraphsBaseValue.OnParagraphs : default);
                        var timecodesOnSpeakers = CliRuntime.WasSpecified(parseResult, TimecodesOptions.OnSpeakers) ? parseResult.GetValue(TimecodesOptions.OnSpeakers) : (__TimecodesBase is { } __TimecodesonSpeakersBaseValue ? __TimecodesonSpeakersBaseValue.OnSpeakers : default);
                        var timecodesOnMarkers = CliRuntime.WasSpecified(parseResult, TimecodesOptions.OnMarkers) ? parseResult.GetValue(TimecodesOptions.OnMarkers) : (__TimecodesBase is { } __TimecodesonMarkersBaseValue ? __TimecodesonMarkersBaseValue.OnMarkers : default);
                        var timecodesOffsetSeconds = CliRuntime.WasSpecified(parseResult, TimecodesOptions.OffsetSeconds) ? parseResult.GetValue(TimecodesOptions.OffsetSeconds) : (__TimecodesBase is { } __TimecodesoffsetSecondsBaseValue ? __TimecodesoffsetSecondsBaseValue.OffsetSeconds : default);
                        var __TimecodesSpecified = CliRuntime.WasSpecified(parseResult, TimecodesOptions.FrequencySeconds) || CliRuntime.WasSpecified(parseResult, TimecodesOptions.OnParagraphs) || CliRuntime.WasSpecified(parseResult, TimecodesOptions.OnSpeakers) || CliRuntime.WasSpecified(parseResult, TimecodesOptions.OnMarkers) || CliRuntime.WasSpecified(parseResult, TimecodesOptions.OffsetSeconds);
                        var timecodes =
                            __TimecodesSpecified || __TimecodesBase is not null
                                ? new global::Descript.ExportTranscriptRequestTimecodes
                                {
	                                FrequencySeconds = timecodesFrequencySeconds,
                                OnParagraphs = timecodesOnParagraphs,
                                OnSpeakers = timecodesOnSpeakers,
                                OnMarkers = timecodesOnMarkers,
                                OffsetSeconds = timecodesOffsetSeconds,

                                }
                                : __TimecodesBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiEndpoints.ExportTranscriptAsBytesAsync(
                                    projectId: projectId,
                                    compositionId: compositionId,
                                    format: format,
                                    includeSpeakerLabels: includeSpeakerLabels,
                                    includeMarkers: includeMarkers,
                                    timecodes: timecodes,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}