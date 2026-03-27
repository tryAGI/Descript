#nullable enable

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublishedProjectMetadataPublishTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.PublishedProjectMetadataPublishType?>
    {
        /// <inheritdoc />
        public override global::Descript.PublishedProjectMetadataPublishType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Descript.PublishedProjectMetadataPublishTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Descript.PublishedProjectMetadataPublishType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Descript.PublishedProjectMetadataPublishType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.PublishedProjectMetadataPublishType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Descript.PublishedProjectMetadataPublishTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
