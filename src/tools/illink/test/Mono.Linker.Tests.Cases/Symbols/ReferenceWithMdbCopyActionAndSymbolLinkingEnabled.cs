﻿using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;
using Mono.Linker.Tests.Cases.Symbols.Dependencies;

namespace Mono.Linker.Tests.Cases.Symbols
{
	[TestCaseRequirements (TestRunCharacteristics.TargetingNetFramework, "mdb files are not supported with .NET Core")]
	[Reference ("Dependencies/LibraryWithMdb/LibraryWithMdb.dll")]
	[ReferenceDependency ("Dependencies/LibraryWithMdb/LibraryWithMdb.dll.mdb")]
	[SetupLinkerLinkSymbols ("true")]
	[SetupLinkerAction ("copy", "LibraryWithMdb")]

	[KeptSymbols ("LibraryWithMdb.dll")]
	public class ReferenceWithMdbCopyActionAndSymbolLinkingEnabled
	{
		static void Main ()
		{
			LibraryWithMdb.SomeMethod ();
		}
	}
}