#nullable enable

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetProjectResponsePublisheAccessLevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.GetProjectResponsePublisheAccessLevel?>
    {
        /// <inheritdoc />
        public override global::Descript.GetProjectResponsePublisheAccessLevel? Read(
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
                        return global::Descript.GetProjectResponsePublisheAccessLevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Descript.GetProjectResponsePublisheAccessLevel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Descript.GetProjectResponsePublisheAccessLevel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.GetProjectResponsePublisheAccessLevel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Descript.GetProjectResponsePublisheAccessLevelExtensions.ToValueString(value.Value));
            }
        }
    }
}
