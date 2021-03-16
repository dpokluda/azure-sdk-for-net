// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.DocumentTranslation
{
    public partial class DocumentStatusDetail
    {
        internal static DocumentStatusDetail DeserializeDocumentStatusDetail(JsonElement element)
        {
            Uri path = default;
            DateTimeOffset createdDateTimeUtc = default;
            DateTimeOffset lastActionDateTimeUtc = default;
            TranslationStatus status = default;
            string to = default;
            Optional<DocumentTranslationError> error = default;
            float progress = default;
            string id = default;
            Optional<long> characterCharged = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"))
                {
                    path = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdDateTimeUtc"))
                {
                    createdDateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastActionDateTimeUtc"))
                {
                    lastActionDateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new TranslationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("to"))
                {
                    to = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = DocumentTranslationError.DeserializeDocumentTranslationError(property.Value);
                    continue;
                }
                if (property.NameEquals("progress"))
                {
                    progress = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("characterCharged"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    characterCharged = property.Value.GetInt64();
                    continue;
                }
            }
            return new DocumentStatusDetail(path, createdDateTimeUtc, lastActionDateTimeUtc, status, to, error.Value, progress, id, Optional.ToNullable(characterCharged));
        }
    }
}
