using System;
using Il2CppDummyDll;

namespace System.IO.Enumeration
{
	// Token: 0x0200069C RID: 1692
	[Token(Token = "0x200069C")]
	public static class FileSystemName
	{
		// Token: 0x0600337A RID: 13178 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600337A")]
		[Address(RVA = "0x4C99DD0", Offset = "0x4C989D0", VA = "0x184C99DD0")]
		public static string TranslateWin32Expression(string expression)
		{
			return null;
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x0001B678 File Offset: 0x00019878
		[Token(Token = "0x600337B")]
		[Address(RVA = "0x4C99D40", Offset = "0x4C98940", VA = "0x184C99D40")]
		public static bool MatchesWin32Expression(System.ReadOnlySpan<char> expression, System.ReadOnlySpan<char> name, bool ignoreCase = true)
		{
			return default(bool);
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x0001B690 File Offset: 0x00019890
		[Token(Token = "0x600337C")]
		[Address(RVA = "0x4C99CB0", Offset = "0x4C988B0", VA = "0x184C99CB0")]
		public static bool MatchesSimpleExpression(System.ReadOnlySpan<char> expression, System.ReadOnlySpan<char> name, bool ignoreCase = true)
		{
			return default(bool);
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x0001B6A8 File Offset: 0x000198A8
		[Token(Token = "0x600337D")]
		[Address(RVA = "0x4C993C0", Offset = "0x4C97FC0", VA = "0x184C993C0")]
		private static bool MatchPattern(System.ReadOnlySpan<char> expression, System.ReadOnlySpan<char> name, bool ignoreCase, bool useExtendedWildcards)
		{
			return default(bool);
		}

		// Token: 0x04001C16 RID: 7190
		[Token(Token = "0x4001C16")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] s_wildcardChars;

		// Token: 0x04001C17 RID: 7191
		[Token(Token = "0x4001C17")]
		[FieldOffset(Offset = "0x8")]
		private static readonly char[] s_simpleWildcardChars;
	}
}
