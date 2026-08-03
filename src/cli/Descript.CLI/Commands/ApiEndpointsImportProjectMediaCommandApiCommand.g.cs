#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ApiEndpointsImportProjectMediaCommandApiCommand
{
    private static Option<global::System.Guid?> ProjectId { get; } = new(
        name: @"--project-id")
    {
        Description = @"Existing project ID to import media into. If not provided, a new project will be created.
When importing into an existing project, media filenames must not conflict with existing files.
",
    };

    private static Option<string?> ProjectName { get; } = new(
        name: @"--project-name")
    {
        Description = @"Name for the new project. Only used when project_id is not provided.",
    };

    private static Option<global::Descript.ImportProjectMediaRequestTeamAccess?> TeamAccess { get; } = new(
        name: @"--team-access")
    {
        Description = @"Access level for drive members. Only applicable when creating a new project
(when project_id is not provided). Defaults to `none` if not specified.
- edit: Users can edit the project
- comment: Users can view and comment but not edit
- view: Users can view but not comment or edit
- none: No shared access (private to owner)
",
    };

    private static Option<string?> FolderName { get; } = new(
        name: @"--folder-name")
    {
        Description = @"Folder path to place the new project in (e.g. ""Clients/Acme/Videos"").
Supports nested paths using ""/"" as separator. Only applicable when creating a new project
(when project_id is not provided). Existing folders along the path are reused; missing
segments are created automatically.
",
    };

    private static Option<string?> WorkspaceName { get; } = new(
        name: @"--workspace-name")
    {
        Description = @"Existing workspace to create the new project in, matched by name (case-insensitive).
Only applicable when creating a new project (when project_id is not provided).

Reserved names: `Personal` (your private space) and `General` (the shared drive workspace).
Any other value is looked up as a custom workspace name; unknown names return 404.

When omitted, `team_access` is passed through unchanged.
When set to `Personal`, `team_access` must be `none` or omitted.
When set to `General` or a custom workspace name, `team_access` must be
`edit`, `comment`, or `view`; omitting it defaults to `view`, and `none` is rejected.

For custom workspaces, the caller must be a member of that workspace.
",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, global::Descript.OneOf<global::Descript.ImportProjectMediaRequestAddMediaUrlImport, global::Descript.ImportProjectMediaRequestAddMediaDirectUpload, global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequence>>?> AddMedia { get; } = new(
        name: @"--add-media")
    {
        Description = @"Map of media reference IDs (display names with optional folder paths) to media import items.
Keys are the display names that will appear in the project (e.g., ""Misc/intro.mp4"" or ""demo.mp4"").
Values define how to import each media item (URL import or multitrack sequence).
",
    };

    private static Option<global::System.Collections.Generic.IList<global::Descript.ImportProjectMediaRequestAddComposition>?> AddCompositions { get; } = new(
        name: @"--add-compositions")
    {
        Description = @"Optional list of compositions to create in the project",
    };

    private static Option<string?> CallbackUrl { get; } = new(
        name: @"--callback-url")
    {
        Description = @"Optional webhook URL to call when the job completes or fails.
Descript will POST the job status (same format as [GET /jobs/{job_id}](#operation/getJob)) to this URL.
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

                    private static string FormatResponse(ParseResult parseResult, global::Descript.ImportProjectMediaResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Descript.ImportProjectMediaResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"import-project-media", @"Import media and sequences
Import media files into a new or existing project and create compositions.

This endpoint can:
- Create a new project if `project_id` is not provided
- Import media files from URLs
- Create multitrack sequences
- Create compositions (timelines) from existing or new media in the project
- Trigger transcription and other background processing tasks

### Media URL requirements
- URLs must be accessible by Descript servers
- URLs must support HTTP Range requests
- Recommended to sign URLs for 12-48 hours to reduce chance of failure
- [Supported file types](https://help.descript.com/hc/en-us/articles/10164098416909-Supported-file-types)

### Direct file upload

Instead of providing a URL, you can upload files directly by specifying `content_type` and `file_size` for a media item. The response will include a signed `upload_url` for each direct upload item. PUT the file bytes to that URL, and the import job will process it automatically. See the [Direct file upload](#tag/Direct-file-upload) guide for a full walkthrough.

### Async Operations

Imports run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint.

### Dynamic webhook

If `callback_url` is provided, Descript will POST the job status to that URL when the job finishes (successfully or not).

The payload will match the format returned by [GET /jobs/{job_id}](#operation/getJob).
");
                        command.Options.Add(ProjectId);
                        command.Options.Add(ProjectName);
                        command.Options.Add(TeamAccess);
                        command.Options.Add(FolderName);
                        command.Options.Add(WorkspaceName);
                        command.Options.Add(AddMedia);
                        command.Options.Add(AddCompositions);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Descript.ImportProjectMediaRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Descript.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = CliRuntime.WasSpecified(parseResult, ProjectId) ? parseResult.GetValue(ProjectId) : (__requestBase is { } __ProjectIdBaseValue ? __ProjectIdBaseValue.ProjectId : default);
                        var projectName = CliRuntime.WasSpecified(parseResult, ProjectName) ? parseResult.GetValue(ProjectName) : (__requestBase is { } __ProjectNameBaseValue ? __ProjectNameBaseValue.ProjectName : default);
                        var teamAccess = CliRuntime.WasSpecified(parseResult, TeamAccess) ? parseResult.GetValue(TeamAccess) : (__requestBase is { } __TeamAccessBaseValue ? __TeamAccessBaseValue.TeamAccess : default);
                        var folderName = CliRuntime.WasSpecified(parseResult, FolderName) ? parseResult.GetValue(FolderName) : (__requestBase is { } __FolderNameBaseValue ? __FolderNameBaseValue.FolderName : default);
                        var workspaceName = CliRuntime.WasSpecified(parseResult, WorkspaceName) ? parseResult.GetValue(WorkspaceName) : (__requestBase is { } __WorkspaceNameBaseValue ? __WorkspaceNameBaseValue.WorkspaceName : default);
                        var addMedia = CliRuntime.WasSpecified(parseResult, AddMedia) ? parseResult.GetValue(AddMedia) : (__requestBase is { } __AddMediaBaseValue ? __AddMediaBaseValue.AddMedia : default);
                        var addCompositions = CliRuntime.WasSpecified(parseResult, AddCompositions) ? parseResult.GetValue(AddCompositions) : (__requestBase is { } __AddCompositionsBaseValue ? __AddCompositionsBaseValue.AddCompositions : default);
                        var callbackUrl = CliRuntime.WasSpecified(parseResult, CallbackUrl) ? parseResult.GetValue(CallbackUrl) : (__requestBase is { } __CallbackUrlBaseValue ? __CallbackUrlBaseValue.CallbackUrl : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiEndpoints.ImportProjectMediaAsync(
                                    projectId: projectId,
                                    projectName: projectName,
                                    teamAccess: teamAccess,
                                    folderName: folderName,
                                    workspaceName: workspaceName,
                                    addMedia: addMedia,
                                    addCompositions: addCompositions,
                                    callbackUrl: callbackUrl,
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