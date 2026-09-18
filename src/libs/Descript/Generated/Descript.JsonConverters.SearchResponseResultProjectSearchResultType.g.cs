#nullable enable

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchResponseResultProjectSearchResultTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.SearchResponseResultProjectSearchResultType>
    {
        /// <inheritdoc />
        public override global::Descript.SearchResponseResultProjectSearchResultType Read(
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
                        return global::Descript.SearchResponseResultProjectSearchResultTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Descript.SearchResponseResultProjectSearchResultType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Descript.SearchResponseResultProjectSearchResultType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.SearchResponseResultProjectSearchResultType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Descript.SearchResponseResultProjectSearchResultTypeExtensions.ToValueString(value));
        }
    }
}
