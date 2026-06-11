#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ApiEndpointsAgentEditJobCommandApiCommand
{
    private static Option<global::System.Guid?> ProjectId { get; } = new(
        name: @"--project-id")
    {
        Description = @"The ID of an existing project to edit. Mutually exclusive with `project_name`.
",
    };

    private static Option<string?> ProjectName { get; } = new(
        name: @"--project-name")
    {
        Description = @"Name for creating a new project. Mutually exclusive with `project_id`.
",
    };

    private static Option<string?> CompositionId { get; } = new(
        name: @"--composition-id")
    {
        Description = @"Composition to target within the project. When provided,
the agent will focus its edits on this specific composition rather
than choosing one automatically. Only valid when `project_id` is also
provided. Requires `project_id`.

Accepts any of the following formats:
- A full composition UUID (e.g. `39677a40-1c43-4c36-8449-46cfbc4de2b5`)
- A 5-character short ID from a Descript URL (e.g. `39677`)
- A full Descript project URL (e.g. `https://web.descript.com/{project_id}/39677`)
",
    };

    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"AI model to use for editing. Defaults to the default model.
",
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Natural language instruction for the agent to execute.
Examples: ""add studio sound to every clip"", ""remove all filler words"", ""create a 30-second highlight reel""
",
        Required = true,
    };

    private static Option<global::Descript.AgentEditJobRequestTeamAccess?> TeamAccess { get; } = new(
        name: @"--team-access")
    {
        Description = @"Access level for team members when creating a new project.
Only applicable when `project_name` is provided (not when using `project_id`).
Defaults to `none` if not specified.
",
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

                    private static string FormatResponse(ParseResult parseResult, global::Descript.AgentEditJobResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Descript.AgentEditJobResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"agent-edit-job", @"Agent edit
Use a background agent to create and edit projects using a natural language prompt.

- **Edit existing project**: Provide a `project_id` to edit an existing project
- **Target a specific composition**: Provide both `project_id` and `composition_id` to direct the agent to a specific composition within the project
- **Create new project**: Provide a `project_name` instead of `project_id` to create a new project

### Common use cases
- Create new content: ""create a 30-second video about cooking tips""
- Apply audio effects: ""add studio sound to every clip""
- Remove filler words: ""remove all filler words from the transcript""
- Create highlights: ""create a 30-second highlight reel""
- Content editing: ""remove the section from 1:30 to 2:15""

### Async Operations

Agent edits run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint.

### Dynamic webhook

If `callback_url` is provided, Descript will POST the job status to that URL when the job completes or fails.
The payload will match the format returned by [GET /jobs/{job_id}](#operation/getJob).
");
                        command.Options.Add(ProjectId);
                        command.Options.Add(ProjectName);
                        command.Options.Add(CompositionId);
                        command.Options.Add(Model);
                        command.Options.Add(Prompt);
                        command.Options.Add(TeamAccess);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Descript.AgentEditJobRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Descript.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = CliRuntime.WasSpecified(parseResult, ProjectId) ? parseResult.GetValue(ProjectId) : __requestBase is not null ? __requestBase.ProjectId : default;
                        var projectName = CliRuntime.WasSpecified(parseResult, ProjectName) ? parseResult.GetValue(ProjectName) : __requestBase is not null ? __requestBase.ProjectName : default;
                        var compositionId = CliRuntime.WasSpecified(parseResult, CompositionId) ? parseResult.GetValue(CompositionId) : __requestBase is not null ? __requestBase.CompositionId : default;
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : __requestBase is not null ? __requestBase.Model : default;
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var teamAccess = CliRuntime.WasSpecified(parseResult, TeamAccess) ? parseResult.GetValue(TeamAccess) : __requestBase is not null ? __requestBase.TeamAccess : default;
                        var callbackUrl = CliRuntime.WasSpecified(parseResult, CallbackUrl) ? parseResult.GetValue(CallbackUrl) : __requestBase is not null ? __requestBase.CallbackUrl : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiEndpoints.AgentEditJobAsync(
                                    projectId: projectId,
                                    projectName: projectName,
                                    compositionId: compositionId,
                                    model: model,
                                    prompt: prompt,
                                    teamAccess: teamAccess,
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