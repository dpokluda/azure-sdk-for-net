// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.DocumentTranslation;

namespace Azure.AI.DocumentTranslation.Models
{
    /// <summary> Base type for List return in our api. </summary>
    internal partial class StorageSourceListResult
    {
        /// <summary> Initializes a new instance of StorageSourceListResult. </summary>
        /// <param name="value"> list of objects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal StorageSourceListResult(IEnumerable<StorageSource> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of StorageSourceListResult. </summary>
        /// <param name="value"> list of objects. </param>
        internal StorageSourceListResult(IReadOnlyList<StorageSource> value)
        {
            Value = value;
        }

        /// <summary> list of objects. </summary>
        public IReadOnlyList<StorageSource> Value { get; }
    }
}
