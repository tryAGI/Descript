#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ExportFromDescriptGetPublishedProjectMetadataCommandApiCommand
{
    private static Argument<string> PublishedProjectSlug { get; } = new(
        name: @"published-project-slug")
    {
        Description = @"The unique URL slug identifying the published project",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Descript.PublishedProjectMetadata value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Descript.PublishedProjectMetadata value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-published-project-metadata", @"Get Published Project Metadata
Retrieve metadata for a published Descript project by its URL slug. This endpoint provides information
about the published project including title, duration, publisher details, privacy settings, and subtitles.

This endpoint requires authentication using a personal token and is subject to rate limiting of 1000
requests per hour per user.
");
                        command.Arguments.Add(PublishedProjectSlug);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var publishedProjectSlug = parseResult.GetRequiredValue(PublishedProjectSlug);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ExportFromDescript.GetPublishedProjectMetadataAsync(
                                    publishedProjectSlug: publishedProjectSlug,
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