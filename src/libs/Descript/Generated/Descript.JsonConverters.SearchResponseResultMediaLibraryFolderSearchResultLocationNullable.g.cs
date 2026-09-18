#nullable enable

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchResponseResultMediaLibraryFolderSearchResultLocationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.SearchResponseResultMediaLibraryFolderSearchResultLocation?>
    {
        /// <inheritdoc />
        public override global::Descript.SearchResponseResultMediaLibraryFolderSearchResultLocation? Read(
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
                        return global::Descript.SearchResponseResultMediaLibraryFolderSearchResultLocationExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Descript.SearchResponseResultMediaLibraryFolderSearchResultLocation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Descript.SearchResponseResultMediaLibraryFolderSearchResultLocation?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.SearchResponseResultMediaLibraryFolderSearchResultLocation? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Descript.SearchResponseResultMediaLibraryFolderSearchResultLocationExtensions.ToValueString(value.Value));
            }
        }
    }
}
