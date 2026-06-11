#nullable enable

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(APIEndpointsApiGroupCommand.Create());
                         command.Subcommands.Add(EditInDescriptApiGroupCommand.Create());
                         command.Subcommands.Add(ExportFromDescriptApiGroupCommand.Create());
        return command;
    }
}