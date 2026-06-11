#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ApiEndpointsListJobsCommandApiCommand
{
    private static Option<global::System.Guid?> ProjectId { get; } = new(
        name: @"--project-id")
    {
        Description = @"Filter by project ID",
    };

    private static Option<global::Descript.ListJobsType?> Type { get; } = new(
        name: @"--type")
    {
        Description = @"Filter by job type",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Cursor for the next page of results, obtained from `pagination.next_cursor` in a previous response",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of items per page (1-100). Defaults to 20.",
    };

    private static Option<global::System.DateTime?> CreatedAfter { get; } = new(
        name: @"--created-after")
    {
        Description = @"Filter jobs created after this timestamp (ISO 8601). Default: 7 days ago. Oldest allowed: 30 days ago.",
    };

    private static Option<global::System.DateTime?> CreatedBefore { get; } = new(
        name: @"--created-before")
    {
        Description = @"Filter jobs created before this timestamp (ISO 8601). Default: now.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Descript.ListJobsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Descript.ListJobsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-jobs", @"List jobs
List recent jobs with optional filtering by project or job type.

By default, jobs created within the last 7 days are returned. Use `created_after` and
`created_before` to customize the time range. The maximum lookback is 30 days.

Results are paginated. Use the `cursor` from the response `pagination.next_cursor` to
fetch subsequent pages.

Query parameters allow you to filter the results:
* Filter by `project_id` to see all jobs for a project
* Filter by `type` to see specific job types (import/project_media, agent)
");
                        command.Options.Add(ProjectId);
                        command.Options.Add(Type);
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(CreatedAfter);
                        command.Options.Add(CreatedBefore);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetValue(ProjectId);
                        var type = parseResult.GetValue(Type);
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var createdAfter = parseResult.GetValue(CreatedAfter);
                        var createdBefore = parseResult.GetValue(CreatedBefore);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiEndpoints.ListJobsAsync(
                                    projectId: projectId,
                                    type: type,
                                    cursor: cursor,
                                    limit: limit,
                                    createdAfter: createdAfter,
                                    createdBefore: createdBefore,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Descript.SourceGenerationContext.Default,
                                        @"Data",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Descript.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}