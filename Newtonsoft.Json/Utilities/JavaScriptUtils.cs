using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	[Preserve]
	internal static class JavaScriptUtils
	{
		// Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x4D87FF0", Offset = "0x4D86BF0", VA = "0x184D87FF0")]
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
		{
			return null;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x4D880C0", Offset = "0x4D86CC0", VA = "0x184D880C0")]
		public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags)
		{
			return default(bool);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x4D884A0", Offset = "0x4D870A0", VA = "0x184D884A0")]
		public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer)
		{
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x4D88150", Offset = "0x4D86D50", VA = "0x184D88150")]
		public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly bool[] SingleQuoteCharEscapeFlags;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly bool[] DoubleQuoteCharEscapeFlags;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly bool[] HtmlCharEscapeFlags;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		private const int UnicodeTextLength = 6;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		private const string EscapedUnicodeText = "!";
	}
}
