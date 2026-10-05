using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Pool
{
	// Token: 0x0200022E RID: 558
	[Token(Token = "0x200022E")]
	public class CollectionPool<TCollection, TItem> where TCollection : class, ICollection<TItem>, new()
	{
		// Token: 0x06000D30 RID: 3376 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D30")]
		public static TCollection Get()
		{
			return null;
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00006BB8 File Offset: 0x00004DB8
		[Token(Token = "0x6000D31")]
		public static PooledObject<TCollection> Get(out TCollection value)
		{
			return default(PooledObject<TCollection>);
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D32")]
		public static void Release(TCollection toRelease)
		{
		}

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly ObjectPool<TCollection> s_Pool;
	}
}
