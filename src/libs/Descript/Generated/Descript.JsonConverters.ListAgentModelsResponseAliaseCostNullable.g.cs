#nullable enable

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListAgentModelsResponseAliaseCostNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.ListAgentModelsResponseAliaseCost?>
    {
        /// <inheritdoc />
        public override global::Descript.ListAgentModelsResponseAliaseCost? Read(
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
                        return global::Descript.ListAgentModelsResponseAliaseCostExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Descript.ListAgentModelsResponseAliaseCost)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Descript.ListAgentModelsResponseAliaseCost?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.ListAgentModelsResponseAliaseCost? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Descript.ListAgentModelsResponseAliaseCostExtensions.ToValueString(value.Value));
            }
        }
    }
}
