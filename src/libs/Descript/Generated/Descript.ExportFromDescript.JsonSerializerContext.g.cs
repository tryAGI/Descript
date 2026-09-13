
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.Error429))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectMetadataPublishType), TypeInfoPropertyName = "PublishedProjectMetadataPublishType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectMetadataPrivacy), TypeInfoPropertyName = "PublishedProjectMetadataPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectMetadataMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectMetadataMetadataPublishedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectErrorError), TypeInfoPropertyName = "PublishedProjectErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectPrivateError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectPrivateErrorError), TypeInfoPropertyName = "PublishedProjectPrivateErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectForbiddenErrorError), TypeInfoPropertyName = "PublishedProjectForbiddenErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectConflictError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectConflictErrorError), TypeInfoPropertyName = "PublishedProjectConflictErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectConflictErrorState), TypeInfoPropertyName = "PublishedProjectConflictErrorState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectMetadataPublishType?), TypeInfoPropertyName = "NullablePublishedProjectMetadataPublishType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectMetadataPrivacy?), TypeInfoPropertyName = "NullablePublishedProjectMetadataPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectErrorError?), TypeInfoPropertyName = "NullablePublishedProjectErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectPrivateErrorError?), TypeInfoPropertyName = "NullablePublishedProjectPrivateErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectForbiddenErrorError?), TypeInfoPropertyName = "NullablePublishedProjectForbiddenErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectConflictErrorError?), TypeInfoPropertyName = "NullablePublishedProjectConflictErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectConflictErrorState?), TypeInfoPropertyName = "NullablePublishedProjectConflictErrorState2")]
    internal sealed partial class ExportFromDescriptSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExportFromDescriptSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ExportFromDescriptSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ExportFromDescriptSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Descript.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Descript.PublishedProjectMetadataPublishType)

                    || typeToConvert == typeof(global::Descript.PublishedProjectMetadataPublishType?)

                    || typeToConvert == typeof(global::Descript.PublishedProjectMetadataPrivacy)

                    || typeToConvert == typeof(global::Descript.PublishedProjectMetadataPrivacy?)

                    || typeToConvert == typeof(global::Descript.PublishedProjectErrorError)

                    || typeToConvert == typeof(global::Descript.PublishedProjectErrorError?)

                    || typeToConvert == typeof(global::Descript.PublishedProjectPrivateErrorError)

                    || typeToConvert == typeof(global::Descript.PublishedProjectPrivateErrorError?)

                    || typeToConvert == typeof(global::Descript.PublishedProjectForbiddenErrorError)

                    || typeToConvert == typeof(global::Descript.PublishedProjectForbiddenErrorError?)

                    || typeToConvert == typeof(global::Descript.PublishedProjectConflictErrorError)

                    || typeToConvert == typeof(global::Descript.PublishedProjectConflictErrorError?)

                    || typeToConvert == typeof(global::Descript.PublishedProjectConflictErrorState)

                    || typeToConvert == typeof(global::Descript.PublishedProjectConflictErrorState?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Descript.PublishedProjectMetadataPublishType))
                {
                    return new global::Descript.JsonConverters.PublishedProjectMetadataPublishTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Descript.PublishedProjectMetadataPublishType?))
                {
                    return new global::Descript.JsonConverters.PublishedProjectMetadataPublishTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Descript.PublishedProjectMetadataPrivacy))
                {
                    return new global::Descript.JsonConverters.PublishedProjectMetadataPrivacyJsonConverter();
                }

                if (typeToConvert == typeof(global::Descript.PublishedProjectMetadataPrivacy?))
                {
                    return new global::Descript.JsonConverters.PublishedProjectMetadataPrivacyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Descript.PublishedProjectErrorError))
                {
                    return new global::Descript.JsonConverters.PublishedProjectErrorErrorJsonConverter();
                }

                if (typeToConvert == typeof(global::Descript.PublishedProjectErrorError?))
                {
                    return new global::Descript.JsonConverters.PublishedProjectErrorErrorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Descript.PublishedProjectPrivateErrorError))
                {
                    return new global::Descript.JsonConverters.PublishedProjectPrivateErrorErrorJsonConverter();
                }

                if (typeToConvert == typeof(global::Descript.PublishedProjectPrivateErrorError?))
                {
                    return new global::Descript.JsonConverters.PublishedProjectPrivateErrorErrorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Descript.PublishedProjectForbiddenErrorError))
                {
                    return new global::Descript.JsonConverters.PublishedProjectForbiddenErrorErrorJsonConverter();
                }

                if (typeToConvert == typeof(global::Descript.PublishedProjectForbiddenErrorError?))
                {
                    return new global::Descript.JsonConverters.PublishedProjectForbiddenErrorErrorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Descript.PublishedProjectConflictErrorError))
                {
                    return new global::Descript.JsonConverters.PublishedProjectConflictErrorErrorJsonConverter();
                }

                if (typeToConvert == typeof(global::Descript.PublishedProjectConflictErrorError?))
                {
                    return new global::Descript.JsonConverters.PublishedProjectConflictErrorErrorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Descript.PublishedProjectConflictErrorState))
                {
                    return new global::Descript.JsonConverters.PublishedProjectConflictErrorStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Descript.PublishedProjectConflictErrorState?))
                {
                    return new global::Descript.JsonConverters.PublishedProjectConflictErrorStateNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ExportFromDescriptSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}