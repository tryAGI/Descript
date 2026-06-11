#nullable enable

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static class ExportFromDescriptApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"export-from-descript", @"Export from Descript endpoint commands.");
                         command.Subcommands.Add(ExportFromDescriptGetPublishedProjectMetadataCommandApiCommand.Create());
        return command;
    }
}