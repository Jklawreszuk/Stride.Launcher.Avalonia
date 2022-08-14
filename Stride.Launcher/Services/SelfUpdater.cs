// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System.Reflection;

namespace Stride.Launcher.Services
{
    public static class SelfUpdater
    {
        public static readonly string Version;

        static SelfUpdater()
        {
            var assembly = Assembly.GetEntryAssembly();
            var assemblyInformationalVersion = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            Version = assemblyInformationalVersion.InformationalVersion;
        }

    }
}
