#nullable enable

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublishedProjectConflictErrorErrorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.PublishedProjectConflictErrorError>
    {
        /// <inheritdoc />
        public override global::Descript.PublishedProjectConflictErrorError Read(
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
                        return global::Descript.PublishedProjectConflictErrorErrorExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Descript.PublishedProjectConflictErrorError)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Descript.PublishedProjectConflictErrorError);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.PublishedProjectConflictErrorError value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Descript.PublishedProjectConflictErrorErrorExtensions.ToValueString(value));
        }
    }
}
