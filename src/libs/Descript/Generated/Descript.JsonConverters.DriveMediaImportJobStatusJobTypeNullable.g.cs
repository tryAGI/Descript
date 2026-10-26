#nullable enable

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public sealed class DriveMediaImportJobStatusJobTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.DriveMediaImportJobStatusJobType?>
    {
        /// <inheritdoc />
        public override global::Descript.DriveMediaImportJobStatusJobType? Read(
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
                        return global::Descript.DriveMediaImportJobStatusJobTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Descript.DriveMediaImportJobStatusJobType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Descript.DriveMediaImportJobStatusJobType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.DriveMediaImportJobStatusJobType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Descript.DriveMediaImportJobStatusJobTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
