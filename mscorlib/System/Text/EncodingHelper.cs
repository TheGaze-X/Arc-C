using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x20002B8")]
	internal static class EncodingHelper
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700025F")]
		internal static Encoding UTF8Unmarked
		{
			[Token(Token = "0x6001773")]
			[Address(RVA = "0x4B0D260", Offset = "0x4B0BE60", VA = "0x184B0D260")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001774 RID: 6004
		[Token(Token = "0x6001774")]
		[Address(RVA = "0x4B0CC20", Offset = "0x4B0B820", VA = "0x184B0CC20")]
		[MethodImpl(4096)]
		internal static extern string InternalCodePage(ref int code_page);

		// Token: 0x06001775 RID: 6005 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001775")]
		[Address(RVA = "0x4B0CB10", Offset = "0x4B0B710", VA = "0x184B0CB10")]
		internal static Encoding GetDefaultEncoding()
		{
			return null;
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001776")]
		[Address(RVA = "0x4B0CC30", Offset = "0x4B0B830", VA = "0x184B0CC30")]
		internal static object InvokeI18N(string name, params object[] args)
		{
			return null;
		}

		// Token: 0x04000CB8 RID: 3256
		[Token(Token = "0x4000CB8")]
		[FieldOffset(Offset = "0x0")]
		private static Encoding utf8EncodingWithoutMarkers;

		// Token: 0x04000CB9 RID: 3257
		[Token(Token = "0x4000CB9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object lockobj;

		// Token: 0x04000CBA RID: 3258
		[Token(Token = "0x4000CBA")]
		[FieldOffset(Offset = "0x10")]
		private static System.Reflection.Assembly i18nAssembly;

		// Token: 0x04000CBB RID: 3259
		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x18")]
		private static bool i18nDisabled;
	}
}
