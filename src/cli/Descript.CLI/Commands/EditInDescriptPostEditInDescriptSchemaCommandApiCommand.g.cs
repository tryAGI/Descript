#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Descript.CLI.Commands;

internal static partial class EditInDescriptPostEditInDescriptSchemaCommandApiCommand
{
    private static Option<global::System.Guid> PartnerDriveId { get; } = new(
        name: @"--partner-drive-id")
    {
        Description = @"The drive id associated with the auth token.",
        Required = true,
    };

    private static Option<global::Descript.EditInDescriptSchemaPostBodyProjectSchema> ProjectSchema { get; } = new(
        name: @"--project-schema")
    {
        Description = @"The Project schema",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Descript.EditInDescriptSchemaPostResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Descript.EditInDescriptSchemaPostResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-edit-in-descript-schema", @"Create Import URL
Create an Import URL by sending a Project schema to Descript API from your service's backend.

### Import Schema
Our import schemas are specified as a minimal JSON list of files which is detailed in full at the bottom of this
section. At it's smallest, the request body looks like:

```
{
  ""partner_drive_id"": ""162c61d1-6ced-4b25-a622-7dba922983ee"",
  ""project_schema"": {
    ""schema_version"": ""1.0.0"",
    ""files"": [{""uri"": ""https://descriptusercontent.com/jane.wav?signature=d182bca64bf94a1483d2fd16b579f955""}]
  }
}
```

### File Access
The file paths provided in the schema need to either be public or pre-signed URIs with enough time before
expiration for failures and retries, we suggest URIs that won't expire for 48 hours. We ask that the files have
already been saved when the import link is generated to minimize cases where we're waiting for eventually
consistent storage of files that will never be written. We will, however, wait for eventual consistency of the
storage layer and retry fetching files before eventually timing out.

Files must be hosted on preapproved hosts as our import process has an allow list which it checks URIs against.
Files will be requested with `User-Agent: Descriptbot/1.0` (version may change) for tracking purposes.

### Import link expiration
Import links are no longer valid after a user imports their data once. Viewing an already used import link will
not allow for importing again and will not provide access to a previously created Descript Project. Partners are
able to generate a new import link at any time, regardless of if a previous import link has been used.

The API does not currently provide partners with a link to the Descript Project, though users will be redirected
to it from Descript's web interface the first time they import files, and can always find the Project in Descript.

Import links expire after 3 hours and attempting to use an import link after the pre-signed links in the schema
file have expired will result in an error, so we recommend generating the import link after the user has clicked
the Edit in Descript button.

### Supported media specification
We recommend sending the highest quality, uncompressed versions of files available to you. If you have multiple
tracks, we recommend prioritizing sending us the full multi-track sequence over a combined file.

* Audio: WAV, FLAC, AAC, MP3
* Video: h264, HEVC (container: MOV, MP4)
");
                        command.Options.Add(PartnerDriveId);
                        command.Options.Add(ProjectSchema);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var partnerDriveId = parseResult.GetRequiredValue(PartnerDriveId);
                        var projectSchema = parseResult.GetRequiredValue(ProjectSchema);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditInDescript.PostEditInDescriptSchemaAsync(
                                    partnerDriveId: partnerDriveId,
                                    projectSchema: projectSchema,
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