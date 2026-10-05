using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	public static class ValueTypeListExtensions
	{
		// Token: 0x06000536 RID: 1334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000536")]
		public static T SafeGet<T>(this ValueTypeList<T> list, int index, [Optional] T defaultVal) where T : struct
		{
			return null;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00005A8C File Offset: 0x00003C8C
		[Token(Token = "0x6000537")]
		public static int SafeCount<TWrapper>(this BaseValueTypeList<TWrapper> list) where TWrapper : class, new()
		{
			return 0;
		}
	}
}
