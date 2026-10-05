using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	internal static class TMP_ListPool<T>
	{
		// Token: 0x06000386 RID: 902 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000386")]
		public static List<T> Get()
		{
			return null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000387")]
		public static void Release(List<T> toRelease)
		{
		}

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly TMP_ObjectPool<List<T>> s_ListPool;
	}
}
