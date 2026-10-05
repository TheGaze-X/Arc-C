using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	public static class EnumInfoCache<TEnum> where TEnum : struct
	{
		// Token: 0x06000560 RID: 1376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000560")]
		public static TEnum[] GetValues()
		{
			return null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000561")]
		public static string ConvertToString(TEnum item)
		{
			return null;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000562")]
		public static TEnum ConvertFromString(string key)
		{
			return null;
		}

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x0")]
		private static TEnum[] s_values;

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, string> s_valueMap;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, int> s_enumMap;
	}
}
