#nullable enable

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublishErrorResultStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.PublishErrorResultStatus>
    {
        /// <inheritdoc />
        public override global::Descript.PublishErrorResultStatus Read(
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
                        return global::Descript.PublishErrorResultStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Descript.PublishErrorResultStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Descript.PublishErrorResultStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.PublishErrorResultStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Descript.PublishErrorResultStatusExtensions.ToValueString(value));
        }
    }
}
