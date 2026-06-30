#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ApiEndpointsPublishJobCommandApiCommand
{
    private static Option<global::System.Guid> ProjectId { get; } = new(
        name: @"--project-id")
    {
        Description = @"The ID of the project to publish.",
        Required = true,
    };

    private static Option<global::System.Guid?> CompositionId { get; } = new(
        name: @"--composition-id")
    {
        Description = @"The ID of the composition within the project to publish.",
    };

    private static Option<global::Descript.PublishJobRequestMediaType?> MediaType { get; } = new(
        name: @"--media-type")
    {
        Description = @"Media type of the published output. Defaults to `Video` when omitted.

If the target composition has no video content:
- omitting `media_type` publishes it as `Audio`
  (the completed job result reports `media_type: Audio`),
- explicitly requesting `Video` is rejected with a 422.
",
    };

    private static Option<global::Descript.PublishJobRequestResolution?> Resolution { get; } = new(
        name: @"--resolution")
    {
        Description = @"Resolution for the published output. Only applicable when media_type is Video.",
    };

    private static Option<string?> CallbackUrl { get; } = new(
        name: @"--callback-url")
    {
        Description = @"Optional webhook URL to call when the job completes or fails.
Descript will POST the job status (same format as [GET /jobs/{job_id}](#operation/getJob)) to this URL.
",
    };

    private static Option<global::Descript.PublishJobRequestAccessLevel?> AccessLevel { get; } = new(
        name: @"--access-level")
    {
        Description = @"Desired access level for the published share page.
If omitted, the drive's configured default is used.
Returns 403 if the requested level is not permitted by the drive's publish settings
(e.g. requesting `public` when search engine indexing is disabled).
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

                    private static string FormatResponse(ParseResult parseResult, global::Descript.PublishJobResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Descript.PublishJobResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"publish-job", @"Publish project media
Publish a project composition to create a shareable link and download the exported file.

Publishes a specific composition from a project, rendering the output as video or audio
at the specified resolution. When the job completes successfully the result contains both:

- `share_url`: a public URL that can be used to view the published content on Descript's share site.
- `download_url`: a time-limited signed URL to download the exported media file directly,
  along with `download_url_expires_at` indicating when the link expires.

### Republishing

Publishing the same composition a second time automatically reuses the previous share URL,
overwriting its content — so bookmarks and links handed out for the first publish keep working.
Republish matching is keyed on `(project_id, composition_id, media_type)`, so a Video publish
and an Audio publish of the same composition produce two separate share URLs.

### Async Operations

Publish jobs run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint,
which returns the `share_url`, `download_url`, and `download_url_expires_at` fields once the job finishes.

### Dynamic webhook

If `callback_url` is provided, Descript will POST the job status to that URL when the job completes or fails.
The payload will match the format returned by [GET /jobs/{job_id}](#operation/getJob).
");
                        command.Options.Add(ProjectId);
                        command.Options.Add(CompositionId);
                        command.Options.Add(MediaType);
                        command.Options.Add(Resolution);
                        command.Options.Add(CallbackUrl);
                        command.Options.Add(AccessLevel);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Descript.PublishJobRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Descript.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var compositionId = CliRuntime.WasSpecified(parseResult, CompositionId) ? parseResult.GetValue(CompositionId) : (__requestBase is { } __CompositionIdBaseValue ? __CompositionIdBaseValue.CompositionId : default);
                        var mediaType = CliRuntime.WasSpecified(parseResult, MediaType) ? parseResult.GetValue(MediaType) : (__requestBase is { } __MediaTypeBaseValue ? __MediaTypeBaseValue.MediaType : default);
                        var resolution = CliRuntime.WasSpecified(parseResult, Resolution) ? parseResult.GetValue(Resolution) : (__requestBase is { } __ResolutionBaseValue ? __ResolutionBaseValue.Resolution : default);
                        var callbackUrl = CliRuntime.WasSpecified(parseResult, CallbackUrl) ? parseResult.GetValue(CallbackUrl) : (__requestBase is { } __CallbackUrlBaseValue ? __CallbackUrlBaseValue.CallbackUrl : default);
                        var accessLevel = CliRuntime.WasSpecified(parseResult, AccessLevel) ? parseResult.GetValue(AccessLevel) : (__requestBase is { } __AccessLevelBaseValue ? __AccessLevelBaseValue.AccessLevel : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiEndpoints.PublishJobAsync(
                                    projectId: projectId,
                                    compositionId: compositionId,
                                    mediaType: mediaType,
                                    resolution: resolution,
                                    callbackUrl: callbackUrl,
                                    accessLevel: accessLevel,
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