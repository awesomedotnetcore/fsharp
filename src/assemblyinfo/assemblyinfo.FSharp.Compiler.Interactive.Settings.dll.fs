// Copyright (c) Microsoft Corporation.  All Rights Reserved.  See License.txt in the project root for license information.

namespace Microsoft.FSharp
open System.Reflection
open System.Runtime.InteropServices

[<assembly:AssemblyDescription("FSharp.Compiler.Interactive.Settings.dll")>]
[<assembly:AssemblyCompany("Microsoft Corporation")>]
[<assembly:AssemblyTitle("FSharp.Compiler.Interactive.Settings.dll")>]
[<assembly:AssemblyCopyright("\169 Microsoft Corporation.  All Rights Reserved.")>]
[<assembly:AssemblyProduct("Microsoft\174 F#")>]
[<assembly:ComVisible(false)>]

#if STRONG_NAME_FSHARP_COMPILER_WITH_TEST_KEY
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("fsi, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("fsiAnyCpu, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
#endif

// Until dotnet sdk can version assemblies, use this
#if BUILD_FROM_SOURCE
[<assembly: System.Reflection.AssemblyInformationalVersion("4.4.1.0")>]
[<assembly: System.Reflection.AssemblyVersion("4.4.1.0")>]
[<assembly: System.Reflection.AssemblyFileVersion("2017.06.27.0")>]
#endif

do()
