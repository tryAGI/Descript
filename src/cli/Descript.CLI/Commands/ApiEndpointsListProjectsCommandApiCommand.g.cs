#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ApiEndpointsListProjectsCommandApiCommand
{
    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Filter projects whose name contains this string (case-insensitive).",
    };

    private static Option<string?> FolderPath { get; } = new(
        name: @"--folder-path")
    {
        Description = @"Filter projects by folder path (e.g. ""Clients/Acme/Videos""). Use ""/"" to separate nested folders. Returns only projects directly inside the deepest folder.",
    };

    private static Option<string?> CreatedBy { get; } = new(
        name: @"--created-by")
    {
        Description = @"Filter projects created by this user UUID. Pass `me` to filter by the authenticated user.",
    };

    private static Option<global::System.DateTime?> CreatedAfter { get; } = new(
        name: @"--created-after")
    {
        Description = @"Filter projects created after this ISO 8601 timestamp.",
    };

    private static Option<global::System.DateTime?> CreatedBefore { get; } = new(
        name: @"--created-before")
    {
        Description = @"Filter projects created before this ISO 8601 timestamp.",
    };

    private static Option<global::System.DateTime?> UpdatedAfter { get; } = new(
        name: @"--updated-after")
    {
        Description = @"Filter projects updated after this ISO 8601 timestamp.",
    };

    private static Option<global::System.DateTime?> UpdatedBefore { get; } = new(
        name: @"--updated-before")
    {
        Description = @"Filter projects updated before this ISO 8601 timestamp.",
    };

    private static Option<global::Descript.ListProjectsSort?> Sort { get; } = new(
        name: @"--sort")
    {
        Description = @"Sort field. Defaults to created_at.",
    };

    private static Option<global::Descript.ListProjectsDirection?> Direction { get; } = new(
        name: @"--direction")
    {
        Description = @"Sort direction. Defaults to desc.",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Pagination cursor from a previous response's `pagination.next_cursor`.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of projects per page (1-100). Defaults to 20.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Descript.ListProjectsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Descript.ListProjectsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-projects", @"List projects
List projects accessible to the authenticated user within a drive.

The drive is determined from the access token.

Results are paginated. Use the `cursor` from the response `pagination.next_cursor`
to fetch subsequent pages.
");
                        command.Options.Add(NameOption);
                        command.Options.Add(FolderPath);
                        command.Options.Add(CreatedBy);
                        command.Options.Add(CreatedAfter);
                        command.Options.Add(CreatedBefore);
                        command.Options.Add(UpdatedAfter);
                        command.Options.Add(UpdatedBefore);
                        command.Options.Add(Sort);
                        command.Options.Add(Direction);
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var name = parseResult.GetValue(NameOption);
                        var folderPath = parseResult.GetValue(FolderPath);
                        var createdBy = parseResult.GetValue(CreatedBy);
                        var createdAfter = parseResult.GetValue(CreatedAfter);
                        var createdBefore = parseResult.GetValue(CreatedBefore);
                        var updatedAfter = parseResult.GetValue(UpdatedAfter);
                        var updatedBefore = parseResult.GetValue(UpdatedBefore);
                        var sort = parseResult.GetValue(Sort);
                        var direction = parseResult.GetValue(Direction);
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiEndpoints.ListProjectsAsync(
                                    name: name,
                                    folderPath: folderPath,
                                    createdBy: createdBy,
                                    createdAfter: createdAfter,
                                    createdBefore: createdBefore,
                                    updatedAfter: updatedAfter,
                                    updatedBefore: updatedBefore,
                                    sort: sort,
                                    direction: direction,
                                    cursor: cursor,
                                    limit: limit,
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