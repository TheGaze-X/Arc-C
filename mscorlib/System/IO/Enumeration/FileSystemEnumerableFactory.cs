using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.IO.Enumeration
{
	// Token: 0x02000694 RID: 1684
	[Token(Token = "0x2000694")]
	internal static class FileSystemEnumerableFactory
	{
		// Token: 0x0600335D RID: 13149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600335D")]
		[Address(RVA = "0x4C986B0", Offset = "0x4C972B0", VA = "0x184C986B0")]
		internal static void NormalizeInputs(ref string directory, ref string expression, EnumerationOptions options)
		{
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x0001B5D0 File Offset: 0x000197D0
		[Token(Token = "0x600335E")]
		[Address(RVA = "0x4C983E0", Offset = "0x4C96FE0", VA = "0x184C983E0")]
		private static bool MatchesPattern(string expression, System.ReadOnlySpan<char> name, EnumerationOptions options)
		{
			return default(bool);
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600335F")]
		[Address(RVA = "0x4C99110", Offset = "0x4C97D10", VA = "0x184C99110")]
		internal static System.Collections.Generic.IEnumerable<string> UserFiles(string directory, string expression, EnumerationOptions options)
		{
			return null;
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003360")]
		[Address(RVA = "0x4C98CD0", Offset = "0x4C978D0", VA = "0x184C98CD0")]
		internal static System.Collections.Generic.IEnumerable<string> UserDirectories(string directory, string expression, EnumerationOptions options)
		{
			return null;
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003361")]
		[Address(RVA = "0x4C98EF0", Offset = "0x4C97AF0", VA = "0x184C98EF0")]
		internal static System.Collections.Generic.IEnumerable<string> UserEntries(string directory, string expression, EnumerationOptions options)
		{
			return null;
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003362")]
		[Address(RVA = "0x4C97FA0", Offset = "0x4C96BA0", VA = "0x184C97FA0")]
		internal static System.Collections.Generic.IEnumerable<FileInfo> FileInfos(string directory, string expression, EnumerationOptions options)
		{
			return null;
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003363")]
		[Address(RVA = "0x4C97D80", Offset = "0x4C96980", VA = "0x184C97D80")]
		internal static System.Collections.Generic.IEnumerable<DirectoryInfo> DirectoryInfos(string directory, string expression, EnumerationOptions options)
		{
			return null;
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003364")]
		[Address(RVA = "0x4C981C0", Offset = "0x4C96DC0", VA = "0x184C981C0")]
		internal static System.Collections.Generic.IEnumerable<FileSystemInfo> FileSystemInfos(string directory, string expression, EnumerationOptions options)
		{
			return null;
		}

		// Token: 0x04001C02 RID: 7170
		[Token(Token = "0x4001C02")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] s_unixEscapeChars;
	}
}
