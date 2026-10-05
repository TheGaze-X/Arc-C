using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.I18N
{
	// Token: 0x0200162A RID: 5674
	[Token(Token = "0x200162A")]
	public class StringMap
	{
		// Token: 0x060080BC RID: 32956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60080BC")]
		[Address(RVA = "0x28A0A40", Offset = "0x289F640", VA = "0x1828A0A40")]
		public static string Get(string key)
		{
			return null;
		}

		// Token: 0x060080BD RID: 32957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080BD")]
		[Address(RVA = "0x28A0F40", Offset = "0x289FB40", VA = "0x1828A0F40")]
		public static void LoadStringMap()
		{
		}

		// Token: 0x060080BE RID: 32958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080BE")]
		[Address(RVA = "0x28A0B90", Offset = "0x289F790", VA = "0x1828A0B90")]
		public static void LoadStringMapFromText(string stringMapStr, ref Dictionary<string, string> strMap, [Optional] Action<string> onInvalidLine, bool processEscapeChar = true)
		{
		}

		// Token: 0x060080BF RID: 32959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080BF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StringMap()
		{
		}

		// Token: 0x04008221 RID: 33313
		[Token(Token = "0x4008221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, string> s_stringResDict;

		// Token: 0x04008222 RID: 33314
		[Token(Token = "0x4008222")]
		public const string I18N_STRING_MAP_PATH = "I18N/string_map";
	}
}
