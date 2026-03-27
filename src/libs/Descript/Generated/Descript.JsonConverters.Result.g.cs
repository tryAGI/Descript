#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public class ResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.Result>
    {
        /// <inheritdoc />
        public override global::Descript.Result Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.ImportJobStatusResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.ImportJobStatusResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Descript.ImportJobStatusResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Descript.ImportSuccessResult? success = default;
            if (discriminator?.Status == global::Descript.ImportJobStatusResultDiscriminatorStatus.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.ImportSuccessResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.ImportSuccessResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Descript.ImportSuccessResult)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Descript.ImportErrorResult? error = default;
            if (discriminator?.Status == global::Descript.ImportJobStatusResultDiscriminatorStatus.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.ImportErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.ImportErrorResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Descript.ImportErrorResult)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Descript.Result(
                discriminator?.Status,
                success,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.Result value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.ImportSuccessResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.ImportSuccessResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Descript.ImportSuccessResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Descript.ImportErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Descript.ImportErrorResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Descript.ImportErrorResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
        }
    }
}