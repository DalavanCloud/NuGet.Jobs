﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace NuGet.Jobs.Montoring.PackageLag
{
    class Program
    {
        static int Main(string[] args)
        {
            var job = new Job();
            JobRunner.Run(job, args).Wait();
            return 0;
        }
    }
}
