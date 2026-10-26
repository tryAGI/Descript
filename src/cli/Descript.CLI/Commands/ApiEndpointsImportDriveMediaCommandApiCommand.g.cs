#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ApiEndpointsImportDriveMediaCommandApiCommand
{
    private static Option<string?> FolderId { get; } = new(
        name: @"--folder-id")
    {
        Description = @"Target drive media folder ID (UUID) or ""root"" for the root folder. If not provided, defaults to root.",
    };

    private static Option<object> AddMedia { get; } = new(
        name: @"--add-media")
    {
        Description = @"Map of media reference IDs to their import definitions. Key is the display name
or path (e.g. ""video.mp4"" or ""Folder/SubFolder/video.mp4""). Paths with forward
slashes create nested folders automatically.
",
        Required = true,
    };

    private static Option<string?> CallbackUrl { get; } = new(
        name: @"--callback-url")
    {
        Description = @"Optional callback URL to receive notifications about job status changes.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Descript.DriveMediaImportResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Descript.DriveMediaImportResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"import-drive-media", @"Import media to drive library
Import media files into the drive media library (shared workspace-level media collection).

Unlike project media import, this endpoint adds files to the drive's shared media library
rather than to a specific project. Files can optionally be placed in a folder.

### Media URL requirements
- URLs must be accessible by Descript servers
- URLs must support HTTP Range requests
- Recommended to sign URLs for 12-48 hours to reduce chance of failure
- [Supported file types](https://help.descript.com/add-and-manage-media/supported-file-types)

### Direct file upload

Instead of providing a URL, you can upload files directly by specifying `content_type` and `file_size` for a media item. The response will include a signed `upload_url` for each direct upload item. PUT the file bytes to that URL, and the import job will process it automatically. See the [Direct file upload](#tag/Direct-file-upload) guide for a full walkthrough.

### Async Operations

Imports run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint.

### Dynamic webhook

If `callback_url` is provided, Descript will POST the job status to that URL when the job finishes (successfully or not).
");
                        command.Options.Add(FolderId);
                        command.Options.Add(AddMedia);
                        command.Options.Add(CallbackUrl);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Descript.DriveMediaImportRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Descript.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var folderId = CliRuntime.WasSpecified(parseResult, FolderId) ? parseResult.GetValue(FolderId) : (__requestBase is { } __FolderIdBaseValue ? __FolderIdBaseValue.FolderId : default);
                        var addMedia = parseResult.GetRequiredValue(AddMedia);
                        var callbackUrl = CliRuntime.WasSpecified(parseResult, CallbackUrl) ? parseResult.GetValue(CallbackUrl) : (__requestBase is { } __CallbackUrlBaseValue ? __CallbackUrlBaseValue.CallbackUrl : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiEndpoints.ImportDriveMediaAsync(
                                    folderId: folderId,
                                    addMedia: addMedia,
                                    callbackUrl: callbackUrl,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Descript.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}