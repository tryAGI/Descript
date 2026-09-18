#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ApiEndpointsSearchCommandApiCommand
{
    private static Option<string> Query { get; } = new(
        name: @"--query")
    {
        Description = @"Search term. Matched against names and contents. Must be non-empty.
",
        Required = true,
    };

    private static Option<global::System.DateTime?> UpdatedAfter { get; } = new(
        name: @"--updated-after")
    {
        Description = @"Return results updated at or after this time. Accepts an ISO 8601
date (`2026-08-01`, interpreted as the start of that UTC day) or
timestamp (`2026-08-01T09:30:00Z`). Values without a timezone
offset are read as UTC.
",
    };

    private static Option<global::System.DateTime?> UpdatedBefore { get; } = new(
        name: @"--updated-before")
    {
        Description = @"Return results updated at or before this time. Accepts an ISO 8601
date (`2026-08-01`, interpreted as the end of that UTC day) or
timestamp (`2026-08-01T23:59:59Z`). Values without a timezone
offset are read as UTC.
",
    };

    private static Option<global::System.Collections.Generic.IList<global::System.Guid>?> Owner { get; } = new(
        name: @"--owner")
    {
        Description = @"Return items owned by these user UUIDs. Repeat this parameter to
include more than one owner. If omitted, results from all owners
are returned.
",
    };

    private static Option<global::System.Collections.Generic.IList<global::Descript.SearchTypeItem>?> Type { get; } = new(
        name: @"--type")
    {
        Description = @"Result types to search. Repeat this parameter to search more than
one type. If omitted, all result types are returned.

- `project`: Projects
- `layout_pack`: Layout packs
- `project_folder`: Folders that hold projects
- `media_library_folder`: Folders in the drive media library
- `video`, `image`, `audio`: Files of that media type in the drive
   media library, Brand Studio, and inside projects
",
    };

    private static Option<global::System.Collections.Generic.IList<global::Descript.SearchMatchItem>?> Match { get; } = new(
        name: @"--match")
    {
        Description = @"How the query may match. Repeat this parameter to allow more than
one kind. `name` matches project, file, folder, and layout pack
names. `content` matches transcripts and composition text. If
omitted, names and contents both contribute.
",
    };

    private static Option<global::Descript.SearchSort?> Sort { get; } = new(
        name: @"--sort")
    {
        Description = @"How to sort results:

- `relevance`: closest matches first. This is the default.
- `newest`: most recently modified first.
- `oldest`: least recently modified first.
",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of results to return. Defaults to 30. Maximum is
100.
",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Descript.SearchResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Descript.SearchResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"search", @"Search a drive
Search the drive tied to the personal API token. Matches project names,
folder names, layout pack names, media file names, composition text,
and transcripts across projects, the drive media library, and Brand
Studio. Returns up to 100 results ranked by relevance.
");
                        command.Options.Add(Query);
                        command.Options.Add(UpdatedAfter);
                        command.Options.Add(UpdatedBefore);
                        command.Options.Add(Owner);
                        command.Options.Add(Type);
                        command.Options.Add(Match);
                        command.Options.Add(Sort);
                        command.Options.Add(Limit);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var query = parseResult.GetRequiredValue(Query);
                        var updatedAfter = parseResult.GetValue(UpdatedAfter);
                        var updatedBefore = parseResult.GetValue(UpdatedBefore);
                        var owner = parseResult.GetValue(Owner);
                        var type = parseResult.GetValue(Type);
                        var match = parseResult.GetValue(Match);
                        var sort = parseResult.GetValue(Sort);
                        var limit = parseResult.GetValue(Limit);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiEndpoints.SearchAsync(
                                    query: query,
                                    updatedAfter: updatedAfter,
                                    updatedBefore: updatedBefore,
                                    owner: owner,
                                    type: type,
                                    match: match,
                                    sort: sort,
                                    limit: limit,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Descript.SourceGenerationContext.Default,
                                        @"Results",
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