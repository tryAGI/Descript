#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ApiEndpointsListAgentModelsCommandApiCommand
{


                    private static string FormatResponse(ParseResult parseResult, global::Descript.ListAgentModelsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Descript.ListAgentModelsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-agent-models", @"List agent models
List the currently available agent models and the aliases that resolve to them.

The `model` parameter on [POST /jobs/agent](#operation/agentEditJob) accepts any
value listed under `availableModels[].id` or `aliases[].id`. Aliases let you target
the latest
recommended model for a given tier without chasing version bumps — for example,
passing `claude-opus` always routes to whichever Claude Opus version Descript
currently recommends.

Cost tiers are coarse buckets — `low`, `medium`, `high` — useful for showing
users a relative price/performance signal. Exact pricing is reported per job via
the `ai_credits_used` field on [GET /jobs/{job_id}](#operation/getJob).

When `model` is omitted on `POST /jobs/agent`, the request defaults to `auto`, which
selects a recommended model for your account. `auto` is a `medium`-cost option. For an
`auto` request, `result.resolved_model` on [GET /jobs/{job_id}](#operation/getJob) reports
`auto`; for an explicit model or alias it reports the canonical id that ran.
");



        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {

                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiEndpoints.ListAgentModelsAsync(

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