#nullable enable

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static class EditInDescriptApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"edit-in-descript", @"Edit in Descript endpoint commands.");
                         command.Subcommands.Add(EditInDescriptPostEditInDescriptSchemaCommandApiCommand.Create());
        return command;
    }
}