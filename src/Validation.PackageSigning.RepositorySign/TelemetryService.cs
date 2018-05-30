﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using NuGet.Services.Logging;

namespace Validation.PackageSigning.RepositorySign
{
    public class TelemetryService : ITelemetryService
    {
        private readonly ITelemetryClient _client;

        private const string Prefix = "RepositorySign.";

        public TelemetryService(ITelemetryClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }
    }
}
