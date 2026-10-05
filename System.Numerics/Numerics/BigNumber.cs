using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Numerics
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	internal static class BigNumber
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4F6DC90", Offset = "0x4F6C890", VA = "0x184F6DC90")]
		internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
		{
			return '\0';
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002112 File Offset: 0x00000312
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4F6C800", Offset = "0x4F6B400", VA = "0x184F6C800")]
		private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess)
		{
			return null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002112 File Offset: 0x00000312
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x4F6D010", Offset = "0x4F6BC10", VA = "0x184F6D010")]
		internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info)
		{
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002112 File Offset: 0x00000312
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4F6D100", Offset = "0x4F6BD00", VA = "0x184F6D100")]
		private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess)
		{
			return null;
		}
	}
}
