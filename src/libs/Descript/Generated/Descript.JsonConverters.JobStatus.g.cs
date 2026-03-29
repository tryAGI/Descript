#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public class JobStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.JobStatus>
    {
        /// <inheritdoc />
        public override global::Descript.JobStatus Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.JobStatusDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.JobStatusDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Descript.JobStatusDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Descript.ImportJobStatus? importDivideprojectMedia = default;
            if (discriminator?.JobType == global::Descript.JobStatusDiscriminatorJobType.ImportDivideprojectMedia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.ImportJobStatus), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.ImportJobStatus> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Descript.ImportJobStatus)}");
                importDivideprojectMedia = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Descript.AgentJobStatus? agent = default;
            if (discriminator?.JobType == global::Descript.JobStatusDiscriminatorJobType.Agent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.AgentJobStatus), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.AgentJobStatus> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Descript.AgentJobStatus)}");
                agent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Descript.JobStatus(
                discriminator?.JobType,
                importDivideprojectMedia,

                agent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.JobStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImportDivideprojectMedia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.ImportJobStatus), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.ImportJobStatus?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Descript.ImportJobStatus).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImportDivideprojectMedia, typeInfo);
            }
            else if (value.IsAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.AgentJobStatus), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.AgentJobStatus?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Descript.AgentJobStatus).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Agent, typeInfo);
            }
        }
    }
}