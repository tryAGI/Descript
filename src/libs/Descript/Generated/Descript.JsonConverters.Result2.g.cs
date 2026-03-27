#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public class Result2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.Result2>
    {
        /// <inheritdoc />
        public override global::Descript.Result2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.AgentJobStatusResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.AgentJobStatusResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Descript.AgentJobStatusResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Descript.AgentSuccessResult? success = default;
            if (discriminator?.Status == global::Descript.AgentJobStatusResultDiscriminatorStatus.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.AgentSuccessResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.AgentSuccessResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Descript.AgentSuccessResult)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Descript.AgentErrorResult? error = default;
            if (discriminator?.Status == global::Descript.AgentJobStatusResultDiscriminatorStatus.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.AgentErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.AgentErrorResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Descript.AgentErrorResult)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Descript.Result2(
                discriminator?.Status,
                success,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.Result2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.AgentSuccessResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.AgentSuccessResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Descript.AgentSuccessResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.AgentErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.AgentErrorResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Descript.AgentErrorResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
        }
    }
}