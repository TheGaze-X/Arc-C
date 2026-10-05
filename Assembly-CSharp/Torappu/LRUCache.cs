using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200055F RID: 1375
	[Token(Token = "0x200055F")]
	public class LRUCache<K, V>
	{
		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06005B2D RID: 23341 RVA: 0x0002EC20 File Offset: 0x0002CE20
		[Token(Token = "0x17000C9F")]
		public int capacity
		{
			[Token(Token = "0x6005B2D")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06005B2E RID: 23342 RVA: 0x0002EC38 File Offset: 0x0002CE38
		[Token(Token = "0x17000CA0")]
		public int count
		{
			[Token(Token = "0x6005B2E")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005B2F RID: 23343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B2F")]
		public LRUCache(int capacity)
		{
		}

		// Token: 0x06005B30 RID: 23344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B30")]
		public V Get(K key)
		{
			return null;
		}

		// Token: 0x06005B31 RID: 23345 RVA: 0x0002EC50 File Offset: 0x0002CE50
		[Token(Token = "0x6005B31")]
		public bool TryGetValue(K key, out V val)
		{
			return default(bool);
		}

		// Token: 0x06005B32 RID: 23346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B32")]
		public void Add(K key, V val)
		{
		}

		// Token: 0x06005B33 RID: 23347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B33")]
		public void Clear()
		{
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B34")]
		public void SetCapacity(int capacity)
		{
		}

		// Token: 0x06005B35 RID: 23349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B35")]
		private void _RemoveFirst()
		{
		}

		// Token: 0x040020E2 RID: 8418
		[Token(Token = "0x40020E2")]
		[FieldOffset(Offset = "0x0")]
		private int m_capacity;

		// Token: 0x040020E3 RID: 8419
		[Token(Token = "0x40020E3")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<K, LinkedListNode<KeyValuePair<K, V>>> m_cacheMap;

		// Token: 0x040020E4 RID: 8420
		[Token(Token = "0x40020E4")]
		[FieldOffset(Offset = "0x0")]
		private LinkedList<KeyValuePair<K, V>> m_lruQueue;
	}
}
