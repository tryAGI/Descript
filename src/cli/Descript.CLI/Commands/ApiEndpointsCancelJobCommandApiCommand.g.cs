#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ApiEndpointsCancelJobCommandApiCommand
{
    private static Argument<global::System.Guid> JobId { get; } = new(
        name: @"job-id")
    {
        Description = @"The job ID",
    };

    public static Command Create()
    {
        var command = new Command(@"cancel-job", @"Cancel job
Cancel a running job.
");
                        command.Arguments.Add(JobId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var jobId = parseResult.GetRequiredValue(JobId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.ApiEndpoints.CancelJobAsync(
                                    jobId: jobId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}