#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ApiEndpointsGetProjectCommandApiCommand
{
    private static Argument<global::System.Guid> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The project UUID",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Descript.GetProjectResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Descript.GetProjectResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-project", @"Get project details
Get a detailed project summary including all media files, compositions,
and existing publishes.

Returns the project's id, name, drive_id, a map of media files (keyed by
display path) with type and duration, a list of compositions with id,
name, duration, and media type, and a list of successfully published
share pages with their URLs, access levels, and publish times.

Use this to inspect a project's contents before editing or importing media,
or to retrieve existing share URLs without triggering a republish.
");
                        command.Arguments.Add(ProjectId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiEndpoints.GetProjectAsync(
                                    projectId: projectId,
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