using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	internal class ObjectListPool<T>
	{
		// Token: 0x06000569 RID: 1385 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000569")]
		public static List<T> Get()
		{
			return null;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056A")]
		public static void Release(List<T> elements)
		{
		}

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectPool<List<T>> pool;
	}
}
