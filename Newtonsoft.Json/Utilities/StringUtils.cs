using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	[Preserve]
	internal static class StringUtils
	{
		// Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x4D97B60", Offset = "0x4D96760", VA = "0x184D97B60")]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0)
		{
			return null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x4D97C90", Offset = "0x4D96890", VA = "0x184D97C90")]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1)
		{
			return null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x4D97980", Offset = "0x4D96580", VA = "0x184D97980")]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2)
		{
			return null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x4D97750", Offset = "0x4D96350", VA = "0x184D97750")]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x4D976A0", Offset = "0x4D962A0", VA = "0x184D976A0")]
		private static string FormatWith(this string format, IFormatProvider provider, params object[] args)
		{
			return null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x4D97F20", Offset = "0x4D96B20", VA = "0x184D97F20")]
		public static bool IsWhiteSpace(string s)
		{
			return default(bool);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x4D98020", Offset = "0x4D96C20", VA = "0x184D98020")]
		public static string NullEmptyString(string s)
		{
			return null;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x4D97590", Offset = "0x4D96190", VA = "0x184D97590")]
		public static StringWriter CreateStringWriter(int capacity)
		{
			return null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x4D97E20", Offset = "0x4D96A20", VA = "0x184D97E20")]
		public static int? GetLength(string value)
		{
			return null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x4D982A0", Offset = "0x4D96EA0", VA = "0x184D982A0")]
		public static void ToCharAsUnicode(char c, char[] buffer)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042F")]
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			return null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x4D98090", Offset = "0x4D96C90", VA = "0x184D98090")]
		public static string ToCamelCase(string s)
		{
			return null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x4D97E80", Offset = "0x4D96A80", VA = "0x184D97E80")]
		public static bool IsHighSurrogate(char c)
		{
			return default(bool);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x4D97ED0", Offset = "0x4D96AD0", VA = "0x184D97ED0")]
		public static bool IsLowSurrogate(char c)
		{
			return default(bool);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x4D98050", Offset = "0x4D96C50", VA = "0x184D98050")]
		public static bool StartsWith(this string source, char value)
		{
			return default(bool);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x4D97660", Offset = "0x4D96260", VA = "0x184D97660")]
		public static bool EndsWith(this string source, char value)
		{
			return default(bool);
		}

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		public const string CarriageReturnLineFeed = "\r\n";

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		public const string Empty = "";

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		public const char CarriageReturn = '\r';

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		public const char LineFeed = '\n';

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		public const char Tab = '\t';
	}
}
