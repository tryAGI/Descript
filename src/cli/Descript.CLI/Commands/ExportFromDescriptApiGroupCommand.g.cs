#nullable enable

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class ExportFromDescriptApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"export-from-descript", @"Export from Descript endpoint commands.");
                         command.Subcommands.Add(ExportFromDescriptGetPublishedProjectMetadataCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}