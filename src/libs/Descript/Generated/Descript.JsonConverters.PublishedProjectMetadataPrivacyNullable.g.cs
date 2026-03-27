#nullable enable

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublishedProjectMetadataPrivacyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.PublishedProjectMetadataPrivacy?>
    {
        /// <inheritdoc />
        public override global::Descript.PublishedProjectMetadataPrivacy? Read(
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
                        return global::Descript.PublishedProjectMetadataPrivacyExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Descript.PublishedProjectMetadataPrivacy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Descript.PublishedProjectMetadataPrivacy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.PublishedProjectMetadataPrivacy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Descript.PublishedProjectMetadataPrivacyExtensions.ToValueString(value.Value));
            }
        }
    }
}
