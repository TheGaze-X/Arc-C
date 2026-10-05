using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200055B RID: 1371
	[Token(Token = "0x200055B")]
	[Serializable]
	public class ListCounterPool<TItem> : List<KeyValuePair<TItem, int>> where TItem : IEquatable<TItem>
	{
		// Token: 0x06005B17 RID: 23319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B17")]
		public ListCounterPool()
		{
		}

		// Token: 0x06005B18 RID: 23320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B18")]
		public ListCounterPool(int capacity)
		{
		}

		// Token: 0x06005B19 RID: 23321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B19")]
		public void Clear(TItem item)
		{
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x0002EB90 File Offset: 0x0002CD90
		[Token(Token = "0x6005B1A")]
		public bool ContainsKey(TItem item)
		{
			return default(bool);
		}

		// Token: 0x06005B1B RID: 23323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B1B")]
		public void Push(TItem item)
		{
		}

		// Token: 0x06005B1C RID: 23324 RVA: 0x0002EBA8 File Offset: 0x0002CDA8
		[Token(Token = "0x6005B1C")]
		public bool Pop(TItem item)
		{
			return default(bool);
		}

		// Token: 0x06005B1D RID: 23325 RVA: 0x0002EBC0 File Offset: 0x0002CDC0
		[Token(Token = "0x6005B1D")]
		public int GetCount(TItem item)
		{
			return 0;
		}

		// Token: 0x06005B1E RID: 23326 RVA: 0x0002EBD8 File Offset: 0x0002CDD8
		[Token(Token = "0x6005B1E")]
		private int _IndexOf(TItem item)
		{
			return 0;
		}
	}
}
