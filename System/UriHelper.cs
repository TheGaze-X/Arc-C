using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	internal static class UriHelper
	{
		// Token: 0x06000418 RID: 1048 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x50E19D0", Offset = "0x50E05D0", VA = "0x1850E19D0")]
		internal unsafe static bool TestForSubPath(char* pMe, ushort meLength, char* pShe, ushort sheLength, bool ignoreCase)
		{
			return default(bool);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x50E0AE0", Offset = "0x50DF6E0", VA = "0x1850E0AE0")]
		internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd)
		{
			return null;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x50E08D0", Offset = "0x50DF4D0", VA = "0x1850E08D0")]
		private unsafe static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos)
		{
			return null;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x50E1B70", Offset = "0x50E0770", VA = "0x1850E1B70")]
		internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery)
		{
			return null;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x50E1C50", Offset = "0x50E0850", VA = "0x1850E1C50")]
		internal unsafe static char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery)
		{
			return null;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x50E1570", Offset = "0x50E0170", VA = "0x1850E1570")]
		internal unsafe static void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x50E09D0", Offset = "0x50DF5D0", VA = "0x1850E09D0")]
		internal static void EscapeAsciiChar(char ch, char[] to, ref int pos)
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x50E11A0", Offset = "0x50DFDA0", VA = "0x1850E11A0")]
		internal static char EscapedAscii(char digit, char next)
		{
			return '\0';
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x50E12D0", Offset = "0x50DFED0", VA = "0x1850E12D0")]
		internal static bool IsNotSafeForUnescape(char ch)
		{
			return default(bool);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x50E1320", Offset = "0x50DFF20", VA = "0x1850E1320")]
		private static bool IsReservedUnreservedOrHash(char c)
		{
			return default(bool);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x50E1450", Offset = "0x50E0050", VA = "0x1850E1450")]
		internal static bool IsUnreserved(char c)
		{
			return default(bool);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x50E1240", Offset = "0x50DFE40", VA = "0x1850E1240")]
		internal static bool Is3986Unreserved(char c)
		{
			return default(bool);
		}

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] HexUpperChars;
	}
}
