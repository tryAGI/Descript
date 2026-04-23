#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public class Result3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.Result3>
    {
        /// <inheritdoc />
        public override global::Descript.Result3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.PublishJobStatusResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.PublishJobStatusResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Descript.PublishJobStatusResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Descript.PublishSuccessResult? success = default;
            if (discriminator?.Status == global::Descript.PublishJobStatusResultDiscriminatorStatus.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.PublishSuccessResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.PublishSuccessResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Descript.PublishSuccessResult)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Descript.PublishErrorResult? error = default;
            if (discriminator?.Status == global::Descript.PublishJobStatusResultDiscriminatorStatus.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.PublishErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.PublishErrorResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Descript.PublishErrorResult)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Descript.Result3(
                discriminator?.Status,
                success,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.Result3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.PublishSuccessResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.PublishSuccessResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Descript.PublishSuccessResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.PublishErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.PublishErrorResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Descript.PublishErrorResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}