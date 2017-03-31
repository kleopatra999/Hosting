// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.Hosting
{
    public class HostingContext : IHostingContext
    {
        public IConfiguration Configuration { get; internal set; }

        public IHostingEnvironment Environment { get; internal set; }

        public ILoggerFactory LoggerFactory { get; internal set; }
    }
}
