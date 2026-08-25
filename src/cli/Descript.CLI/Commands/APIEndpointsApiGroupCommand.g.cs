#nullable enable

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static class APIEndpointsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"api-endpoints", @"API Endpoints endpoint commands.");
                         command.Subcommands.Add(ApiEndpointsAgentEditJobCommandApiCommand.Create());
                         command.Subcommands.Add(ApiEndpointsCancelJobCommandApiCommand.Create());
                         command.Subcommands.Add(ApiEndpointsExportTranscriptCommandApiCommand.Create());
                         command.Subcommands.Add(ApiEndpointsExportTranscriptAsBytesCommandApiCommand.Create());
                         command.Subcommands.Add(ApiEndpointsGetJobCommandApiCommand.Create());
                         command.Subcommands.Add(ApiEndpointsGetProjectCommandApiCommand.Create());
                         command.Subcommands.Add(ApiEndpointsGetStatusCommandApiCommand.Create());
                         command.Subcommands.Add(ApiEndpointsImportProjectMediaCommandApiCommand.Create());
                         command.Subcommands.Add(ApiEndpointsListAgentModelsCommandApiCommand.Create());
                         command.Subcommands.Add(ApiEndpointsListJobsCommandApiCommand.Create());
                         command.Subcommands.Add(ApiEndpointsListProjectsCommandApiCommand.Create());
                         command.Subcommands.Add(ApiEndpointsPublishJobCommandApiCommand.Create());
        return command;
    }
}