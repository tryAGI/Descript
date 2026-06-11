#nullable enable

using System.CommandLine;
using Descript.CLI;
using Descript.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the Descript SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(APIEndpointsApiGroupCommand.Create());
rootCommand.Subcommands.Add(EditInDescriptApiGroupCommand.Create());
rootCommand.Subcommands.Add(ExportFromDescriptApiGroupCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);