#nullable enable

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public sealed class DriveMediaImportJobStatusResultVariant1MediaStatusStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatusStatus>
    {
        /// <inheritdoc />
        public override global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatusStatus Read(
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
                        return global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatusStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatusStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatusStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatusStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatusStatusExtensions.ToValueString(value));
        }
    }
}
