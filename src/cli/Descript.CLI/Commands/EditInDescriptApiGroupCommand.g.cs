#nullable enable

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class EditInDescriptApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"edit-in-descript", @"Edit in Descript endpoint commands.");
                         command.Subcommands.Add(EditInDescriptPostEditInDescriptSchemaCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}