using System;
using Il2CppDummyDll;

namespace Hypergryph.ToolKits
{
	// Token: 0x02000101 RID: 257
	[Token(Token = "0x2000101")]
	public class LocalGenericPool<T> where T : class, new()
	{
		// Token: 0x0600047C RID: 1148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600047C")]
		public LocalGenericPool(Action<T> actionOnRelease, int poolSize = 0)
		{
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047D")]
		public T Get()
		{
			return null;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600047E")]
		public void Release(T item)
		{
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600047F")]
		private void _OnRelease(object obj)
		{
		}

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		private const int DEFAULT_LOCAL_POOL_SIZE = 10000000;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x0")]
		private readonly ObjectPool m_pool;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x0")]
		private readonly Action<T> m_actionOnRelease;
	}
}
