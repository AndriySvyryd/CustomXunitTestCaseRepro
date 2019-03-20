// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Xunit;
using Xunit.Sdk;

namespace XunitRepro
{
    [AttributeUsage(AttributeTargets.Method)]
    [XunitTestCaseDiscoverer("XunitRepro.SkippedFactDiscoverer", "XunitRepro")]
    public sealed class SkippedFactAttribute : FactAttribute
    {
    }
}
