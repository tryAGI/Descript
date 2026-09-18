#nullable enable

namespace Descript.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchResponseResultMediaLibraryFolderSearchResultTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Descript.SearchResponseResultMediaLibraryFolderSearchResultType?>
    {
        /// <inheritdoc />
        public override global::Descript.SearchResponseResultMediaLibraryFolderSearchResultType? Read(
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
                        return global::Descript.SearchResponseResultMediaLibraryFolderSearchResultTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Descript.SearchResponseResultMediaLibraryFolderSearchResultType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Descript.SearchResponseResultMediaLibraryFolderSearchResultType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Descript.SearchResponseResultMediaLibraryFolderSearchResultType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Descript.SearchResponseResultMediaLibraryFolderSearchResultTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
