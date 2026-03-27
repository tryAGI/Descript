#nullable enable

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImportProjectMediaRequestTeamAccessJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.ImportProjectMediaRequestTeamAccess>
    {
        /// <inheritdoc />
        public override global::Descript.ImportProjectMediaRequestTeamAccess Read(
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
                        return global::Descript.ImportProjectMediaRequestTeamAccessExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Descript.ImportProjectMediaRequestTeamAccess)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Descript.ImportProjectMediaRequestTeamAccess);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.ImportProjectMediaRequestTeamAccess value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Descript.ImportProjectMediaRequestTeamAccessExtensions.ToValueString(value));
        }
    }
}
