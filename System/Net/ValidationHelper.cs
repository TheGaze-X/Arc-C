using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002B6 RID: 694
	[Token(Token = "0x20002B6")]
	internal static class ValidationHelper
	{
		// Token: 0x0600135A RID: 4954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135A")]
		[Address(RVA = "0x51B5C40", Offset = "0x51B4840", VA = "0x1851B5C40")]
		public static string MakeStringNull(string stringValue)
		{
			return null;
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x600135B")]
		[Address(RVA = "0x51B5C30", Offset = "0x51B4830", VA = "0x1851B5C30")]
		public static bool IsBlankString(string stringValue)
		{
			return default(bool);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x000095B8 File Offset: 0x000077B8
		[Token(Token = "0x600135C")]
		[Address(RVA = "0x51B4E70", Offset = "0x51B3A70", VA = "0x1851B4E70")]
		public static bool ValidateTcpPort(int port)
		{
			return default(bool);
		}

		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4000A57")]
		[FieldOffset(Offset = "0x0")]
		public static string[] EmptyArray;

		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4000A58")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly char[] InvalidMethodChars;

		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4000A59")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly char[] InvalidParamChars;
	}
}
